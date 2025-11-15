namespace SETUNA.Main.Common
{
    /// <summary>
    /// Application-wide constants
    /// </summary>
    public static class Constants
    {
        // Windows Build Numbers
        public const int Windows10AnniversaryUpdate = 14393;

        // Pre-defined Style IDs
        public const int PreStyleCloseId = -1;
        public const int PreStyleAllHideId = -2;
        public const int PreStyleAllShowId = -3;
        public const int PreStyleHideId = -4;
        public const int PreStyleShowId = -5;
        public const int PreStyleDeleteId = -10;

        // Opacity Animation
        public const double OpacityAnimationStep = 0.1;
        public const double OpacityMinimumDifference = 0.1;

        // Minimum Capture Size
        public const int MinimumCaptureWidth = 10;
        public const int MinimumCaptureHeight = 10;

        // Cursor capture positioning
        public const int CursorCaptureOffset = -10;

        // Window positioning flags
        public const uint WindowPosNoMove = 0x0002;
        public const uint WindowPosNoSize = 0x0001;
        public const uint WindowPosShowWindow = 0x0040;
        public const uint WindowPosNoActivate = 0x0010;
        public const uint WindowPosNoZOrder = 0x0004;
    }
}
