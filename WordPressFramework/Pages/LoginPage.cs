using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WordPressFramework.Selenium;

namespace WordPressFramework.Pages
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "wp-login.php");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string _userName;
        private string _password;

        public string UserName => _userName;

        public string Password { get => _password; set => _password = value; }

        public LoginCommand(string userName)
        {
            _userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            Password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("user_login"));
            loginInput.SendKeys(UserName);

            var passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.SendKeys(Password);

            var loginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            loginButton.Click();
        }
    }
}
