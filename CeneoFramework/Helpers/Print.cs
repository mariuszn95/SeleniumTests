using System;
using OpenQA.Selenium;
using Selenium.Driver;

namespace CeneoFramework.Helpers
{
    public class Print
    {
        public static FirstProductInformation FirstProductInformation()
        {
            return new FirstProductInformation();
        }
    }

    public class FirstProductInformation
    {
        private string _name;
        private string _price;

        public FirstProductInformation Name()
        {
            _name = Driver.FindElement(By.CssSelector(".cat-prod-row-name a")).Text;

            Console.Write($"Name: {_name}");

            return this;
        }

        public FirstProductInformation WithPrice()
        {
            var priceValue = Driver.FindElement(By.CssSelector(".price .value")).Text;
            var pricePenny = Driver.FindElement(By.CssSelector(".price .penny")).Text;

            _price = $"{priceValue}{pricePenny}";

            Console.WriteLine($", Price: {_price}");

            return this;
        }
    }
}