namespace WordPressFramework.Pages.LoginPage
{
    using OpenQA.Selenium;

    using WordPressFramework.Selenium;

    public class LoginCommand
    {
        public LoginCommand(string userName)
        {
            this.UserName = userName;
        }

        private string Password { get; set; }

        private string UserName { get; }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("user_login"));
            loginInput.SendKeys(this.UserName);

            var passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.SendKeys(this.Password);

            var loginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            loginButton.Click();
        }

        public LoginCommand WithPassword(string password)
        {
            this.Password = password;
            return this;
        }
    }
}