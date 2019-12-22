namespace Elements.Basic
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    public class Button : BasicElement
    {
        public Button(By locator)
            : base(locator)
        {
        }

        public void Click()
        {
            ElementHelpers.Click(this.MainLocator);
        }
    }
}