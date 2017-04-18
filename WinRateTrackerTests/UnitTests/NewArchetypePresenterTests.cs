using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Presenter;
using WinRateTrackerTests.TestDoubles;

namespace WinRateTrackerTests.UnitTests
{
    /// <summary>
    /// This class is responsible for unit testing the new archetype presenter.
    /// </summary>
    [TestClass]
    public class NewArchetypePresenterTests
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

        #region NewArchetypePresenter_Constructor
        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created.
        /// </summary>
        [TestMethod]
        public void NewArchetypePresenter_Constructor()
        {
            NewArchetypeViewMock view = new NewArchetypeViewMock();
            NewArchetypePresenter presenter = new NewArchetypePresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
        }
        #endregion
        #region NewArchetypePresenter_Confirm
        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given typical valid values an archetype is generated in the model.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void NewArchetypePresenter_Confirm_Valid()
        {
            NewArchetypeViewMock view = new NewArchetypeViewMock();
            NewArchetypePresenter presenter = new NewArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "Sample Archetype";
            view.ArchetypeNote = "Sample Note";
            view.Confirm_Invoke();
            Assert.AreEqual(model.archetypes[model.archetypes.Count - 1].name, "Sample Archetype");
            Assert.AreEqual(model.archetypes[model.archetypes.Count - 1].note, "Sample Note");
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an archetype with no name a message is shown.
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewArchetypePresenter_Confirm_NoName()
        {
            NewArchetypeViewMock view = new NewArchetypeViewMock();
            NewArchetypePresenter presenter = new NewArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "";
            view.ArchetypeNote = "Sample Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "You must enter a name for the archetype.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an archetype with a 51 character name a message is shown.
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewArchetypePresenter_Confirm_LongName()
        {
            NewArchetypeViewMock view = new NewArchetypeViewMock();
            NewArchetypePresenter presenter = new NewArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "nxyqdvldtueoaxqqleeuevdvwbfuwoeqbnwxodvapexfddnltza";
            view.ArchetypeNote = "Sample Note";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Name", "The archetype name cannot contain more than 50 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(!view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the when given an archetype with a 201 character note a message is shown.
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is not closed.
        /// </summary>
        [TestMethod]
        public void NewArchetypePresenter_Confirm_LongNote()
        {
            NewArchetypeViewMock view = new NewArchetypeViewMock();
            NewArchetypePresenter presenter = new NewArchetypePresenter(view, messenger, model);
            view.ArchetypeName = "Sample Archetype";
            view.ArchetypeNote = "plbgdlqbuieulhgmblzdenupjmztiikupyhwauempmvkquuidcdesescmjfcgxoodqnzottonduxsgfavojwvqzrzbknfudssixrhnvclonsigdudulpoivwdydjtsmvolhwwjxoyxjupgkrkwiiczhdwvvijunfogykypkgodercudvcdnkwvlmgludlsoluuqfrvagv";
            view.Confirm_Invoke();
            Assert.AreEqual(new MessengerMock.MessageRecord("Invalid Note", "The archetype note cannot contain more than 200 characters.", false), messenger.Messages.Peek());
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(!view.Closed);
        }
        #endregion
        #region NewArchetypePresenter_Cancel
        /// <summary>
        /// Tests the Cancel event method.
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void NewArchetypePresenter_Cancel()
        {
            NewArchetypeViewMock view = new NewArchetypeViewMock();
            NewArchetypePresenter presenter = new NewArchetypePresenter(view, messenger, model);
            view.Cancel_Invoke();
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(view.Closed);
        }
        #endregion
    }
}