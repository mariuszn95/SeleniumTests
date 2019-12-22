namespace Elements.Basic
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal class Input : BasicElement
    {
        public Input(By locator)
            : base(locator)
        {
        }

        public void Clear()
        {
            ElementHelpers.FindElement(this.MainLocator).Clear();
        }

        public void EnterValue(string value)
        {
            if (value != null)
            {
                ElementHelpers.SendKeys(this.MainLocator, value);
            }
        }

        public string GetValue()
        {
            return ElementHelpers.FindElement(this.MainLocator).GetAttribute("value");
        }
    }
}