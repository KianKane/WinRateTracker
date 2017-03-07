using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Presenter;
using WinRateTrackerTests.TestDoubles;

namespace WinRateTrackerTests.UnitTests
{
    /// <summary>
    /// This class is responsible for unit testing the setup dialog presenter.
    /// </summary>
    [TestClass]
    public class SetupPresenterTests
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

        /// <summary>
        /// Tests the constructor.
        /// Ensures that the presenter is properly created.
        /// Ensures that the presenter initializes the views game options to contain the correct values. 
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Constructor()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            Assert.IsNotNull(presenter);
            Assert.IsTrue(view.GameOptions.Length == 4);
            Assert.AreEqual("Hearthstone", view.GameOptions?[0]);
            Assert.AreEqual("Duelyst", view.GameOptions?[1]);
            Assert.AreEqual("Gwent", view.GameOptions?[2]);
            Assert.AreEqual("Shadowverse", view.GameOptions?[3]);
        }

        #region SetupPresenter_Confirm
        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter generates the correct archetypes when the selected game is Hearthstone (SelectedGame == 0).
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_Hearthstone()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 0;
            view.Confirm_Invoke();
            Assert.AreEqual(9, model.archetypes.Count);
            Assert.AreEqual("Mage", model.archetypes?[0].name);
            Assert.AreEqual("Jaina Proudmoore", model.archetypes?[0].note);
            Assert.AreEqual("Hunter", model.archetypes?[1].name);
            Assert.AreEqual("Rexxar", model.archetypes?[1].note);
            Assert.AreEqual("Paladin", model.archetypes?[2].name);
            Assert.AreEqual("Uther Lightbringer", model.archetypes?[2].note);
            Assert.AreEqual("Warrior", model.archetypes?[3].name);
            Assert.AreEqual("Garrosh Hellscream", model.archetypes?[3].note);
            Assert.AreEqual("Druid", model.archetypes?[4].name);
            Assert.AreEqual("Malfurion Stormrage", model.archetypes?[4].note);
            Assert.AreEqual("Warlock", model.archetypes?[5].name);
            Assert.AreEqual("Gul'dan", model.archetypes?[5].note);
            Assert.AreEqual("Shaman", model.archetypes?[6].name);
            Assert.AreEqual("Thrall", model.archetypes?[6].note);
            Assert.AreEqual("Priest", model.archetypes?[7].name);
            Assert.AreEqual("Anduin Wrynn", model.archetypes?[7].note);
            Assert.AreEqual("Rogue", model.archetypes?[8].name);
            Assert.AreEqual("Valeera Sanguinar", model.archetypes?[8].note);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter generates the correct archetypes when the selected game is Duelyst (SelectedGame == 1).
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_Duelyst()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 1;
            view.Confirm_Invoke();
            Assert.AreEqual(6, model.archetypes.Count);
            Assert.AreEqual("Lyonar", model.archetypes?[0].name);
            Assert.AreEqual("Songhai", model.archetypes?[1].name);
            Assert.AreEqual("Vetruvian", model.archetypes?[2].name);
            Assert.AreEqual("Abyssian", model.archetypes?[3].name);
            Assert.AreEqual("Magmar", model.archetypes?[4].name);
            Assert.AreEqual("Vanar", model.archetypes?[5].name);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter generates the correct archetypes when the selected game is Gwent (SelectedGame == 2).
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_Gwent()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 2;
            view.Confirm_Invoke();
            Assert.AreEqual(5, model.archetypes.Count);
            Assert.AreEqual("Nilfgaard", model.archetypes?[0].name);
            Assert.AreEqual("Monsters", model.archetypes?[1].name);
            Assert.AreEqual("Skellige", model.archetypes?[2].name);
            Assert.AreEqual("Northern Realms", model.archetypes?[3].name);
            Assert.AreEqual("Scoia'tael", model.archetypes?[4].name);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter generates the correct archetypes when the selected game is Shadowverse (SelectedGame == 3).
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_Shadowverse()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 3;
            view.Confirm_Invoke();
            Assert.AreEqual(7, model.archetypes.Count);
            Assert.AreEqual("Forestcraft", model.archetypes?[0].name);
            Assert.AreEqual("Arisa", model.archetypes?[0].note);
            Assert.AreEqual("Swordcraft", model.archetypes?[1].name);
            Assert.AreEqual("Erika", model.archetypes?[1].note);
            Assert.AreEqual("Runecraft", model.archetypes?[2].name);
            Assert.AreEqual("Isabelle", model.archetypes?[2].note);
            Assert.AreEqual("Dragoncraft", model.archetypes?[3].name);
            Assert.AreEqual("Rowan", model.archetypes?[3].note);
            Assert.AreEqual("Shadowcraft", model.archetypes?[4].name);
            Assert.AreEqual("Luna", model.archetypes?[4].note);
            Assert.AreEqual("Bloodcraft", model.archetypes?[5].name);
            Assert.AreEqual("Urias", model.archetypes?[5].note);
            Assert.AreEqual("Havencraft", model.archetypes?[6].name);
            Assert.AreEqual("Eris", model.archetypes?[6].note);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter fails gracefully when the selected game is invalid (SelectedGame == -1).
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_InvalidBelow()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = -1;
            view.Confirm_Invoke();
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter fails gracefully when the selected game is invalid (SelectedGame == 4).
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_InvalidAbove()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 4;
            view.Confirm_Invoke();
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter fails gracefully when the selected game is invalid (SelectedGame == int.MinValue).
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_InvalidMin()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = int.MinValue;
            view.Confirm_Invoke();
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(view.Closed);
        }

        /// <summary>
        /// Tests the Confirm event method.
        /// Ensures that the presenter fails gracefully when the selected game is invalid (SelectedGame == int.MaxValue).
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Confirm_InvalidMax()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = int.MaxValue;
            view.Confirm_Invoke();
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(view.Closed);
        }
        #endregion

        /// <summary>
        /// Tests the Cancel event method.
        /// Ensures that no archetypes are added.
        /// Ensures that the dialog is closed.
        /// </summary>
        [TestMethod]
        public void SetupPresenter_Cancel()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            Assert.IsTrue(!view.Closed);
            view.Cancel_Invoke();
            Assert.AreEqual(0, model.archetypes.Count);
            Assert.IsTrue(view.Closed);
        }
    }
}
