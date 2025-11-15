namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap style applied events
    /// </summary>
    public interface IScrapStyleAppliedListener
    {
        /// <summary>
        /// Called when a style is applied to a scrap
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapStyleApplied(object sender, ScrapEventArgs e);
    }
}
