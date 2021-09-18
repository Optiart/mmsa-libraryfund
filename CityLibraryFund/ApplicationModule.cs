using CityLibraryFund.Common;
using CityLibraryFund.Handlers;
using Data;
using Domain;
using Domain.Builders;
using Domain.Builders.Users;
using Ninject;
using Ninject.Modules;

namespace CityLibraryFund
{
    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            // Repository
            Bind<LibraryFundDbContext>().ToSelf().InSingletonScope();
            Bind<ILibraryRepository>().To<LibraryRepository>().InSingletonScope();
            Bind<IRepository<Data.Dto.Librarian, uint>>().To<LibrarianRepository>().InSingletonScope();

            // Builders
            Bind<LibraryBuilder>().ToSelf().InSingletonScope();
            Bind<LibrarianUserBuilder>().ToSelf().InSingletonScope();

            // Managers
            Bind<LibraryManager>().ToSelf().InSingletonScope();

            // Menu handlers
            Bind<LibraryMenuHandler>().ToSelf().InSingletonScope();
            Bind<FundMenuHandler>().ToSelf().InSingletonScope();
            Bind<MenuSelector>().ToMethod(context =>
            {
                var libraryMenuHandler = context.Kernel.Get<LibraryMenuHandler>();
                var fundMenuHandler = context.Kernel.Get<FundMenuHandler>();

                var menuSelector = new MenuSelector();
                menuSelector.MenuSelectionChanged += libraryMenuHandler.HandleMenuSelectionChanged;
                menuSelector.MenuSelectionChanged += fundMenuHandler.HandleMenuSelectionChanged;

                return menuSelector;
            }).InSingletonScope();
        }
    }
}
