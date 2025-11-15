namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap image changed events
    /// </summary>
    public interface IScrapImageChangedListener
    {
        /// <summary>
        /// Called when a scrap's image changes
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapImageChanged(object sender, ScrapEventArgs e);
    }
}
