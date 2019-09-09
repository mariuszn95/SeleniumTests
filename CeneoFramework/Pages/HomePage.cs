using System;
using CeneoFramework.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CeneoFramework.Pages
{
    public class HomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains("Ceneo"));
        }

        public static void Search(string searchValue)
        {
            Driver.Instance.FindElement(By.CssSelector("#form-head-search-q")).SendKeys(searchValue);
            Driver.Instance.FindElement(By.CssSelector(".search-icon")).Click();
        }
    }
}