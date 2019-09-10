using NUnit.Framework;
using System.Configuration;

namespace TestContexts.TestContexts
{
    public class TestContexts
    {
        private static string _artifacts = "C:\\Artifacts";
        private static string _baseAddress = ConfigurationManager.AppSettings["BaseAddress"];

        public TestContexts()
        {
            SetArtifactsPath();
            SetBaseAddress();
        }

        public static string GetArtifactsPath()
        {
            return _artifacts;
        }

        private void SetArtifactsPath()
        {
            var param = TestContext.Parameters.Get("ArtifactsPath");
            if (null != param) _artifacts = param;
        }

        public static string GetBaseAddress()
        {
            return _baseAddress;
        }

        private void SetBaseAddress()
        {
            var param = TestContext.Parameters.Get("BaseAddress");
            if (null != param) _baseAddress = param;
        }
    }
}