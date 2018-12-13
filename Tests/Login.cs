using Framework;
using NUnit.Framework;

namespace Tests
{
    public class Login
    {
        [SetUp]
        public void Setup()
        {
            Driver.Initialize();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.Close();
        }

        [Test]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("BM0XLfhWKtkIjT87HT2Q").WithPassword("npm()!j)HkxTkNUR3g7@xsSN").Login();

            Assert.IsTrue(DashboadPage.IsAt(), "Failed to login.");
        }
    }
}