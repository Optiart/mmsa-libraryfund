using CityLibraryFund.Common;
using CityLibraryFund.Helpers;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.Filters
{
    using static MenuConstants;

    public class LibraryFilterHandler : FilterHandler<LibraryFilterState>
    {
        public override string MenuName => LibraryMenu;
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
                ListView.AddRow(library.Id.ToString(), library.Location.City, library.Name, library.Location.Address);
            }

            ListView.AddColumns("Id","Місто", "Назва", "Адреса");
        }

        protected override void UpdateState(LibraryFilterState changedState) => FilterState.LibraryFilterState = changedState;
    }
}
