using CityLibraryFund.Filters;
using Data;
using Domain;
using Domain.Builders;
using Domain.Builders.Users;
using Ninject.Modules;

namespace CityLibraryFund
{
    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            // Repository
            Bind<LibraryFundDbContext>().ToSelf().InTransientScope();
            Bind<ILibraryRepository>().To<LibrarySqlRepository>().InTransientScope();
            Bind<IFundRepository>().To<FundSqlRepository>().InTransientScope();
            Bind<IRepository<Data.Dto.Librarian, uint>>().To<LibrarianRepository>().InTransientScope();

            // Builders
            Bind<LibraryBuilder>().ToSelf().InSingletonScope();
            Bind<LibrarianUserBuilder>().ToSelf().InSingletonScope();

            // Managers
            Bind<LibraryManager>().ToSelf().InTransientScope();

            // State
            Bind<FilterState>().ToSelf().InSingletonScope();
        }
    }
}
