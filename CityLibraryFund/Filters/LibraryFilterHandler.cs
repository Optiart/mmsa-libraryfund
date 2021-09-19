using CityLibraryFund.Common;
using CityLibraryFund.Helpers;
using Domain;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.Filters
{
    using static FilterControlConstants;

    public class LibraryFilterHandler : FilterHandler<LibraryFilterState>
    {
        public override string Name => LibraryFilter;
        private readonly LibraryManager _libraryManager;

        public LibraryFilterHandler(FilterState filterState, LibraryManager libraryManager) : base(filterState)
        {
            _libraryManager = libraryManager;
        }

        public override async Task LoadData()
        {
            ListView.Clear();
            var filters = FilterState.ToLibraryFilters();

            var libraries = filters.Any()
                ? await _libraryManager.GetByFilter(filters, default)
                : await _libraryManager.GetAll(default);

            foreach (var library in libraries)
            {
                ListView.AddRow(library.Location.City, library.Name, library.Location.Address);
            }

            ListView.AddColumns("Місто", "Назва", "Адреса");
        }

        protected override void UpdateState(LibraryFilterState changedState) => FilterState.LibraryFilterState = changedState;
    }
}
