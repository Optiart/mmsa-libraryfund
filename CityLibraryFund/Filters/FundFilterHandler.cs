using CityLibraryFund.Common;
using CityLibraryFund.Helpers;
using CityLibraryFund.ViewModels;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.Filters
{
    using static FilterControlConstants;

    public class FundFilterHandler : FilterHandler<FundFilterState>
    {
        public override string Name => FundFilter;
        private readonly FundManager _fundManager;

        public FundFilterHandler(FilterState filterState, FundManager libraryManager) : base(filterState)
        {
            _fundManager = libraryManager;
        }

        public override async Task LoadData()
        {
            ListView.Clear();
            var filters = FilterState.ToFundLibraryFilters();

            var fundCollection = filters.Any()
                ? await _fundManager.GetFunds(filters, default)
                : await _fundManager.GetFunds(default);


            var viewModels = fundCollection.Books.Select(b => new FundViewModel(b)
            {
                Category = "Книга",
                UniqueNumber = b.Isbn
            }).Concat(fundCollection.Journals.Select(j => new FundViewModel(j)
            {
                Category = "Журнал",
                UniqueNumber = j.Issn
            })).Concat(fundCollection.Newspapers.Select(n => new FundViewModel(n)
            {
                Category = "Газета",
                UniqueNumber = n.Issn
            })).Concat(fundCollection.OtherFunds.Select(o => new FundViewModel(o)
            {
                Category = "Інше",
                UniqueNumber = o.UniqueNumber
            })).ToList();

            foreach (var viewModel in viewModels)
            {
                ListView.AddRow(viewModel.Category, viewModel.Name, viewModel.Authors, viewModel.UniqueNumber, viewModel.PublishDate, viewModel.CopyCount);
            }

            ListView.AddColumns("Категорія", "Назва", "Автори", "Унікальний номер", "Дата публікації", "Кількість примірників");
        }

        protected override void UpdateState(FundFilterState changedState) => FilterState.FundState = changedState;
    }
}
