namespace ICE.VTC.TELEMETRY.Setup
{
    public static class SetupManager
    {
        public static ISetup[] Steps;

        static SetupManager()
        {
            Steps = new ISetup[]
            {
                new PluginSetup(), 
                new FirewallSetup(), 
                new UrlReservationSetup()
            };
        }
    }
}