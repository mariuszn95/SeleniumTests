using Framework.Pages;
using NUnit.Framework;
using Tests.Utilities;

namespace Tests.Smoke
{
    public class Login : SetUpTest
    {
        [Test]
        public void Admin_User_Can_Login()
        {
            Assert.IsTrue(DashboadPage.IsAt(), "Failed to login.");
        }
    }
}