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

        /// <summary>
        /// Tests the record defeat event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_RecordDefeat()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the update statistics event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateStatistics()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the new build event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_NewBuild()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the update build event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateBuild()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the delete build event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteBuild()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the new archetype event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_NewArchetype()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the update archetype event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_UpdateArchetype()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }

        /// <summary>
        /// Tests the delete archetype event method.
        /// </summary>
        [TestMethod]
        public void HomePresenter_DeleteArchetype()
        {
            HomeMock view = new HomeMock();
            HomePresenter presenter = new HomePresenter(view, messenger, model);
        }
    }
}
