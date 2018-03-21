using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamForms1.PageModels
{
    public class AboutPageModel : FreshBasePageModel
    {

        public AboutPageModel()
        {
            this.GoToWebSite = new Command(() => { Device.OpenUri(new Uri("http://www.giuneco.it")); });
        }

        public ICommand GoToWebSite { get; private set; }
    }
}