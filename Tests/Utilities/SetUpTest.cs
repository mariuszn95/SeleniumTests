using Framework.Pages;
using Framework.Selenium;
using NUnit.Framework;

namespace Tests.Utilities
{
    public class SetUpTest
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("admin").Login();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
