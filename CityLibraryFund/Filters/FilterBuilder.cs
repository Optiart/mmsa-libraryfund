using CityLibraryFund.Common;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibraryFund.Filters
{
    using static FilterControlConstants;

    public static class FilterStateExtensions
    {
        public static ICollection<Filter> ToLibraryFilters(this FilterState state)
        {
            var filters = new List<Filter>();
            if (state.LibraryFilterState != null && state.LibraryFilterState.CurrentCity != All)
            {
                filters.Add(new Filter
                {
                    Name = FilterConstants.ByCity,
                    Value = state.LibraryFilterState?.CurrentCity
                });
            }

            if (state.LibraryFilterState != null && state.LibraryFilterState.CurrentLibrary != All)
            {
                filters.Add(new Filter
                {
                    Name = FilterConstants.ByName,
                    Value = state.LibraryFilterState?.CurrentLibrary
                });
            }

            return filters;
        }

        public static ICollection<Filter> ToFundLibraryFilters(this FilterState state)
        {
            var filters = state.ToLibraryFilters();
            if (!string.IsNullOrEmpty(state.FundState?.Name))
            {
                filters.Add(new Filter
                {
                    Name = FilterConstants.ByFundName,
                    Value = state.FundState.Name
                });
            }

            if (state.FundState != null && state.FundState.IsInUse)
            {
                filters.Add(new Filter
                {
                    Name = FilterConstants.ByFundCurrentUsage,
                    Value = "1"
                });
            }

            return filters;
        }
    }
}
