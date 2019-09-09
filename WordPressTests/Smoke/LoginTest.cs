using NUnit.Framework;
using WordPressFramework.Pages;
using WordPressTests.Utilities;

namespace WordPressTests.Smoke
{
    public class LoginTest : SetUpTest
    {
        [Test]
        public void Admin_User_Can_Login()
        {
            Assert.IsTrue(DashboadPage.IsAt(), "Failed to login.");
        }
    }
}