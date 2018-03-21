using AndroidHUD;
using Plugin.CurrentActivity;
using XamForms1.Services;

namespace XamForms1.Droid.Services
{
    public class DroidBlocker : IBlocker
    {
        public void Block()
        {
            AndHUD.Shared.Show(CrossCurrentActivity.Current.Activity , "Please Wait..", (int)MaskType.Clear);
        }

        public void Unblock()
        {
            AndHUD.Shared.Dismiss(CrossCurrentActivity.Current.Activity);
        }
    }
}