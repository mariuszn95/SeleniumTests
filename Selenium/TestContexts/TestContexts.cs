using NUnit.Framework;

namespace Selenium.TestContexts
{
    public class TestContexts
    {
        private static string _baseAddress;

        public TestContexts()
        {
            SetBaseAddress();
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