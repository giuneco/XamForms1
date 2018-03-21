using System.Collections.Generic;
using System.Threading.Tasks;
using XamForms1.Models;

namespace XamForms1.Services
{
    public interface IMovieService
    {
        Task<IReadOnlyList<Movie>> GetMoviesForSearchAsync(string search, int pageNo = 1);
    }
}