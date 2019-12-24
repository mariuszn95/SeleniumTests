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

        private static string browser = ConfigurationManager.AppSettings["Browser"];

        private static string websiteName = ConfigurationManager.AppSettings["WebsiteName"];

        public TestContexts()
        {
            ArtifactsPath = TestContext.Parameters.Get("ArtifactsPath");
            BaseAddress = TestContext.Parameters.Get("BaseAddress");
            Browser = TestContext.Parameters.Get("Browser");
            WebsiteName = TestContext.Parameters.Get("WebsiteName");
        }

        public static string ArtifactsPath
        {
            get
            {
                LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {artifacts}");

                return artifacts;
            }

            private set
            {
                LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

                var param = value;
                if (param != null)
                {
                    LoggerTestContexts.LogStart("ArtifactsPath from CI: " + param);
                    artifacts = param;
                    LoggerTestContexts.LogEnd("ArtifactsPath from CI: " + artifacts);
                }

                LoggerTestContexts.LogEnd(MethodBase.GetCurrentMethod().Name);
            }
        }

        public static string BaseAddress
        {
            get
            {
                LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {baseAddress}");

                return baseAddress;
            }

            private set
            {
                LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

                var param = value;
                if (param != null)
                {
                    LoggerTestContexts.LogStart("BaseAddress from CI: " + param);
                    baseAddress = param;
                    LoggerTestContexts.LogEnd("BaseAddress from CI: " + baseAddress);
                }

                LoggerTestContexts.LogEnd(MethodBase.GetCurrentMethod().Name);
            }
        }

        public static string Browser
        {
            get
            {
                LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {browser}");

                return browser;
            }

            private set
            {
                LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

                var param = value;
                if (param != null)
                {
                    LoggerTestContexts.LogStart("Browser from CI: " + param);
                    browser = param;
                    LoggerTestContexts.LogEnd("Browser from CI: " + browser);
                }

                LoggerTestContexts.LogEnd(MethodBase.GetCurrentMethod().Name);
            }
        }

        public static string WebsiteName
        {
            get
            {
                LoggerTestContexts.LogReturn($"{MethodBase.GetCurrentMethod().Name} ----- {websiteName}");

                return websiteName;
            }

            private set
            {
                LoggerTestContexts.LogStart(MethodBase.GetCurrentMethod().Name);

                var param = value;
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
}