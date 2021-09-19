using System.Threading.Tasks;

namespace CityLibraryFund.Filters
{
    public interface IFilterUserControl
    {
        Task LoadFilters();

        void MakeInvisible();

        void MakeVisible();
    }
}
