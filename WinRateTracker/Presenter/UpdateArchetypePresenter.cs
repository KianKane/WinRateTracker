using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the update archetype view.
    /// </summary>
    public class UpdateArchetypePresenter
    {
        private IUpdateArchetypeView view;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The IUpdateArchetypeView instance controlled by this presenter. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public UpdateArchetypePresenter(IUpdateArchetypeView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.UpdateArchetype += InsertArchetype;
            // Set up the view with the name and note of the archetype to be modified.
            view.ArchetypeName = model.GetArchetypeName(view.ArchetypeID);
            view.ArchetypeNote = model.GetArchetypeNote(view.ArchetypeID);
        }

        /// <summary>  Validate view input and update the selected archetype in the model if the input is valid. </summary>
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
