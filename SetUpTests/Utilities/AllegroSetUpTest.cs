namespace SetUpTests.Utilities
{
    using AllegroFramework.Pages;

    using ErrorMessages.ErrorMessages;

    using NUnit.Framework;

    using SetUpFramework.Screenshot;
    using SetUpFramework.Selenium;

    public class AllegroSetUpTest
    {
        [SetUp]
        public void SetUp()
        {
            SetUpDriver.Initialize();
            HomePage.GoTo();
            HomePage.CloseRodo();
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