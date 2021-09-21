using CityLibraryFund.Common;
using CityLibraryFund.Filters;
using System;

namespace CityLibraryFund.Events
{
    using static MenuConstants;

    public class FilterStateChangedEventArgs<T> : EventArgs
    {
        public string MenuName { get; set; }

        public T State { get; set; }

        public FilterStateChangedEventArgs(string menuName, T state)
        {
            MenuName = menuName;
            State = state;
        }
    }

    public class LibraryStateChangedEventArgs : FilterStateChangedEventArgs<LibraryFilterState>
    {
        public LibraryStateChangedEventArgs(LibraryFilterState state) : base(LibraryMenu, state)
        {
        }
    }

    public class FundStateChangedEventArgs : FilterStateChangedEventArgs<FundFilterState>
    {
        public FundStateChangedEventArgs(FundFilterState state) : base(FundMenu, state)
        {
        }
    }
}
