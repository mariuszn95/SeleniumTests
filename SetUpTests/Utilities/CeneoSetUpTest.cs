namespace SetUpTests.Utilities
{
    using NUnit.Framework;

    using SetUpFramework.Screenshot;
    using SetUpFramework.TestFixtures;

    [TestFixture]
    public class CeneoSetUpTest
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