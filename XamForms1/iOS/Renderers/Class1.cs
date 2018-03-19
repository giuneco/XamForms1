using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamForms1.iOS.Renderers;

[assembly: ExportRenderer(typeof(SearchBar), typeof(ExtendedSearchBarRenderer))]

namespace XamForms1.iOS.Renderers
{

    public class ExtendedSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "Text")
            {
                Control.ShowsCancelButton = false;
            }
        }
    }
}