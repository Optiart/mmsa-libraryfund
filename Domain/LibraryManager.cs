using Data;
using Domain.Builders;
using Domain.Builders.Users;
using Domain.Models;
using System;
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

        public async Task<ICollection<Domain.Models.Library>> GetByFilter(ICollection<Filter> filters, CancellationToken cancellationToken)
        {
            var predicates = new List<Func<Data.Dto.Library, bool>>();

            foreach (var filter in filters)
            {
                Func<Data.Dto.Library, bool> predicate = filter.Name switch
                {
                    FilterConstants.ByName => l => l.Name == filter.Value,
                    FilterConstants.ByCity => l => l.City == filter.Value,

                    _ => throw new NotSupportedException($"filter {filter.Name} is not supported")
                };

                predicates.Add(predicate);
            }

            var libraryDtos = await _libraryRepository.GetWithRoomsAndLibrarians(predicates.ToArray(), cancellationToken);
            return ToDomainModels(libraryDtos);
        }

        public async Task<ICollection<Domain.Models.Library>> GetAll(CancellationToken cancellationToken)
        {
            var libraryDtos = await _libraryRepository.GetWithRoomsAndLibrarians(cancellationToken);
            return ToDomainModels(libraryDtos);
        }

        private ICollection<Domain.Models.Library> ToDomainModels(ICollection<Data.Dto.Library> dtos)
        {
            return dtos.Select(dto =>
            {
                var storageRooms = dto.StorageRooms.Select(dtoRoom =>
                    new Models.StorageRoom(dtoRoom.Id, dtoRoom.Name, dtoRoom.Floor));

                var readingRooms = dto.ReadingRooms.Select(dtoRoom =>
                {
                    var librarians = dtoRoom.Librarians.Select(l =>
                    {
                        _librarianUserBuilder
                            .New()
                            .WithLibrarianInfo("librarian", l.StartDate, l.EndDate)
                            .WithBasicInfo(l.UserId, l.User.FirstName, l.User.LastName, l.User.BirthDate)
                            .WithLocationCity(l.User.City)
                            .WithLocationAddress(l.User.Address)
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
                    .New()
                    .WithBasicInfo(dto.Id, dto.Name, dto.City, dto.Address)
                    .WithStorageRooms(storageRooms)
                    .WithReadingRooms(readingRooms)
                    .Build();
            }).ToList();
        }
    }
}
