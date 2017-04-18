using System;
using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    /// <summary>
    /// This class acts as a mock for the NewArchetypeView form.
    /// </summary>
    class NewArchetypeViewMock : INewArchetypeView
    {
        public event Action Confirm;
        public event Action Cancel;

        /// <summary> Constructor. </summary>
        public NewArchetypeViewMock()
        {
            Closed = false;
            ArchetypeName = string.Empty;
            ArchetypeNote = string.Empty;
        }

        /// <summary> Auto-generated property used to indicate whether the mock form is closed or not. </summary>
        public bool Closed { get; private set; }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string ArchetypeName { get; set; } // Setter used for testing purposes, it is not requred by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string ArchetypeNote { get; set; } // Setter used for testing purposes, it is not requred by the interface and only exists in this mock.

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void CloseDialog()
        {
            Closed = true;
        }

        /// <summary> Used by testing classes to invoke the Confirm event. </summary>
        public void Confirm_Invoke()
        {
            Confirm?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the Cancel event. </summary>
        public void Cancel_Invoke()
        {
            Cancel?.Invoke();
        }
    }
}
