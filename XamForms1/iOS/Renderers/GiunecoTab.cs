using CoreLocation;
using FreshMvvm;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamForms1.iOS.Renderers;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(GiunecoTab))]

namespace XamForms1.iOS.Renderers
{
    public class GiunecoTab : TabbedRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var tab = (FreshTabbedNavigationContainer)base.Element;
            tab.BarBackgroundColor = Color.FromHex("a32828");
            tab.BarTextColor = Color.White;


        }
    }
    
    
}