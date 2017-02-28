using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the new archetype view.
    /// </summary>
    public class NewArchetypePresenter
    {
        private INewArchetypeView view;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The INewArchetypeView instance controlled by this presenter. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public NewArchetypePresenter(INewArchetypeView view, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            view.InsertArchetype += InsertArchetype;
        }

        /// <summary> Validate view input and insert a new archetype into the model if the input is valid. </summary>
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
