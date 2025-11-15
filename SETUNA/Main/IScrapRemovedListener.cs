namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap removed events
    /// </summary>
    public interface IScrapRemovedListener
    {
        /// <summary>
        /// Called when a scrap is removed
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapRemoved(object sender, ScrapEventArgs e);
    }
}
