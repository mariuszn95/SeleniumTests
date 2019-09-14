namespace SetUpTests.Utilities
{
    using AllegroFramework.Pages;

    using NUnit.Framework;

    using SetUpFramework.Screenshot;
    using SetUpFramework.TestFixtures;

    [TestFixture]
    public class AllegroSetUpTest
    {
        [SetUp]
        public void SetUp()
        {
            BaseTestFixture.OpenService();
            HomePage.CloseRodo();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot.CaptureScreenshot(TestContext.CurrentContext.Test.MethodName);
            BaseTestFixture.CleanAndCloseWebsite();
        }
    }
}