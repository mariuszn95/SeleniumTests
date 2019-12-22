namespace Elements.Basic
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal class Dropdown : BasicElement
    {
        public Dropdown(By locator)
            : base(locator)
        {
        }

        public void Clear()
        {
            var clearIcon = ElementHelpers.FindElement(this.MainLocator);
            ElementHelpers.Click(clearIcon);
        }

        public string GetValue()
        {
            return ElementHelpers.FindElement(this.MainLocator).Text;
        }

        public void SelectValue(string value)
        {
            if (value != null)
            {
                // PickValueFromDropdown
            }
        }
    }
}