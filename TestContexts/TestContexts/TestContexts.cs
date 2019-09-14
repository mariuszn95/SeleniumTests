namespace TestContexts.TestContexts
{
    using System.Configuration;
    using System.Reflection;

    using Logger.Logger;

    using NUnit.Framework;

    public class TestContexts
    {
        private static string artifacts = "C:\\Artifacts";

        private static string baseAddress = ConfigurationManager.AppSettings["BaseAddress"];

        private static string websiteName = ConfigurationManager.AppSettings["WebsiteName"];

        public TestContexts()
        {
            this.SetArtifactsPath();
            this.SetBaseAddress();
            this.SetWebsiteName();
        }

        public static string GetArtifactsPath()
        {
            LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {artifacts}");

            return artifacts;
        }

        public static string GetBaseAddress()
        {
            LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {baseAddress}");

            return baseAddress;
        }

        public static string GetWebsiteName()
        {
            LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {websiteName}");

            return websiteName;
        }

        private void SetArtifactsPath()
        {
            LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

            var param = TestContext.Parameters.Get("ArtifactsPath");
            if (param != null)
            {
                LoggerTestContexts.LogStart("ArtifactsPath from CI: " + param);
                artifacts = param;
                LoggerTestContexts.LogEnd("ArtifactsPath from CI: " + artifacts);
            }

            LoggerTestContexts.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        private void SetBaseAddress()
        {
            LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

            var param = TestContext.Parameters.Get("BaseAddress");
            if (param != null)
            {
                LoggerTestContexts.LogStart("BaseAddress from CI: " + param);
                baseAddress = param;
                LoggerTestContexts.LogEnd("BaseAddress from CI: " + baseAddress);
            }

            LoggerTestContexts.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        private void SetWebsiteName()
        {
            LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

            var param = TestContext.Parameters.Get("WebsiteName");
            if (param != null)
            {
                LoggerTestContexts.LogStart("WebsiteName from CI: " + param);
                websiteName = param;
                LoggerTestContexts.LogEnd("WebsiteName from CI: " + websiteName);
            }

            LoggerTestContexts.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}