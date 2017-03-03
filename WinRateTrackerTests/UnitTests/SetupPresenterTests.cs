using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Model;
using WinRateTracker.Presenter;
using WinRateTracker.View;
using WinRateTrackerTests.Mocks;

namespace WinRateTrackerTests.UnitTests
{
    [TestClass]
    public class SetupPresenterTests
    {
        MessengerMock messenger;
        ModelMock model;

        [TestInitialize]
        public void Initialize()
        {
            messenger = new MessengerMock();
            model = new ModelMock();
        }

        [TestMethod]
        public void SetupPresenter_Constructor()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            
            Assert.IsNotNull(presenter);
            Assert.AreEqual(view.GameOptions?[0], "Hearthstone");
            Assert.AreEqual(view.GameOptions?[1], "Duelyst");
            Assert.AreEqual(view.GameOptions?[2], "Gwent");
            Assert.AreEqual(view.GameOptions?[3], "Shadowverse");
        }

        [TestMethod]
        public void SetupPresenter_Confirm_Hearthstone()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 0;
            view.Confirm_Invoke();

            Assert.AreEqual(model.archetypes?[0].name, "Mage");
            Assert.AreEqual(model.archetypes?[0].note, "Jaina Proudmoore");

            Assert.AreEqual(model.archetypes?[1].name, "Hunter");
            Assert.AreEqual(model.archetypes?[1].note, "Rexxar");

            Assert.AreEqual(model.archetypes?[2].name, "Paladin");
            Assert.AreEqual(model.archetypes?[2].note, "Uther Lightbringer");

            Assert.AreEqual(model.archetypes?[3].name, "Warrior");
            Assert.AreEqual(model.archetypes?[3].note, "Garrosh Hellscream");

            Assert.AreEqual(model.archetypes?[4].name, "Druid");
            Assert.AreEqual(model.archetypes?[4].note, "Malfurion Stormrage");

            Assert.AreEqual(model.archetypes?[5].name, "Warlock");
            Assert.AreEqual(model.archetypes?[5].note, "Gul'dan");

            Assert.AreEqual(model.archetypes?[6].name, "Shaman");
            Assert.AreEqual(model.archetypes?[6].note, "Thrall");

            Assert.AreEqual(model.archetypes?[7].name, "Priest");
            Assert.AreEqual(model.archetypes?[7].note, "Anduin Wrynn");

            Assert.AreEqual(model.archetypes?[8].name, "Rogue");
            Assert.AreEqual(model.archetypes?[8].note, "Valeera Sanguinar");
        }

        [TestMethod]
        public void SetupPresenter_Confirm_Duelyst()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 1;
            view.Confirm_Invoke();

            Assert.AreEqual(model.archetypes?[0].name, "Lyonar");
            Assert.AreEqual(model.archetypes?[1].name, "Songhai");
            Assert.AreEqual(model.archetypes?[2].name, "Vetruvian");
            Assert.AreEqual(model.archetypes?[3].name, "Abyssian");
            Assert.AreEqual(model.archetypes?[4].name, "Magmar");
            Assert.AreEqual(model.archetypes?[5].name, "Vanar");
        }

        [TestMethod]
        public void SetupPresenter_Confirm_Gwent()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 2;
            view.Confirm_Invoke();

            Assert.AreEqual(model.archetypes?[0].name, "Nilfgaard");
            Assert.AreEqual(model.archetypes?[1].name, "Monsters");
            Assert.AreEqual(model.archetypes?[2].name, "Skellige");
            Assert.AreEqual(model.archetypes?[3].name, "Northern Realms");
            Assert.AreEqual(model.archetypes?[4].name, "Scoia'tael");
        }

        [TestMethod]
        public void SetupPresenter_Confirm_Shadowverse()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            view.SelectedGame = 3;
            view.Confirm_Invoke();

            Assert.AreEqual(model.archetypes?[0].name, "Forestcraft");
            Assert.AreEqual(model.archetypes?[0].note, "Arisa");

            Assert.AreEqual(model.archetypes?[1].name, "Swordcraft");
            Assert.AreEqual(model.archetypes?[1].note, "Erika");

            Assert.AreEqual(model.archetypes?[2].name, "Runecraft");
            Assert.AreEqual(model.archetypes?[2].note, "Isabelle");

            Assert.AreEqual(model.archetypes?[3].name, "Dragoncraft");
            Assert.AreEqual(model.archetypes?[3].note, "Rowan");

            Assert.AreEqual(model.archetypes?[4].name, "Shadowcraft");
            Assert.AreEqual(model.archetypes?[4].note, "Luna");

            Assert.AreEqual(model.archetypes?[5].name, "Bloodcraft");
            Assert.AreEqual(model.archetypes?[5].note, "Urias");

            Assert.AreEqual(model.archetypes?[6].name, "Havencraft");
            Assert.AreEqual(model.archetypes?[6].note, "Eris");
        }

        [TestMethod]
        public void SetupPresenter_Cancel()
        {
            SetupDialogMock view = new SetupDialogMock();
            SetupPresenter presenter = new SetupPresenter(view, messenger, model);
            Assert.IsTrue(!view.Closed);
            view.Cancel_Invoke();
            Assert.IsTrue(view.Closed);
        }

        [TestCleanup]
        public void Cleanup()
        {
            messenger = null;
            model = null;
        }
    }
}
