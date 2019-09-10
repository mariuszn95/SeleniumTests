using NUnit.Framework;
using OlxFramework.Pages;
using SetUpFramework.Selenium;
using static ErrorMessages.ErrorMessages.ErrorMessages;
using static SetUpFramework.Screenshot.Screenshot;

namespace SetUpTests.Utilities
{
    public class OlxSetUpTest
    {
        [SetUp]
        public void Init()
        {
            SetUpDriver.Initialize();
            HomePage.GoTo();
        }

        [TearDown]
        public void Cleanup()
        {
            CaptureScreenshot(TestContext.CurrentContext.Test.MethodName);
            VerifyAndClearMessages();
            SetUpDriver.Close();
        }
    }
}