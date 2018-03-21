using FreshMvvm;
using XamForms1.Services;

namespace XamForms1.PageModels
{
    public abstract class BlockableBaseModel : FreshBasePageModel
    {
        protected readonly IBlocker Blocker;
        public bool IsBusy { get; set; }

        protected BlockableBaseModel(IBlocker blocker)
        {
            Blocker = blocker;
        }
        
        
        /// <summary>
        /// Called on isbusy changed
        /// </summary>
        public void OnIsBusyChanged()
        {
            if(this.IsBusy)
                this.Blocker.Block();
            else
            {
                this.Blocker.Unblock();
            }
        }
        
    }
}