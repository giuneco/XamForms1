using BigTed;
using XamForms1.Services;

namespace XamForms1.iOS.Services
{
    public class IosBlocker : IBlocker
    {
        public void Block()
        {
            try
            {
                BTProgressHUD.Show("Please Wait..", -1, ProgressHUD.MaskType.Gradient);
            }
            catch (System.Exception ex)
            {

            }
        }

        public void Unblock()
        {
            BTProgressHUD.Dismiss();
        }
    }
}