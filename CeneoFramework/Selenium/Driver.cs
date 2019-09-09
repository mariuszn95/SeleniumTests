using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CeneoFramework.Selenium
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress => "https://www.ceneo.pl/";

        public static void Initialize()
        {
            Instance = new ChromeDriver("C:\\DEV\\SeleniumTests");
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}