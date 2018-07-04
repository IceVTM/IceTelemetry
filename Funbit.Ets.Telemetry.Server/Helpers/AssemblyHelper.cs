using System.Diagnostics;

namespace ICE.VTC.TELEMETRY.Helpers
{
    public static class AssemblyHelper
    {
        public static string Version
        {
            get
            {
                FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(
                    Process.GetCurrentProcess().MainModule.FileName);
                string version = $"{versionInfo.FileMajorPart}.{versionInfo.FileMinorPart}.{versionInfo.ProductBuildPart}";
                return version;
            }
        }
    }
}
