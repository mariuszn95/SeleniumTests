namespace Elements.Basic
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal class Checkbox : BasicElement
    {
        public Checkbox(By locator)
            : base(locator)
        {
        }

        public void Check()
        {
            if (!this.IsChecked())
            {
                this.Click();
            }
        }

        public bool IsChecked()
        {
            return ElementHelpers.FindElement(this.MainLocator).Selected;
        }

        public void SetValue(bool? value)
        {
            if (value != null)
            {
                if (value == true)
                {
                    this.Check();
                }
                else
                {
                    this.Uncheck();
                }
            }
        }

        public void Uncheck()
        {
            if (this.IsChecked())
            {
                this.Click();
            }
        }

        private void Click()
        {
            ElementHelpers.Click(this.MainLocator);
        }
    }
}