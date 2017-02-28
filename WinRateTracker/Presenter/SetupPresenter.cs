using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the archetype initialization dialog view.
    /// </summary>
    public class SetupPresenter
    {
        private ISetupDialogView view;
        private IModel model;
        private string[] gameOptions;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The ISetupDialogView instance controlled by this presenter. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public SetupPresenter(ISetupDialogView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.Confirm += Confirm;
            view.Cancel += Cancel;
            // Set up available game options.
            gameOptions = new string[] { "Hearthstone", "Duelyst", "Gwent", "Shadowverse" };
            view.GameOptions = gameOptions;
        }

        /// <summary> Set up archetypes based on the selected game index. </summary>
        private void Confirm()
        {
            switch (view.SelectedGame)
            {
                case 0: // Hearthstone.
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

                case 1: // Duelyst.
                    model.InsertArchetype("Lyonar", "");
                    model.InsertArchetype("Songhai", "");
                    model.InsertArchetype("Vetruvian", "");
                    model.InsertArchetype("Abyssian", "");
                    model.InsertArchetype("Magmar", "");
                    model.InsertArchetype("Vanar", "");
                    break;

                case 2: // Gwent.
                    model.InsertArchetype("Nilfgaard", "");
                    model.InsertArchetype("Monsters", "");
                    model.InsertArchetype("Skellige", "");
                    model.InsertArchetype("Northern Realms", "");
                    model.InsertArchetype("Scoia'tael", "");
                    break;

                case 3: // Shadowverse.
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

        /// <summary> Close the dialog without initializing any archetypes. </summary>
        private void Cancel()
        {
            view.CloseDialog();
        }
    }
}
