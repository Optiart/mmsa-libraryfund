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
            Bind<LibraryFundDbContext>().ToSelf().InSingletonScope();
            Bind<ILibraryRepository>().To<LibraryRepository>().InSingletonScope();
            Bind<IRepository<Data.Dto.Librarian, uint>>().To<LibrarianRepository>().InSingletonScope();

            // Builders
            Bind<LibraryBuilder>().ToSelf().InSingletonScope();
            Bind<LibrarianUserBuilder>().ToSelf().InSingletonScope();

            // Managers
            Bind<LibraryManager>().ToSelf().InSingletonScope();
        }
    }
}
