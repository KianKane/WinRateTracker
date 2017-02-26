using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    class NewBuildPresenter
    {
        private INewBuildView view;
        private IModel model;

        public NewBuildPresenter(INewBuildView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.InsertBuild += InsertBuild;
        }

        private void InsertBuild()
        {
            string buildName = view.BuildName.Trim();
            string buildNote = view.BuildNote.Trim();
            int archetypeID = view.ArchetypeID;
            if (string.IsNullOrWhiteSpace(buildName))
            {
                view.Message("Invalid Name", "You must enter a name for the build.");
            }
            else
            {
                model.InsertBuild(buildName, buildNote, archetypeID);
                view.CloseDialog();
            }
        }
    }
}
