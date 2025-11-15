namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap location changed events
    /// </summary>
    public interface IScrapLocationChangedListener
    {
        /// <summary>
        /// Called when a scrap's location changes
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapLocationChanged(object sender, ScrapEventArgs e);
    }
}
