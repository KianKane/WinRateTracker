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
        /// 
        /// NOTE: ArchetypeID is not currently validated.  ArchetypeID must exist in the model.
        /// </summary>
        private void Confirm()
        {
            string buildName = view.BuildName.Trim();
            string buildNote = view.BuildNote.Trim();
            int archetypeID = view.ArchetypeID;
            if (string.IsNullOrWhiteSpace(buildName))
            {
                messenger.Message("Invalid Name", "You must enter a name for the build.");
            }
            else
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
    }
}
