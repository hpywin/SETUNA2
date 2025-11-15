namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap key press events
    /// </summary>
    public interface IScrapKeyPressEventListener
    {
        /// <summary>
        /// Called when a key is pressed on a scrap
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing key press information</param>
        void ScrapKeyPress(object sender, ScrapKeyPressEventArgs e);
    }
}
