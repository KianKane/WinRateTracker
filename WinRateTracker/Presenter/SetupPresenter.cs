using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    class SetupPresenter
    {
        private ISetupDialogView view;
        private IModel model;
        private string[] gameOptions;

        public SetupPresenter(ISetupDialogView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            gameOptions = new string[] { "Hearthstone", "Duelyst", "Gwent", "Shadowverse" };
            view.GameOptions = gameOptions;
            view.SetupArchetypes += SetupArchetypes;
        }

        private void SetupArchetypes()
        {
            switch (view.SelectedGame)
            {
                case 0:
                    model.InsertArchetype("Mage", "Jaina Proudmoore");
                    model.InsertArchetype("Hunter", "Rexxar");
                    model.InsertArchetype("Paladin", "Uther Lightbringer");
                    model.InsertArchetype("Warrior", "Garrosh Hellscream");
                    model.InsertArchetype("Druid", "Malfurion Stormrage");
                    model.InsertArchetype("Warlock", "Gul'dan");
                    model.InsertArchetype("Shaman", "Thrall");
                    model.InsertArchetype("Priest", "Anduin Wrynn");
                    model.InsertArchetype("Rogue", "Valeera Sanguinar");
                    break;

                case 1:
                    model.InsertArchetype("Lyonar", "");
                    model.InsertArchetype("Songhai", "");
                    model.InsertArchetype("Vetruvian", "");
                    model.InsertArchetype("Abyssian", "");
                    model.InsertArchetype("Magmar", "");
                    model.InsertArchetype("Vanar", "");
                    break;

                case 2:
                    model.InsertArchetype("Nilfgaard", "");
                    model.InsertArchetype("Monsters", "");
                    model.InsertArchetype("Skellige", "");
                    model.InsertArchetype("Northern Realms", "");
                    model.InsertArchetype("Scoia'tael", "");
                    break;

                case 3:
                    model.InsertArchetype("Forestcraft", "Arisa");
                    model.InsertArchetype("Swordcraft", "Erika");
                    model.InsertArchetype("Runecraft", "Isabelle");
                    model.InsertArchetype("Dragoncraft", "Rowan");
                    model.InsertArchetype("Shadowcraft", "Luna");
                    model.InsertArchetype("Bloodcraft", "Urias");
                    model.InsertArchetype("Havencraft", "Eris");
                    break;
            }
            view.CloseDialog();
        }
    }
}
