using System;
using CeneoFramework.Selenium;
using OpenQA.Selenium;

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
            _name = Driver.Instance.FindElement(By.CssSelector(".cat-prod-row-name a")).Text;

            Console.Write($"Name: {_name}");

            return this;
        }

        public FirstProductInformation WithPrice()
        {
            var priceValue = Driver.Instance.FindElement(By.CssSelector(".price .value")).Text;
            var pricePenny = Driver.Instance.FindElement(By.CssSelector(".price .penny")).Text;

            _price = $"{priceValue}{pricePenny}";

            Console.WriteLine($", Price: {_price}");

            return this;
        }
    }
}