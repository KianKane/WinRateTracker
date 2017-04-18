using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Presenter;
using WinRateTrackerTests.TestDoubles;

namespace WinRateTrackerTests.UnitTests
{
    /// <summary>
    /// This class is responsible for unit testing the home presenter.
    /// </summary>
    [TestClass]
    public class HomePresenterTests
    {
        // Test doubles
        MessengerMock messenger;
        ModelMock model;

        /// <summary> Runs before each test. </summary>
        [TestInitialize]
        public void Initialize()
        {
            messenger = new MessengerMock();
            model = new ModelMock();
        }

        /// <summary> Runs after each test. </summary>
        [TestCleanup]
        public void Cleanup()
        {
            messenger = null;
            model = null;
        }

        #region HomePresenter_Constructor
        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created.
        /// Ensures that the setup dialog is shown when no archetypes exist within the model.
        /// </summary>
        [TestMethod]
        public void HomePresenter_Constructor_NoExistingArchetypes()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
            Assert.IsTrue(view.SetupDialogShown);
        }

        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created
        /// Ensures that the setup dialog is not shown when archetypes do exist within the model.
        /// </summary>
        [TestMethod]
        public void HomePresenter_Constructor_ExistingArchetypes()
        {
            model.InsertArchetype("Sample Archetype 1", "Sample Note");
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
            Assert.IsFalse(view.SetupDialogShown);
        }
        #endregion
        #region HomePresenter_RecordVictory
        /// <summary>
        /// Tests the record victory event method.
        /// Ensures that the user is prompted for confirmation.
        /// Ensures that a match is added.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordVictory_Typical()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            int countBefore = model.matches.Count;
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = 1;
            view.RecordVictory_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Confirmation", "Are you sure you want to record this victory?", true), messenger.Messages.Peek());
            Assert.AreEqual(countBefore + 1, model.matches.Count);
        }

        /// <summary>
        /// Tests the record victory event method.
        /// Ensures that the user is told that the action was a falure.
        /// Ensures that no new match is added.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordVictory_NoBuild()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            int countBefore = model.matches.Count;
            view.SelectedBuildID = null;
            view.SelectedArchetypeID = 1;
            view.RecordVictory_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to record match", "No build is currently selected.", false), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.matches.Count);
        }

        /// <summary>
        /// Tests the record victory event method.
        /// Ensures that the user is told that the action was a falure.
        /// Ensures that no new match is added.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordVictory_NoArchetype()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            int countBefore = model.matches.Count;
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = null;
            view.RecordVictory_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to record match", "No archetype is currently selected.", false), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.matches.Count);
        }
        #endregion
        #region HomePresenter_RecordDefeat
        /// <summary>
        /// Tests the record defeat event method.
        /// Ensures that the user is prompted for confirmation.
        /// Ensures that a match is added.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordDefeat_Typical()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            int countBefore = model.matches.Count;
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = 1;
            view.RecordDefeat_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Confirmation", "Are you sure you want to record this defeat?", true), messenger.Messages.Peek());
            Assert.AreEqual(countBefore + 1, model.matches.Count);
        }

        /// <summary>
        /// Tests the record defeat event method.
        /// Ensures that the user is told that the action was a falure.
        /// Ensures that no new match is added.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordDefeat_NoBuild()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            int countBefore = model.matches.Count;
            view.SelectedBuildID = null;
            view.SelectedArchetypeID = 1;
            view.RecordDefeat_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to record match", "No build is currently selected.", false), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.matches.Count);
        }

        /// <summary>
        /// Tests the record defeat event method.
        /// Ensures that the user is told that the action was a falure.
        /// Ensures that no new match is added.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordDefeat_NoArchetype()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            int countBefore = model.matches.Count;
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = null;
            view.RecordDefeat_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to record match", "No archetype is currently selected.", false), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.matches.Count);
        }
        #endregion
        #region HomePresenter_UpdateStatistics
        /// <summary>
        /// Tests the update statistics event method.
        /// Ensures that the win rate is correctly calculated.
        /// Ensures that only relevant matches are counted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateStatistics_Typical()
        {
            for (int i = 0; i < 75; i++) { model.RecordMatch(1, 1, true); } // Record 75 victories.
            for (int i = 0; i < 25; i++) { model.RecordMatch(1, 1, false); } // Record 25 defeats.
            for (int i = 0; i < 50; i++) { model.RecordMatch(1, 2, true); } // Record 50 irrelevant victories. (against a different archetype.  Ensures that only relevant matches are counted.)
            for (int i = 0; i < 30; i++) { model.RecordMatch(2, 1, false); } // Record 30 irrelevant defeats. (using a different build.  Ensures that only relevant matches are counted.)
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = 1;
            view.UpdateStatistics_Invoke();
            Assert.AreEqual("3.00", view.WinRate);
            Assert.AreEqual("75", view.Wins);
            Assert.AreEqual("25", view.Losses);
        }

        /// <summary>
        /// Tests the update statistics event method.
        /// Ensures that the win rate is correctly calculated.
        /// Ensures that only relevant matches are counted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateStatistics_AllBuilds()
        {
            for (int i = 0; i < 75; i++) { model.RecordMatch(1, 1, true); } // Record 75 victories.
            for (int i = 0; i < 25; i++) { model.RecordMatch(1, 1, false); } // Record 25 defeats.
            for (int i = 0; i < 50; i++) { model.RecordMatch(1, 2, true); } // Record 50 irrelevant victories. (against a different archetype.  Ensures that only relevant matches are counted.)
            for (int i = 0; i < 30; i++) { model.RecordMatch(2, 1, false); } // Record 30 defeats with an alternative build.
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            view.AllBuilds = true;
            view.SelectedArchetypeID = 1;
            view.UpdateStatistics_Invoke();
            Assert.AreEqual("1.36", view.WinRate);
            Assert.AreEqual("75", view.Wins);
            Assert.AreEqual("55", view.Losses);
        }

        /// <summary>
        /// Tests the update statistics event method.
        /// Ensures that the win rate is correctly calculated.
        /// Ensures that only relevant matches are counted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateStatistics_AllArchetypes()
        {
            for (int i = 0; i < 75; i++) { model.RecordMatch(1, 1, true); } // Record 75 victories.
            for (int i = 0; i < 25; i++) { model.RecordMatch(1, 1, false); } // Record 25 defeats.
            for (int i = 0; i < 50; i++) { model.RecordMatch(1, 2, true); } // Record 50 victories against an alternative archetype.
            for (int i = 0; i < 30; i++) { model.RecordMatch(2, 1, false); } // Record 30 irrelevant defeats. (using a different build.  Ensures that only relevant matches are counted.)
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = 1;
            view.AllArchetypes = true;
            view.UpdateStatistics_Invoke();
            Assert.AreEqual("5.00", view.WinRate);
            Assert.AreEqual("125", view.Wins);
            Assert.AreEqual("25", view.Losses);
        }

        /// <summary>
        /// Tests the update statistics event method.
        /// Ensures that the win rate is correctly calculated.
        /// Ensures that all matches are counted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateStatistics_AllMatches()
        {
            for (int i = 0; i < 75; i++) { model.RecordMatch(1, 1, true); } // Record 75 victories.
            for (int i = 0; i < 25; i++) { model.RecordMatch(1, 1, false); } // Record 25 defeats.
            for (int i = 0; i < 50; i++) { model.RecordMatch(1, 2, true); } // Record 50 victories against an alternative archetype.
            for (int i = 0; i < 30; i++) { model.RecordMatch(2, 1, false); } // Record 30 defeats using an alternative build.
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            view.AllBuilds = true;
            view.SelectedArchetypeID = 1;
            view.AllArchetypes = true;
            view.UpdateStatistics_Invoke();
            Assert.AreEqual("2.27", view.WinRate);
            Assert.AreEqual("125", view.Wins);
            Assert.AreEqual("55", view.Losses);
        }

        /// <summary>
        /// Tests the update statistics event method.
        /// Ensures that the win rate is correctly calculated.
        /// Ensures that the presenter works correctly when there are no losses. (Presenter should act as if there is one loss when there is zero to avoid division by zero.)
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateStatistics_DivideByZero()
        {
            for (int i = 0; i < 8; i++) { model.RecordMatch(1, 1, true); } // Record 8 victories.
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            view.SelectedArchetypeID = 1;
            view.UpdateStatistics_Invoke();
            Assert.AreEqual("8.00", view.WinRate);
            Assert.AreEqual("8", view.Wins);
            Assert.AreEqual("0", view.Losses);
        }
        #endregion
        #region HomePresenter_NewBuild
        /// <summary>
        /// Tests the new build event method.
        /// Ensures no messages are shown.
        /// Ensures that the new build dialog is shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_NewBuild_ArchetypesExist()
        {
            model.InsertArchetype("Sample Archetype 1", "Sample Note");
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.NewBuild_Invoke();
            Assert.AreEqual(0, messenger.Messages.Count); // Ensure no messages were shown
            Assert.IsTrue(view.NewBuildDialogShown);
        }

        /// <summary>
        /// Tests the new build event method.
        /// Ensures that a warning is shown.
        /// Ensures that the new build dialog is not shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_NewBuild_NoArchetypesExist()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.NewBuild_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to create build", "You must have at least one archetype before creating a build.", false), messenger.Messages.Peek());
            Assert.IsFalse(view.NewBuildDialogShown);
        }
        #endregion
        #region HomePresenter_UpdateBuild
        /// <summary>
        /// Tests the update build event method.
        /// Ensures that no messages are shown.
        /// Ensures that the modify build dialog is shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateBuild_BuildSelected()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            view.UpdateBuild_Invoke();
            Assert.AreEqual(0, messenger.Messages.Count); // Ensure no messages were shown
            Assert.IsTrue(view.UpdateBuildDialogShown);
        }

        /// <summary>
        /// Tests the update build event method.
        /// Ensures that a warning is shown.
        /// Ensures that the modify build dialog is not shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateBuild_NoBuildSelected()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = null;
            view.UpdateBuild_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to update build", "No build is currently selected.", false), messenger.Messages.Peek());
            Assert.IsFalse(view.UpdateBuildDialogShown);
        }
        #endregion
        #region HomePresenter_DeleteBuild
        /// <summary>
        /// Tests the delete build event method.
        /// Ensures that the user is prompted for confirmation.
        /// Ensures that the build is deleted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteBuild_BuildSelected()
        {
            model.InsertBuild("Sample Build 1", "Sample Note", 1);
            int countBefore = model.builds.Count;
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            messenger.Accept = true; // Accept the prompt
            view.DeleteBuild_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Confirmation", "Deleting this build will also delete all associated match information.  Are you sure you want to continue?", true), messenger.Messages.Peek());
            Assert.AreEqual(countBefore - 1, model.builds.Count);
        }

        /// <summary>
        /// Tests the delete build event method.
        /// Ensures that the user is prompted for confirmation.
        /// Ensures that the build is not deleted when the user refuses the prompt.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteBuild_UserDeclines()
        {
            model.InsertBuild("Sample Build 1", "Sample Note", 1);
            int countBefore = model.builds.Count;
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = 1;
            messenger.Accept = false; // Refuse the prompt
            view.DeleteBuild_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Confirmation", "Deleting this build will also delete all associated match information.  Are you sure you want to continue?", true), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.builds.Count);
        }

        /// <summary>
        /// Tests the delete build event method.
        /// Ensures that a warning is shown.
        /// Ensures that no builds are deleted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteBuild_NoBuildSelected()
        {
            model.InsertBuild("Sample Build 1", "Sample Note", 1);
            int countBefore = model.builds.Count;
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedBuildID = null;
            view.DeleteBuild_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to delete build", "No build is currently selected.", false), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.builds.Count);
        }
        #endregion
        #region HomePresenter_NewArchetype
        /// <summary>
        /// Tests the new archetype event method.
        /// Ensures that no messages are shown.
        /// Ensures that the new archetype dialog is shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_NewArchetype()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.NewArchetype_Invoke();
            Assert.AreEqual(0, messenger.Messages.Count); // Ensure no messages were shown
            Assert.IsTrue(view.NewArchetypeDialogShown);
        }
        #endregion
        #region HomePresenter_UpdateArchetype
        /// <summary>
        /// Tests the update archetype event method.
        /// Ensures that no messages are shown.
        /// Ensures that the modify archetyoe dialog is shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateArchetype_ArchetypeSelected()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedArchetypeID = 1;
            view.UpdateArchetype_Invoke();
            Assert.AreEqual(0, messenger.Messages.Count); // Ensure no messages were shown
            Assert.IsTrue(view.UpdateArchetypeDialogShown);
        }

        /// <summary>
        /// Tests the update archetype event method.
        /// Ensures that a warning is shown.
        /// Ensures that the modify archetype dialog is not shown.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateArchetype_NoArchetypeSelected()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedArchetypeID = null;
            view.UpdateArchetype_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to update archetype", "No archetype is currently selected.", false), messenger.Messages.Peek());
            Assert.IsFalse(view.UpdateArchetypeDialogShown);
        }
        #endregion
        #region HomePresenter_DeleteArchetype
        /// <summary>
        /// Tests the delete archetype event method.
        /// Ensures that the user is prompted for confirmation.
        /// Ensures that the archetype is deleted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteArchetype_ArchetypeSelected()
        {
            model.InsertArchetype("Sample Archetype 1", "Sample Note");
            int countBefore = model.archetypes.Count;
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedArchetypeID = 1;
            messenger.Accept = true; // Accept the prompt
            view.DeleteArchetype_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Confirmation", "Deleting this archetype will also delete all associated build and match information.  Are you sure you want to continue?", true), messenger.Messages.Peek());
            Assert.AreEqual(countBefore - 1, model.archetypes.Count);
        }

        /// <summary>
        /// Tests the delete archetype event method.
        /// Ensures that the user is prompted for confirmation.
        /// Ensures that the archetype is not deleted when the user refuses the prompt.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteArchetype_UserDeclines()
        {
            model.InsertArchetype("Sample Archetype 1", "Sample Note");
            int countBefore = model.archetypes.Count;
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedArchetypeID = 1;
            messenger.Accept = false; // Refuse the prompt
            view.DeleteArchetype_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Confirmation", "Deleting this archetype will also delete all associated build and match information.  Are you sure you want to continue?", true), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.archetypes.Count);
        }

        /// <summary>
        /// Tests the delete archetype event method.
        /// Ensures that a warning is shown.
        /// Ensures that no archetype are deleted.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteArchetype_NoArchetypeSelected()
        {
            model.InsertArchetype("Sample Archetype 1", "Sample Note");
            int countBefore = model.archetypes.Count;
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
            view.SelectedArchetypeID = null;
            view.DeleteArchetype_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Unable to delete archetype", "No archetype is currently selected.", false), messenger.Messages.Peek());
            Assert.AreEqual(countBefore, model.archetypes.Count);
        }
        #endregion
    }
}