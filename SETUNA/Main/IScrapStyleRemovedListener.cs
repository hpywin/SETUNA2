namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap style removed events
    /// </summary>
    public interface IScrapStyleRemovedListener
    {
        /// <summary>
        /// Called when a style is removed from a scrap
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapStyleRemoved(object sender, ScrapEventArgs e);
    }
}
