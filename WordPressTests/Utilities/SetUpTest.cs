namespace WordPressTests.Utilities
{
    using NUnit.Framework;

    using WordPressFramework.Pages.LoginPage;
    using WordPressFramework.Selenium;

    public class SetUpTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("admin").Login();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}