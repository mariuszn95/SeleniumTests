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
            CeneoDriver.Initialize();
            HomePage.GoTo();
        }

        [TearDown]
        public void Cleanup()
        {
            CeneoDriver.Close();
        }
    }
}