using Data;
using Data.Dto;
using Domain.Builders;
using Domain.Builders.Users;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public class LibraryManager
    {
        private readonly ILibraryRepository _libraryRepository;

        private readonly LibraryBuilder _libraryBuilder;
        private readonly LibrarianUserBuilder _librarianUserBuilder;

        public LibraryManager(
            ILibraryRepository libraryRepository,
            LibraryBuilder libraryBuilder,
            LibrarianUserBuilder librarianUserBuilder)
        {
            _libraryRepository = libraryRepository;
            _libraryBuilder = libraryBuilder;
            _librarianUserBuilder = librarianUserBuilder;
        }

        public async Task<ICollection<Domain.Models.Library>> GetAll(CancellationToken cancellationToken)
        {
            var libraryDtos = await _libraryRepository.GetWithRoomsAndLibrarians(cancellationToken);
            //var librarianDtos = _librarianRepository.GetAll(cancellationToken);

            //await Task.WhenAll(libraryDtos, librarianDtos);

            //var librarianPerId = (await librarianDtos).ToDictionary(
            //    l => l.User.Id,
            //    l =>
            //    {
            //        _librarianUserBuilder
            //           .WithLibrarianInfo("librarian", l.StartDate, l.EndDate)
            //           .WithBasicInfo(l.UserId, l.User.FirstName, l.User.LastName, l.User.BirthDate)
            //           .WithLocation(l.User.City, l.User.Address)
            //           .WithPhone(l.User.PhoneNumber, l.User.CountryCode);

            //        if (!string.IsNullOrEmpty(l.User.MiddleName))
            //        {
            //            _librarianUserBuilder.WithMiddleName(l.User.MiddleName);
            //        }

            //        return _librarianUserBuilder.Build();
            //    });

            return (libraryDtos).Select(dto =>
            {
                var storageRooms = dto.StorageRooms.Select(dtoRoom =>
                    new Models.StorageRoom(dtoRoom.Id, dtoRoom.Name, dtoRoom.Floor));

                var readingRooms = dto.ReadingRooms.Select(dtoRoom =>
                {
                    var librarians = dtoRoom.Librarians.Select(l =>
                    {
                        _librarianUserBuilder
                            .WithLibrarianInfo("librarian", l.StartDate, l.EndDate)
                            .WithBasicInfo(l.UserId, l.User.FirstName, l.User.LastName, l.User.BirthDate)
                            .WithLocation(l.User.City, l.User.Address)
                            .WithPhone(l.User.PhoneNumber, l.User.CountryCode);

                        if (!string.IsNullOrEmpty(l.User.MiddleName))
                        {
                            _librarianUserBuilder.WithMiddleName(l.User.MiddleName);
                        }

                        return _librarianUserBuilder.Build();
                    });
                    return new Models.ReadingRoom(dtoRoom.Id, dtoRoom.Name, librarians);
            });

            return _libraryBuilder
                .WithBasicInfo(dto.Id, dto.Name, dto.City, dto.Address)
                .WithStorageRooms(storageRooms)
                .WithReadingRooms(readingRooms)
                .Build();
        }).ToList();
    }
}
}
