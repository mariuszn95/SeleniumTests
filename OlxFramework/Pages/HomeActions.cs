namespace OlxFramework.Pages
{
    using System.Reflection;

    using Elements.Basic;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By SearchInput = By.CssSelector("#headerSearch");

        private static Button AcceptTrustPolicyButton => new Button(By.CssSelector("#onetrust-accept-btn-handler"));

        private static Button SearchButton => new Button(By.CssSelector("#submit-searchmain"));

        internal static void ClickAcceptTrustPolicy()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            AcceptTrustPolicyButton.Click();

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        internal static void ClickSearchButton()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            SearchButton.Click();

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        internal static void EnterSearchValue(string searchValue)
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            ElementHelpers.SendKeys(SearchInput, searchValue);

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}