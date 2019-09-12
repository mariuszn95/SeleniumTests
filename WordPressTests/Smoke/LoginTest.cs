namespace WordPressTests.Smoke
{
    using NUnit.Framework;

    using WordPressFramework.Pages;

    using WordPressTests.Utilities;

    public class LoginTest : SetUpTest
    {
        [Test]
        public void AdminUserCanLogin()
        {
            Assert.IsTrue(DashboadPage.IsAt(), "Failed to login.");
        }
    }
}