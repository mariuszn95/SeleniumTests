namespace WordPressFramework.Pages.NewPostPage
{
    using System;

    using OpenQA.Selenium;

    using WordPressFramework.Selenium;

    public class CreatePostCommand
    {
        public CreatePostCommand(string title)
        {
            this.Title = title;
        }

        private string Body { get; set; }

        private string Title { get; }

        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("title")).SendKeys(this.Title);

            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(this.Body);
            Driver.Instance.SwitchTo().DefaultContent();

            Driver.Wait(TimeSpan.FromSeconds(3));

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }

        public CreatePostCommand WithBody(string body)
        {
            this.Body = body;
            return this;
        }
    }
}