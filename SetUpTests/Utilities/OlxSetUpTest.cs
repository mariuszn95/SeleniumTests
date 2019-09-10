using NUnit.Framework;
using OlxFramework.Pages;
using SetUpFramework.Selenium;

namespace SetUpTests.Utilities
{
    public class OlxSetUpTest
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