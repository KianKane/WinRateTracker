using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the update build view.
    /// </summary>
    public class UpdateBuildPresenter
    {
        private IUpdateBuildView view;
        private IMessenger messenger;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The IUpdateBuildView instance controlled by this presenter. </param>
        /// <param name="messenger"> The messenger that this presenter uses.  If this is left blank then the presenter will use Messenger.Instance. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public UpdateBuildPresenter(IUpdateBuildView view, IMessenger messenger = null, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            if (messenger == null)
                messenger = Messenger.Instance;
            this.messenger = messenger;
            view.Confirm += Confirm;
            view.Cancel += Cancel;
            // Set up the view with the name, note, and archetype of the build to be modified.
            view.BuildName = model.GetBuildName(view.BuildID);
            view.BuildNote = model.GetBuildNote(view.BuildID);
            view.ArchetypeName = model.GetArchetypeName(model.GetBuildArchetypeID(view.BuildID));
        }

        /// <summary>  Validate view input and update the selected build in the model if the input is valid. </summary>
        private void Confirm()
        {
            string buildName = view.BuildName.Trim();
            string buildNote = view.BuildNote.Trim();
            int buildID = view.BuildID;

            if (IsValid_BuildName(buildName) && IsValid_BuildNote(buildNote) && IsValid_BuildID(buildID))
            {
                model.UpdateBuild(buildID, buildName, buildNote);
                view.CloseDialog();
            }
        }

        /// <summary> Close the dialog without updating the build. </summary>
        private void Cancel()
        {
            view.CloseDialog();
        }

        /// <summary> Checks the validity of the given build name. </summary>
        private bool IsValid_BuildName(string buildName)
        {
            if (string.IsNullOrWhiteSpace(buildName)) // Build name cannot be empty.
            {
                messenger.Message("Invalid Name", "You must enter a name for the build.");
                return false;
            }
            if (buildName.Length > 50) // Build name cannot be longer than 50 characters.
            {
                messenger.Message("Invalid Name", "The build name cannot contain more than 50 characters.");
                return false;
            }
            return true;
        }

        /// <summary> Checks the validity of the given build note. </summary>
        private bool IsValid_BuildNote(string buildNote)
        {
            if (buildNote.Length > 200) // Build note cannot be longer than 200 characters.
            {
                messenger.Message("Invalid Note", "The build note cannot contain more than 200 characters.");
                return false;
            }
            return true;
        }

        /// <summary> Checks the validity of the given build id. </summary>
        private bool IsValid_BuildID(int buildID)
        {
            if (!model.BuildExists(buildID)) // Build with the given ID must exist in the model.
            {
                messenger.Message("Invalid Build", "The chosen build does not exist.");
                return false;
            }
            return true;
        }
    }
}
