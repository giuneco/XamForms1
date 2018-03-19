using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms1.PageModels;
using XamForms1.Services;
using XamForms1.Services.Impl;

[assembly : XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamForms1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            FreshIOC.Container.Register<IMovieService, MovieService>();

            
            var tabbedNavigation = new FreshTabbedNavigationContainer ();
            tabbedNavigation.AddTab<MoviesPageModel> ("Movies", "movie");
            tabbedNavigation.AddTab<AboutPageModel> ("About", "about");
            
            MainPage = tabbedNavigation;
            
            //MainPage = new XamForms1Page();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
