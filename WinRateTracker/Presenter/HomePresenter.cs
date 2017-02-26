using System;
using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    class HomePresenter
    {
        private IHomeView view;
        private IModel model;

        public HomePresenter(IHomeView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.RecordVictory += RecordVictory;
            view.RecordDefeat += RecordDefeat;
            view.UpdateStatistics += UpdateStatistics;
            view.NewBuild += NewBuild;
            view.UpdateBuild += UpdateBuild;
            view.DeleteBuild += DeleteBuild;
            view.NewArchetype += NewArchetype;
            view.UpdateArchetype += UpdateArchetype;
            view.DeleteArchetype += DeleteArchetype;
        }

        private void RecordVictory()
        {
            if (view.SelectedBuildID == null)
                view.Message("Unable to record match", "No build is currently selected.");
            else if (view.SelectedArchetypeID == null)
                view.Message("Unable to record match", "No archetype is currently selected.");
            else if (view.Prompt("Confirmation", "Are you sure you want to record this victory?"))
                model.RecordMatch((int)view.SelectedBuildID, (int)view.SelectedArchetypeID, true);
        }

        private void RecordDefeat()
        {
            if (view.SelectedBuildID == null)
                view.Message("Unable to record match", "No build is currently selected.");
            else if (view.SelectedArchetypeID == null)
                view.Message("Unable to record match", "No archetype is currently selected.");
            else if (view.Prompt("Confirmation", "Are you sure you want to record this defeat?"))
                model.RecordMatch((int)view.SelectedBuildID, (int)view.SelectedArchetypeID, false);
        }

        private void UpdateStatistics()
        {
            int? buildID = view.SelectedBuildID;
            int? archetypeID = view.SelectedArchetypeID;

            if (view.AllBuilds)
                buildID = null;
            if (view.AllArchetypes)
                archetypeID = null;

            int wins = model.CountMatches(buildID, archetypeID, true);
            int losses = model.CountMatches(buildID, archetypeID, false);

            double winRate = (double)wins / (losses > 0 ? losses : 1);

            view.WinRate = winRate.ToString("F2");
            view.Wins = wins.ToString();
            view.Losses = losses.ToString();
        }

        private void NewBuild()
        {
            if (model.GetArchetypeCount() == 0)
                view.Message("Unable to create build", "You must have at least one archetype before creating a build.");
            else
                view.ShowNewBuildDialog();
        }

        private void UpdateBuild()
        {
            if (view.SelectedBuildID == null)
                view.Message("Unable to update build", "No build is currently selected.");
            else
                view.ShowUpdateBuildDialog();
        }

        private void DeleteBuild()
        {
            if (view.SelectedBuildID == null)
                view.Message("Unable to delete build", "No build is currently selected.");
            else if (view.Prompt("Confirmation", "Deleting this build will also delete all associated match information.  Are you sure you want to continue?"))
                model.DeleteBuild((int)view.SelectedBuildID);
        }

        private void NewArchetype()
        {
            view.ShowNewArchetypeDialog();
        }

        private void UpdateArchetype()
        {
            if (view.SelectedArchetypeID == null)
                view.Message("Unable to update archetype", "No archetype is currently selected.");
            else
                view.ShowUpdateArchetypeDialog();
        }

        private void DeleteArchetype()
        {
            if (view.SelectedArchetypeID == null)
                view.Message("Unable to delete archetype", "No archetype is currently selected.");
            else if (view.Prompt("Confirmation", "Deleting this archetype will also delete all associated build and match information.  Are you sure you want to continue?"))
                model.DeleteArchetype((int)view.SelectedArchetypeID);
        }
    }
}
