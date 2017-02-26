using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    class UpdateArchetypePresenter
    {
        private IUpdateArchetypeView view;
        private IModel model;

        public UpdateArchetypePresenter(IUpdateArchetypeView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.UpdateArchetype += InsertArchetype;
            view.ArchetypeName = model.GetArchetypeName(view.ArchetypeID);
            view.ArchetypeNote = model.GetArchetypeNote(view.ArchetypeID);
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
                model.UpdateArchetype(view.ArchetypeID, archetypeName, archetypeNote);
                view.CloseDialog();
            }
        }
    }
}
