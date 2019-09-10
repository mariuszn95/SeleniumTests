using CeneoFramework.Pages;
using NUnit.Framework;
using SetUpFramework.Selenium;

namespace SetUpTests.Utilities
{
    public class CeneoSetUpTest
    {
        [SetUp]
        public void Init()
        {
            SetUpDriver.Initialize();
            HomePage.GoTo();
        }

        [TearDown]
        public void Cleanup()
        {
            SetUpDriver.Close();
        }
    }
}