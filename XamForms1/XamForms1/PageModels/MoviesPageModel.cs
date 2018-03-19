using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamForms1.Models;
using XamForms1.Services;

namespace XamForms1.PageModels
{
    public class MoviesPageModel : BlockableBaseModel
    {
        private readonly IMovieService _movieService;

        public MoviesPageModel(IBlocker blocker , IMovieService movieService) : base(blocker)
        {
            _movieService = movieService;
            
            this.SearchMovies = new Command(async () => { await this.InnerSearchMovies(); }, () => !this.IsBusy);
        }


        public ICommand SearchMovies { get; private set; }

        public string SearchText { get; set; }
        public List<Movie> Movies { get; set; }
        
        
        private async Task InnerSearchMovies()
        {
            this.IsBusy = true;
            this.Movies = (await this._movieService.GetMoviesForSearchAsync(this.SearchText)).ToList();
            this.IsBusy = false;
        }
        

    }
}