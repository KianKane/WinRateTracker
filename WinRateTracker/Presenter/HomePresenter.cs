using WinRateTracker.Calculation;
using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the home view.
    /// </summary>
    public class HomePresenter
    {
        private IHomeView view;
        private IMessenger messenger;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The IHomeView instance controlled by this presenter. </param>
        /// <param name="messenger"> The messenger that this presenter uses.  If this is left blank then the presenter will use Messenger.Instance. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public HomePresenter(IHomeView view, IMessenger messenger = null, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            if (messenger == null)
                messenger = Messenger.Instance;
            this.messenger = messenger;
            // Subscribe to view events.
            view.RecordVictory += RecordVictory;
            view.RecordDefeat += RecordDefeat;
            view.UpdateStatistics += UpdateStatistics;
            view.NewBuild += NewBuild;
            view.UpdateBuild += UpdateBuild;
            view.DeleteBuild += DeleteBuild;
            view.NewArchetype += NewArchetype;
            view.UpdateArchetype += UpdateArchetype;
            view.DeleteArchetype += DeleteArchetype;
            // If there are no archetypes then show the setup dialog.
            if (model.GetArchetypeCount() == 0)
                view.ShowSetupDialog();
        }

        /// <summary> Record a victory using the currently selected build and archetype ID. </summary>
        private void RecordVictory()
        {
            if (view.SelectedBuildID == null)
                messenger.Message("Unable to record match", "No build is currently selected.");
            else if (view.SelectedArchetypeID == null)
                messenger.Message("Unable to record match", "No archetype is currently selected.");
            else if (messenger.Prompt("Confirmation", "Are you sure you want to record this victory?"))
                model.RecordMatch((int)view.SelectedBuildID, (int)view.SelectedArchetypeID, true);
        }

        /// <summary> Record a defeat using the currently selected build and archetype. </summary>
        private void RecordDefeat()
        {
            if (view.SelectedBuildID == null)
                messenger.Message("Unable to record match", "No build is currently selected.");
            else if (view.SelectedArchetypeID == null)
                messenger.Message("Unable to record match", "No archetype is currently selected.");
            else if (messenger.Prompt("Confirmation", "Are you sure you want to record this defeat?"))
                model.RecordMatch((int)view.SelectedBuildID, (int)view.SelectedArchetypeID, false);
        }

        /// <summary>
        /// Update statistics display based on the currently selected build and archetype.
        /// </summary>
        private void UpdateStatistics()
        {
            // Retrieve IDs.
            int? buildID = view.SelectedBuildID;
            int? archetypeID = view.SelectedArchetypeID;
            // Set IDs to null if the relevant "all" box is checked. (Model interprets a null ID to mean "all")
            if (view.AllBuilds)
                buildID = null;
            if (view.AllArchetypes)
                archetypeID = null;
            // Get win and loss count from model.
            int wins = model.CountMatches(buildID, archetypeID, true);
            int losses = model.CountMatches(buildID, archetypeID, false);
            // Calculate win rate.
            double winRate = 0.00;
            try
            {
                winRate = Statistics.CalculateWinRate(wins, losses);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // If this error message is shown then something has gone horribly wrong most likely in the Model class or directly in the database.
                // The argument out of range exception should only be thrown by the statistics class when a negative number of wins or losses are given.
                // God knows what might cause this but on the off chance that it does occur, hopefully restarting the application will fix it...
                messenger.Message("Error", "An error has occurred while attempting to calculate the win rate.  Please restart the application.");
            }

            // Set view displays.
            view.WinRate = winRate.ToString("F2"); // The win rate is rounded to two decimal places.
            view.Wins = wins.ToString();
            view.Losses = losses.ToString();
        }

        /// <summary> Creates a new build. </summary>
        private void NewBuild()
        {
            if (model.GetArchetypeCount() == 0) // If there are no archetypes then the user cannot create a build.
                messenger.Message("Unable to create build", "You must have at least one archetype before creating a build.");
            else
                view.ShowNewBuildDialog();
        }

        /// <summary> Modifies the currently selected build. </summary>
        private void UpdateBuild()
        {
            if (view.SelectedBuildID == null) // If there is no build selected then the user cannot modify it.
                messenger.Message("Unable to update build", "No build is currently selected.");
            else
                view.ShowUpdateBuildDialog();
        }

        /// <summary> Deletes the currently selected build after confirming with the user. </summary>
        private void DeleteBuild()
        {
            if (view.SelectedBuildID == null) // If there is no build selected then the user cannot delete it.
                messenger.Message("Unable to delete build", "No build is currently selected.");
            else if (messenger.Prompt("Confirmation", "Deleting this build will also delete all associated match information.  Are you sure you want to continue?"))
                model.DeleteBuild((int)view.SelectedBuildID);
        }

        /// <summary> Creates a new archetype. </summary>
        private void NewArchetype()
        {
            view.ShowNewArchetypeDialog();
        }

        /// <summary> Modifies the currently selected archetype. </summary>
        private void UpdateArchetype()
        {
            if (view.SelectedArchetypeID == null) // If there is no archetype selected then the user cannot modify it.
                messenger.Message("Unable to update archetype", "No archetype is currently selected.");
            else
                view.ShowUpdateArchetypeDialog();
        }

        /// <summary> Deletes the currently selected archetype after confirming with the user. </summary>
        private void DeleteArchetype()
        {
            if (view.SelectedArchetypeID == null) // If there is no archetype selected then the user cannot delete it.
                messenger.Message("Unable to delete archetype", "No archetype is currently selected.");
            else if (messenger.Prompt("Confirmation", "Deleting this archetype will also delete all associated build and match information.  Are you sure you want to continue?"))
                model.DeleteArchetype((int)view.SelectedArchetypeID);
        }
    }
}
