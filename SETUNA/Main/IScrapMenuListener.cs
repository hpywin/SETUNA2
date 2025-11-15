namespace SETUNA.Main
{
    /// <summary>
    /// Interface for listening to scrap menu events
    /// </summary>
    public interface IScrapMenuListener
    {
        /// <summary>
        /// Called when a scrap menu is opening
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">Event arguments containing menu information</param>
        void ScrapMenuOpening(object sender, ScrapMenuArgs e);
    }
}
