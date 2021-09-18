using System;

namespace CityLibraryFund.Events
{
    public class FilterChangedEventArgs : EventArgs
    {
        public string CurrentCity { get; }

        public string CurrentLibrary { get; }

        public FilterChangedEventArgs(string currentCity, string currentLibrary)
        {
            CurrentCity = currentCity;
            CurrentLibrary = currentLibrary;
        }
    }
}
