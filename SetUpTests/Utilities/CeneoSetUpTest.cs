namespace SetUpTests.Utilities
{
    using CeneoFramework.Pages;

    using ErrorMessages.ErrorMessages;

    using NUnit.Framework;

    using SetUpFramework.Screenshot;
    using SetUpFramework.Selenium;

    public class CeneoSetUpTest
    {
        [SetUp]
        public void SetUp()
        {
            SetUpDriver.Initialize();
            HomePage.GoTo();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot.CaptureScreenshot(TestContext.CurrentContext.Test.MethodName);
            ErrorMessages.VerifyAndClearMessages();
            SetUpDriver.Close();
        }
    }
}