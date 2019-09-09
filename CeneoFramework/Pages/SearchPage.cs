using OpenQA.Selenium;
using Selenium.Driver;

namespace CeneoFramework.Pages
{
    public class SearchPage
    {
        public static int GetThePriceOfTheFirstProduct
        {
            get
            {
                var priceValue = Driver.FindElement(By.CssSelector(".price .value")).Text;

                var intPrice = int.Parse(priceValue);

                return intPrice;
            }
        }
    }
}