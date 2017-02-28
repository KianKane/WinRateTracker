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
            if (string.IsNullOrWhiteSpace(buildName))
            {
                messenger.Message("Invalid Name", "You must enter a name for the archetype.");
            }
            else
            {
                model.UpdateBuild(view.BuildID, buildName, buildNote);
                view.CloseDialog();
            }
        }

        /// <summary> Close the dialog without updating the build. </summary>
        private void Cancel()
        {
            view.CloseDialog();
        }
    }
}
