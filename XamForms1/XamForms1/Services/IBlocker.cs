namespace XamForms1.Services
{
    public interface IBlocker
    {
        /// <summary>
        /// Add Block
        /// </summary>
        void Block();
		
        /// <summary>
        /// Remove Block
        /// </summary>
        void Unblock();
    }
}