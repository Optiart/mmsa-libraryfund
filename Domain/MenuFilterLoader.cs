using Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public class MenuFilterLoader
    {
        private readonly ILibraryRepository _repository;

        public MenuFilterLoader(ILibraryRepository repository)
        {
            _repository = repository;
        }

        public async Task<(ICollection<string> cities, ICollection<string> libraries)> GetAll(CancellationToken cancellationToken)
        {
            var libraries = await _repository.GetAll(cancellationToken);
            return (libraries.Select(l => l.City).Distinct().ToList(), libraries.Select(l => l.Name).Distinct().ToList());
        }

        public async Task<ICollection<string>> GetLibraries(string city, CancellationToken cancellationToken)
        {
            var libraries = await _repository.GetByFilter(l => l.City == city, cancellationToken);
            return libraries.Select(l => l.Name).Distinct().ToList();
        }
    }
}
