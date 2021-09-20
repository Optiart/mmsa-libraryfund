using CityLibraryFund.Common;
using System;

namespace CityLibraryFund.Events
{
    public class EntityUpdatedEventArgs : EventArgs
    {
        public string FilterName { get; set; }

        public EntityUpdatedEventArgs(string filterName)
        {
            FilterName = filterName;
        }
    }

    public class LibraryEntityUpdatedEventArgs : EntityUpdatedEventArgs
    {
        public LibraryEntityUpdatedEventArgs(string filterName) : base(filterName)
        {
        }
    }

    public class FundEntityUpdatedEventArgs : EntityUpdatedEventArgs
    {
        public FundEntityUpdatedEventArgs(string filterName) : base(filterName)
        {
        }
    }
}
