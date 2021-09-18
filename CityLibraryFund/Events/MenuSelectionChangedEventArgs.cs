using System;

namespace CityLibraryFund.Events
{
    public class MenuSelectionChangedEventArgs : EventArgs
    {
        public string ChangedFrom { get; set; }
        public string ChangedTo { get; set; }
    }
}
