namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap style-related events
    /// </summary>
    public interface IScrapStyleListener
    {
        /// <summary>
        /// Called when a scrap is created
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapCreated(object sender, ScrapEventArgs e);

        /// <summary>
        /// Called when a scrap becomes inactive
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapInactived(object sender, ScrapEventArgs e);

        /// <summary>
        /// Called when a scrap is activated
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapActivated(object sender, ScrapEventArgs e);

        /// <summary>
        /// Called when the mouse moves over an inactive scrap
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapInactiveMouseOver(object sender, ScrapEventArgs e);

        /// <summary>
        /// Called when the mouse moves out of an inactive scrap
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing the scrap</param>
        void ScrapInactiveMouseOut(object sender, ScrapEventArgs e);
    }
}
