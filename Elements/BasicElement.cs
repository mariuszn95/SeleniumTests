namespace Elements
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    public class BasicElement
    {
        public BasicElement(By locator)
        {
            this.MainLocator = locator;
        }

        public By MainLocator { get; private set; }

        public bool IsVisible()
        {
            return ElementHelpers.FindElement(this.MainLocator).Displayed;
        }

        public bool IsActive()
        {
            return ElementHelpers.FindElement(this.MainLocator).Enabled;
        }

        public bool IsReadOnly()
        {
            return this.IsVisible() && !this.IsActive();
        }
    }
}