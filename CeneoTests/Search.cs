using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CeneoTests
{
    [TestFixture]
    public class Search
    {
        private IWebDriver _driver = new ChromeDriver("C:\\DEV\\SeleniumTests");

        [Test]
        public void User_Can_Search_A_Mug_And_Write_Price_Of_The_First_Found_Item_And_Check_If_The_Price_Is_Greater_Than_20zł()
        {
            _driver.Navigate().GoToUrl("http://www.ceneo.pl");

            _driver.FindElement(By.CssSelector("#form-head-search-q")).SendKeys("Mug");
            _driver.FindElement(By.CssSelector(".search-icon")).Click();

            var name = _driver.FindElement(By.CssSelector(".cat-prod-row-name a")).Text;
            var priceValue = _driver.FindElement(By.CssSelector(".price .value")).Text;
            var pricePenny = _driver.FindElement(By.CssSelector(".price .penny")).Text;

            Console.WriteLine($"Name: {name}, Price: {priceValue}{pricePenny}");

            var intPrice = int.Parse(priceValue);

            Assert.True(intPrice > 20);
        }
    }
}

/*
1. Go to http://www.ceneo.pl
2. Search for "Mug"
3. Write in console the name and price of the first found item
4. Check if the price is greater than 20zl
*/