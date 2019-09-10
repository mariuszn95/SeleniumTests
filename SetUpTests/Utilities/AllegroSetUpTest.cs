using NUnit.Framework;
using AllegroFramework.Pages;
using SetUpFramework.Selenium;
using static ErrorMessages.ErrorMessages.ErrorMessages;
using static SetUpFramework.Screenshot.Screenshot;

namespace SetUpTests.Utilities
{
    public class AllegroSetUpTest
    {
        [SetUp]
        public void Init()
        {
            SetUpDriver.Initialize();
            HomePage.GoTo();
            HomePage.CloseRodo();
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