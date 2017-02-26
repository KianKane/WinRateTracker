using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    class UpdateBuildPresenter
    {
        private IUpdateBuildView view;
        private IModel model;

        public UpdateBuildPresenter(IUpdateBuildView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.UpdateBuild += UpdateBuild;
            view.BuildName = model.GetBuildName(view.BuildID);
            view.BuildNote = model.GetBuildNote(view.BuildID);
            view.ArchetypeName = model.GetArchetypeName(model.GetBuildArchetypeID(view.BuildID));
        }

        private void UpdateBuild()
        {
            string buildName = view.BuildName.Trim();
            string buildNote = view.BuildNote.Trim();
            if (string.IsNullOrWhiteSpace(buildName))
            {
                view.Message("Invalid Name", "You must enter a name for the archetype.");
            }
            else
            {
                model.UpdateBuild(view.BuildID, buildName, buildNote);
                view.CloseDialog();
            }
        }
    }
}
