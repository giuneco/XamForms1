using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
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

        private async Task InnerSearchMovies()
        {
            this.IsBusy = true;
            var movies = await this._movieService.GetMoviesForSearchAsync(this.SearchText);
            this.IsBusy = false;
        }

        public ICommand SearchMovies { get; private set; }

        public string SearchText { get; set; }
        

    }
}