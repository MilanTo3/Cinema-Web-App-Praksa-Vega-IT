namespace DomainLayer.Repositories;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

public interface IMovieRepository : IGenericRepository<Movie>
{
        Task<bool> AddId(Movie movie);
        Task<bool> UpdateMovie(MovieDto dto, List<Genre> newGen);

        Task<IEnumerable<Movie>> GetMoviesWithScreenings(DateTime? day, List<Genre>? genres, bool? sort);
        Task<DtoPaginated<Movie>> GetPaginated(int page, int itemCount, string[]? letters, string? searchTerm);
        Task<Movie> getByIdInclusive(long id);

}
