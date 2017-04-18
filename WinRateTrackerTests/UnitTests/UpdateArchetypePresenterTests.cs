using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Presenter;
using WinRateTrackerTests.TestDoubles;

namespace WinRateTrackerTests.UnitTests
{
    /// <summary>
    /// This class is responsible for unit testing the update archetype presenter.
    /// </summary>
    [TestClass]
    public class UpdateArchetypePresenterTests
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

        #region UpdateArchetypePresenter_Constructor
        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created.
        /// Ensures that the ArchetypeName is properly set up.
        /// Ensures the the ArchetypeNote is properly set up.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Constructor_Valid()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = model.archetypes[model.archetypes.Count - 1].id;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
            Assert.AreEqual("Sample Archetype", view.ArchetypeName);
            Assert.AreEqual("Sample Note", view.ArchetypeNote);
        }

        /// <summary>
        /// Tests the constructor.
        /// Ensures that that when an invalid archetype ID is given a message is shown.
        /// Ensures that the dialog is closed
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Constructor_InvalidArchetypeID()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = 420;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Archetype", "The chosen archetype does not exist.", false), messenger.Messages.Peek());
            Assert.IsTrue(view.Closed);
        }
        #endregion
        #region UpdateArchetypePresenter_Confirm
        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given typical valid values the archetype is properly modified in the model.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Confirm_Valid()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = model.archetypes[model.archetypes.Count - 1].id;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "Modified Archetype";
            view.ArchetypeNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual("Modified Archetype", model.archetypes[model.archetypes.Count - 1].name);
            Assert.AreEqual("Modified Note", model.archetypes[model.archetypes.Count - 1].note);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an archetype with no name a message is shown.
        /// Ensures that no archetypes are modified.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Confirm_NoName()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = model.archetypes[model.archetypes.Count - 1].id;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "";
            view.ArchetypeNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "You must enter a name for the archetype.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Archetype", model.archetypes[model.archetypes.Count - 1].name);
            Assert.AreEqual("Sample Note", model.archetypes[model.archetypes.Count - 1].note);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an archetype with a 51 character name a message is shown.
        /// Ensures that no archetypes are modified.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Confirm_LongName()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = model.archetypes[model.archetypes.Count - 1].id;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "nxyqdvldtueoaxqqleeuevdvwbfuwoeqbnwxodvapexfddnltza";
            view.ArchetypeNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "The archetype name cannot contain more than 50 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Archetype", model.archetypes[model.archetypes.Count - 1].name);
            Assert.AreEqual("Sample Note", model.archetypes[model.archetypes.Count - 1].note);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an archetype with a 201 character note a message is shown.
        /// Ensures that no archetypes are modified.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Confirm_LongNote()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = model.archetypes[model.archetypes.Count - 1].id;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "Modified Name";
            view.ArchetypeNote = "plbgdlqbuieulhgmblzdenupjmztiikupyhwauempmvkquuidcdesescmjfcgxoodqnzottonduxsgfavojwvqzrzbknfudssixrhnvclonsigdudulpoivwdydjtsmvolhwwjxoyxjupgkrkwiiczhdwvvijunfogykypkgodercudvcdnkwvlmgludlsoluuqfrvagv";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Note", "The archetype note cannot contain more than 200 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Archetype", model.archetypes[model.archetypes.Count - 1].name);
            Assert.AreEqual("Sample Note", model.archetypes[model.archetypes.Count - 1].note);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an invalid archetype ID a message is shown.
        /// Ensures that no archetypes are modified.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Confirm_InvalidArchetypeID()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = 420;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "Modified Name";
            view.ArchetypeNote = "Modified Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Archetype", "The chosen archetype does not exist.", false), messenger.Messages.Peek());
            Assert.AreEqual("Sample Archetype", model.archetypes[model.archetypes.Count - 1].name);
            Assert.AreEqual("Sample Note", model.archetypes[model.archetypes.Count - 1].note);
            Assert.IsTrue(view.Closed);
        }
        #endregion
        #region UpdateArchetypePresenter_Cancel
        /// <summary>
        /// Tests the Cancel event method.
        /// Ensures that no archetypes are modified.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void UpdateArchetypePresenter_Cancel()
        {
            UpdateArchetypeViewMock view = new UpdateArchetypeViewMock();
            view.ArchetypeID = model.archetypes[model.archetypes.Count - 1].id;
            UpdateArchetypePresenter presenter = new UpdateArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "Modified Name";
            view.ArchetypeNote = "Modified Note";
            view.Cancel_Invoke();
            Assert.AreEqual("Sample Archetype", model.archetypes[model.archetypes.Count - 1].name);
            Assert.AreEqual("Sample Note", model.archetypes[model.archetypes.Count - 1].note);
            Assert.IsTrue(view.Closed);
        }
        #endregion
    }
}