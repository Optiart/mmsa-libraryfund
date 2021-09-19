using CityLibraryFund.Common;
using CityLibraryFund.Filters;
using System;

namespace CityLibraryFund.Events
{
    using static FilterControlConstants;

    public class FilterStateChangedEventArgs<T> : EventArgs
    {
        public string FilterName { get; set; }

        public T State { get; set; }

        public FilterStateChangedEventArgs(string filterName, T state)
        {
            FilterName = filterName;
            State = state;
        }
    }

    public class LibraryStateChangedEventArgs : FilterStateChangedEventArgs<LibraryFilterState>
    {
        public LibraryStateChangedEventArgs(LibraryFilterState state) : base(LibraryFilter, state)
        {
        }
    }

    public class FundStateChangedEventArgs : FilterStateChangedEventArgs<FundFilterState>
    {
        public FundStateChangedEventArgs(FundFilterState state) : base(FundFilter, state)
        {
        }
    }
}
