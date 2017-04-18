using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Presenter;
using WinRateTrackerTests.TestDoubles;

namespace WinRateTrackerTests.UnitTests
{
    /// <summary>
    /// This class is responsible for unit testing the new build presenter.
    /// </summary>
    [TestClass]
    public class NewBuildPresenterTests
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
        }

        /// <summary> Runs after each test. </summary>
        [TestCleanup]
        public void Cleanup()
        {
            messenger = null;
            model = null;
        }

        #region NewBuildPresenter_Constructor
        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Constructor()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
        }
        #endregion
        #region NewBuildPresenter_Confirm
        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given typical valid values a build is generated in the model.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Confirm_Valid()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            view.BuildName = "Sample Build";
            view.BuildNote = "Sample Note";
            view.ArchetypeID = model.archetypes[0].id;
            view.Confirm_Invoke();
            Assert.AreEqual(model.builds[model.builds.Count - 1].name, "Sample Build");
            Assert.AreEqual(model.builds[model.builds.Count - 1].note, "Sample Note");
            Assert.AreEqual(model.builds[model.builds.Count - 1].archetypeID, model.archetypes[0].id);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given a build with no name a message is shown.
        /// Ensures that no builds are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Confirm_NoName()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            view.BuildName = "";
            view.BuildNote = "Sample Note";
            view.ArchetypeID = model.archetypes[0].id;
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "You must enter a name for the build.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.builds.Count);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given a build with a 51 character name a message is shown.
        /// Ensures that no builds are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Confirm_LongName()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            view.BuildName = "nxyqdvldtueoaxqqleeuevdvwbfuwoeqbnwxodvapexfddnltza";
            view.BuildNote = "Sample Note";
            view.ArchetypeID = model.archetypes[0].id;
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "The build name cannot contain more than 50 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.builds.Count);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given a build with a 201 character note a message is shown.
        /// Ensures that no builds are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Confirm_LongNote()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            view.BuildName = "Sample Build";
            view.BuildNote = "plbgdlqbuieulhgmblzdenupjmztiikupyhwauempmvkquuidcdesescmjfcgxoodqnzottonduxsgfavojwvqzrzbknfudssixrhnvclonsigdudulpoivwdydjtsmvolhwwjxoyxjupgkrkwiiczhdwvvijunfogykypkgodercudvcdnkwvlmgludlsoluuqfrvagv";
            view.ArchetypeID = model.archetypes[0].id;
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Note", "The build note cannot contain more than 200 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.builds.Count);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given a build with an archetypeID that does not exist in the model a message is shown.
        /// Ensures that no builds are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Confirm_ArchetypeDoesntExist()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            view.BuildName = "Sample Build";
            view.BuildNote = "Sample Note";
            view.ArchetypeID = 420;
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Build Archetype", "The chosen archetype does not exist.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.builds.Count);
            Assert.IsTrue(!view.Closed);
        }
        #endregion
        #region NewBuildPresenter_Cancel
        /// <summary>
        /// Tests the Cancel event method.
        /// Ensures that no builds are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void NewBuildPresenter_Cancel()
        {
            NewBuildViewMock view = new NewBuildViewMock();
            NewBuildPresenter presenter = new NewBuildPresenter(view, messenger, model);
            view.Cancel_Invoke();
            Assert.AreEqual(0, model.builds.Count);
            Assert.IsTrue(view.Closed);
        }
        #endregion
    }
}