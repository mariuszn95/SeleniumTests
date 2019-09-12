namespace TestContexts.TestContexts
{
    using System.Configuration;

    using NUnit.Framework;

    public class TestContexts
    {
        private static string artifacts = "C:\\Artifacts";

        private static string baseAddress = ConfigurationManager.AppSettings["BaseAddress"];

        public TestContexts()
        {
            this.SetArtifactsPath();
            this.SetBaseAddress();
        }

        public static string GetArtifactsPath()
        {
            return artifacts;
        }

        public static string GetBaseAddress()
        {
            return baseAddress;
        }

        private void SetArtifactsPath()
        {
            var param = TestContext.Parameters.Get("ArtifactsPath");
            if (param != null)
            {
                artifacts = param;
            }
        }

        private void SetBaseAddress()
        {
            var param = TestContext.Parameters.Get("BaseAddress");
            if (param != null)
            {
                baseAddress = param;
            }
        }
    }
}