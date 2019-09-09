using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Driver;
using Selenium.TestContexts;

namespace CeneoFramework.Pages
{
    public class HomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(TestContexts.GetBaseAddress());
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains("Ceneo"));
        }

        public static void Search(string searchValue)
        {
            Driver.FindElement(By.CssSelector("#form-head-search-q")).SendKeys(searchValue);
            Driver.FindElement(By.CssSelector(".search-icon")).Click();
        }
    }
}