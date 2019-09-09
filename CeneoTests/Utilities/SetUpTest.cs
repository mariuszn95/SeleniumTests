using CeneoFramework.Pages;
using CeneoFramework.Selenium;
using NUnit.Framework;

namespace CeneoTests.Utilities
{
    public class SetUpTest
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
            HomePage.GoTo();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}