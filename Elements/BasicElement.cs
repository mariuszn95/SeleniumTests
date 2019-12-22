namespace Elements
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal class BasicElement
    {
        public BasicElement(By locator)
        {
            this.MainLocator = locator;
        }

        public By MainLocator { get; private set; }

        public bool IsVisible()
        {
            return ElementHelpers.FindElement(this.MainLocator).Enabled;
        }
    }
}