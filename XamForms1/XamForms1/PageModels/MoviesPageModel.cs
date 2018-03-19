using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamForms1.PageModels
{
    public class MoviesPageModel : FreshBasePageModel
    {
        public MoviesPageModel()
        {
            this.OnIncrement = new Command(() => { this.Test++; });
        }

        public ICommand OnIncrement { get; private set; }

        public int Test { get; set; }
    }
}