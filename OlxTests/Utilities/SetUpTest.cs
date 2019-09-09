using NUnit.Framework;
using OlxFramework.Pages;
using OlxFramework.Selenium;

namespace OlxTests.Utilities
{
    public class SetUpTest
    {
        [SetUp]
        public void Init()
        {
            OlxDriver.Initialize();
            HomePage.GoTo();
        }

        [TearDown]
        public void Cleanup()
        {
            OlxDriver.Close();
        }
    }
}