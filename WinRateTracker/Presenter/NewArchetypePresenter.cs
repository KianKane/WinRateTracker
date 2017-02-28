﻿using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker.Presenter
{
    /// <summary>
    /// This presenter class is responsible for the logic behind the new archetype view.
    /// </summary>
    public class NewArchetypePresenter
    {
        private INewArchetypeView view;
        private IMessenger messenger;
        private IModel model;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view"> The INewArchetypeView instance controlled by this presenter. </param>
        /// <param name="messenger"> The messenger that this presenter uses.  If this is left blank then the presenter will use Messenger.Instance. </param>
        /// <param name="model"> The model that this presenter uses.  If this is left blank then the presenter will use Model.Model.Instance. </param>
        public NewArchetypePresenter(INewArchetypeView view, IMessenger messenger = null, IModel model = null)
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
        }

        /// <summary> Validate view input and insert a new archetype into the model if the input is valid. </summary>
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
                model.InsertArchetype(archetypeName, archetypeNote);
                view.CloseDialog();
            }
        }

        /// <summary> Close the dialog without creating a new archetype. </summary>
        private void Cancel()
        {
            view.CloseDialog();
        }
    }
}
