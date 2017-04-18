using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Presenter;
using WinRateTrackerTests.TestDoubles;

namespace WinRateTrackerTests.UnitTests
{
    /// <summary>
    /// This class is responsible for unit testing the update archetype presenter.
    /// </summary>
    [TestClass]
    public class UpdateBuildPresenterTests
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
            model.InsertArchetype("Sample Archetype", "Sample Note");
            model.InsertBuild("Sample Build", "Sample Note", model.archetypes[model.archetypes.Count - 1].id);
        }

        /// <summary> Runs after each test. </summary>
        [TestCleanup]
        public void Cleanup()
        {
            messenger = null;
            model = null;
        }

        #region UpdateBuildPresenter_Constructor
        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created.
        /// Ensures that the BuildName is properly set up.
        /// Ensures the the BuildNote is properly set up.
        /// Ensures that the ArchetypeName is properly set up
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Constructor_Valid()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = model.builds[model.builds.Count - 1].id;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
            Assert.AreEqual("Sample Build", view.BuildName);
            Assert.AreEqual("Sample Note", view.BuildNote);
            Assert.AreEqual("Sample Archetype", view.ArchetypeName);
        }

        /// <summary>
        /// Tests the constructor.
        /// Ensures that that when an invalid build ID is given a message is shown.
        /// Ensures that the dialog is closed
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Constructor_InvalidBuildID()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = 420;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model); 
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Build", "The chosen build does not exist.", false), messenger.Messages.Peek());
            Assert.IsTrue(view.Closed);
        }
        #endregion
        #region UpdateBuildPresenter_Confirm
        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given typical valid values the build is properly modified in the model.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Confirm_Valid()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = model.builds[model.builds.Count - 1].id;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            view.BuildName = "Modified Name";
            view.BuildNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual("Modified Name", model.builds[model.builds.Count - 1].name);
            Assert.AreEqual("Modified Note", model.builds[model.builds.Count - 1].note);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an build with no name a message is shown.
        /// Ensures that no builds are modified.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Confirm_NoName()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = model.builds[model.builds.Count - 1].id;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            view.BuildName = "";
            view.BuildNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "You must enter a name for the build.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Build", model.builds[model.builds.Count - 1].name);
            Assert.AreEqual("Sample Note", model.builds[model.builds.Count - 1].note);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given a build with a 51 character name a message is shown.
        /// Ensures that no builds are modified.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Confirm_LongName()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = model.builds[model.builds.Count - 1].id;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            view.BuildName = "nxyqdvldtueoaxqqleeuevdvwbfuwoeqbnwxodvapexfddnltza";
            view.BuildNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "The build name cannot contain more than 50 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Build", model.builds[model.builds.Count - 1].name);
            Assert.AreEqual("Sample Note", model.builds[model.builds.Count - 1].note);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given aa build with a 201 character note a message is shown.
        /// Ensures that no builds are modified.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Confirm_LongNote()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = model.builds[model.builds.Count - 1].id;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            view.BuildName = "Modified Name";
            view.BuildNote = "plbgdlqbuieulhgmblzdenupjmztiikupyhwauempmvkquuidcdesescmjfcgxoodqnzottonduxsgfavojwvqzrzbknfudssixrhnvclonsigdudulpoivwdydjtsmvolhwwjxoyxjupgkrkwiiczhdwvvijunfogykypkgodercudvcdnkwvlmgludlsoluuqfrvagv";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Note", "The build note cannot contain more than 200 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Build", model.builds[model.builds.Count - 1].name);
            Assert.AreEqual("Sample Note", model.builds[model.builds.Count - 1].note);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an invalid build ID a message is shown.
        /// Ensures that no builds are modified.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Confirm_InvalidArchetypeID()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = 420;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            view.BuildName = "Modified Name";
            view.BuildNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Build", "The chosen build does not exist.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Build", model.builds[model.builds.Count - 1].name);
            Assert.AreEqual("Sample Note", model.builds[model.builds.Count - 1].note);
            Assert.IsTrue(view.Closed);
        }
        #endregion
        #region UpdateBuildPresenter_Cancel
        /// <summary>
        /// Tests the Cancel event method.
        /// Ensures that no archetypes are modified.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void UpdateBuildPresenter_Cancel()
        {
            UpdateBuildViewMock view = new UpdateBuildViewMock();
            view.BuildID = model.builds[model.builds.Count - 1].id;
            UpdateBuildPresenter presenter = new UpdateBuildPresenter(view, messenger, model);
            view.BuildName = "Modified Name";
            view.BuildNote = "Modified Note";
            view.Cancel_Invoke();
            Assert.AreEqual("Sample Build", model.builds[model.builds.Count - 1].name);
            Assert.AreEqual("Sample Note", model.builds[model.builds.Count - 1].note);
            Assert.IsTrue(view.Closed);
        }
        #endregion
    }
}