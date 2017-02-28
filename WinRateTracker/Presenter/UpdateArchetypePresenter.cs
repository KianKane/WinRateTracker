﻿using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the update archetype view.
    /// </summary>
    public class UpdateArchetypePresenter
    {
        private IUpdateArchetypeView view;
        private IMessenger messenger;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The IUpdateArchetypeView instance controlled by this presenter. </param>
        /// <param name="messenger"> The messenger that this presenter uses.  If this is left blank then the presenter will use Messenger.Instance. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public UpdateArchetypePresenter(IUpdateArchetypeView view, IMessenger messenger = null, IModel model = null)
        {
            this.view = view;
            if (model == null)
                model = Model.Model.Instance;
            this.model = model;
            if (messenger == null)
                messenger = Messenger.Instance;
            this.messenger = messenger;
            view.Confirm += Confirm;
            view.Cancel += Cancel;
            // Set up the view with the name and note of the archetype to be modified.
            view.ArchetypeName = model.GetArchetypeName(view.ArchetypeID);
            view.ArchetypeNote = model.GetArchetypeNote(view.ArchetypeID);
        }

        /// <summary>  Validate view input and update the selected archetype in the model if the input is valid. </summary>
        private void Confirm()
        {
            string archetypeName = view.ArchetypeName.Trim();
            string archetypeNote = view.ArchetypeNote.Trim();
            if (string.IsNullOrWhiteSpace(archetypeName))
            {
                messenger.Message("Invalid Name", "You must enter a name for the archetype.");
            }
            else
            {
                model.UpdateArchetype(view.ArchetypeID, archetypeName, archetypeNote);
                view.CloseDialog();
            }
        }

        /// <summary> Close the dialog without updating the archetype. </summary>
        private void Cancel()
        {
            view.CloseDialog();
        }
    }
}
