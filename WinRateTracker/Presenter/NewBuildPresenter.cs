using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the new build view.
    /// </summary>
    public class NewBuildPresenter
    {
        private INewBuildView view;
        private IMessenger messenger;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The INewBuildView instance controlled by this presenter. </param>
        /// <param name="messenger"> The messenger that this presenter uses.  If this is left blank then the presenter will use Messenger.Instance. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public NewBuildPresenter(INewBuildView view, IMessenger messenger = null, IModel model = null)
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
        }

        /// <summary> 
        /// Validate view input and insert a new build into the model if the input is valid. 
        /// </summary>
        private void Confirm()
        {
            string buildName = view.BuildName.Trim();
            string buildNote = view.BuildNote.Trim();
            int archetypeID = view.ArchetypeID;

            if (IsValid_BuildName(buildName) && IsValid_BuildNote(buildNote) && IsValid_ArchetypeID(archetypeID))
            {
                model.InsertBuild(buildName, buildNote, archetypeID);
                view.CloseDialog();
            }
        }

        /// <summary> Close the dialog without creating a new build. </summary>
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

        /// <summary> Checks the validity of the given build name. </summary>
        private bool IsValid_ArchetypeID(int archetypeID)
        {
            if (!model.ArchetypeExists(archetypeID)) // Build with the given ID must exist in the model.
            {
                messenger.Message("Invalid Build Archetype", "The chosen archetype does not exist.");
                return false;
            }
            return true;
        }
    }
}
