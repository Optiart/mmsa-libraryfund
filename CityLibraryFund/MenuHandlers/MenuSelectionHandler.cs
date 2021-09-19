using CityLibraryFund.Common;
using CityLibraryFund.Events;
using CityLibraryFund.Filters;
using System;

namespace CityLibraryFund.MenuHandlers
{
    using static MenuConstants;

    public class MenuSelectionHandler
    {
        private LibraryFilterUserControl _libraryFilterControl;
        private FundFilterUserControl _fundFilterControl;

        public MenuSelectionHandler(
            LibraryFilterUserControl libraryFilterControl,
            FundFilterUserControl fundFilterControl)
        {
            _libraryFilterControl = libraryFilterControl;
            _fundFilterControl = fundFilterControl;
        }

        public async void HandleMenuSelectionChanged(object _, MenuSelectionChangedEventArgs eventArgs)
        {
            if(eventArgs.ChangedFrom == eventArgs.ChangedTo)
            {
                return;
            }

            if (!string.IsNullOrEmpty(eventArgs.ChangedFrom))
            {
                var previousControl = GetFilterControl(eventArgs.ChangedFrom);
                previousControl.MakeInvisible();
            }

            var currentControl = GetFilterControl(eventArgs.ChangedTo);
            currentControl.MakeVisible();
            await currentControl.LoadFilters();
        }

        private IFilterUserControl GetFilterControl(string name)
        {
            return name switch
            {
                LibraryMenu => _libraryFilterControl,
                FundMenu => _fundFilterControl,
                _ => throw new NotSupportedException($"filter control for menu {name} is not supported")
            };
        }
    }
}
