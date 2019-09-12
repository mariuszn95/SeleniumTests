namespace WordPressFramework.Navigation
{
    using OpenQA.Selenium;

    using WordPressFramework.Selenium;

    internal static class MenuSelector
    {
        public static void Select(string topLevelMenuId, string subMenuLinkText)
        {
            Driver.Instance.FindElement(By.Id(topLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(subMenuLinkText)).Click();
        }
    }
}