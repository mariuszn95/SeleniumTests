namespace OlxTests.Utilities
{
    using NUnit.Framework;

    using SetUpFramework.Screenshot;
    using SetUpFramework.TestFixtures;

    [TestFixture]
    public class OlxSetUpTest
    {
        [SetUp]
        public void SetUp()
        {
            BaseTestFixture.OpenService();
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot.CaptureScreenshot(TestContext.CurrentContext.Test.MethodName);
            BaseTestFixture.CleanAndCloseWebsite();
        }
    }
}