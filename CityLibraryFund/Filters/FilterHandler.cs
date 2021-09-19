using CityLibraryFund.Events;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.Filters
{
    public abstract class FilterHandler<T>
    {
        public abstract string Name { get; }

        protected FilterState FilterState { get; }

        protected abstract void UpdateState(T changedState);

        public FilterHandler(FilterState filterState)
        {
            FilterState = filterState;
        }

        public abstract Task LoadData();

        protected ListView ListView;

        public void SetListView(ListView listView)
        {
            ListView = listView;
        }

        public async void HandleFilterChanged(object _, FilterStateChangedEventArgs<T> eventArgs)
        {
            UpdateState(eventArgs.State);
            if (eventArgs.FilterName == Name)
            {
                await LoadData();
            }
        }
    }
}
