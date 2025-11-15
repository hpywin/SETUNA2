namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap added events
    /// </summary>
    public interface IScrapAddedListener
    {
        /// <summary>
        /// Called when a scrap is added
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapAdded(object sender, ScrapEventArgs e);
    }
}
