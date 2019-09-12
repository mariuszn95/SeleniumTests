namespace SetUpTests.Utilities
{
    using ErrorMessages.ErrorMessages;

    using NUnit.Framework;

    using OlxFramework.Pages;

    using SetUpFramework.Screenshot;
    using SetUpFramework.Selenium;

    public class OlxSetUpTest
    {
        [TearDown]
        public void Cleanup()
        {
            Screenshot.CaptureScreenshot(TestContext.CurrentContext.Test.MethodName);
            ErrorMessages.VerifyAndClearMessages();
            SetUpDriver.Close();
        }

        [SetUp]
        public void Init()
        {
            SetUpDriver.Initialize();
            HomePage.GoTo();
        }
    }
}