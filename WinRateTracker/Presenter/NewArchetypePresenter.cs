using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    class NewArchetypePresenter
    {
        private INewArchetypeView view;
        private IModel model;

        public NewArchetypePresenter(INewArchetypeView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.InsertArchetype += InsertArchetype;
        }

        private void InsertArchetype()
        {
            string archetypeName = view.ArchetypeName.Trim();
            string archetypeNote = view.ArchetypeNote.Trim();
            if (string.IsNullOrWhiteSpace(archetypeName))
            {
                view.Message("Invalid Name", "You must enter a name for the archetype.");
            }
            else
            {
                model.InsertArchetype(archetypeName, archetypeNote);
                view.CloseDialog();
            }
        }
    }
}
