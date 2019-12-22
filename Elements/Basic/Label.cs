namespace Elements.Basic
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal class Label : BasicElement
    {
        public Label(By locator)
            : base(locator)
        {
        }

        public string GetValue()
        {
            return ElementHelpers.FindElement(this.MainLocator).Text;
        }
    }
}