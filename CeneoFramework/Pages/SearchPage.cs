using CeneoFramework.Selenium;
using OpenQA.Selenium;

namespace CeneoFramework.Pages
{
    public class SearchPage
    {
        public static int GetThePriceOfTheFirstProduct
        {
            get
            {
                var priceValue = Driver.Instance.FindElement(By.CssSelector(".price .value")).Text;

                var intPrice = int.Parse(priceValue);

                return intPrice;
            }
        }
    }
}