using NUnit.Framework;
using WordPressFramework.Pages;
using WordPressFramework.Selenium;

namespace WordPressTests.Utilities
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