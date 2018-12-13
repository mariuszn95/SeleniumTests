using System.Threading;
using OpenQA.Selenium;

namespace Framework
{
    public class NewPostPage
    {
        public static void GoTo()
        {
            var menuPosts = Driver.Instance.FindElement(By.Id("menu-posts"));
            menuPosts.Click();

            var addNew = Driver.Instance.FindElement(By.LinkText("Add New"));
            addNew.Click();
        }

        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.Id("sample-permalink"));
            var newPostLink = message.FindElement(By.TagName("a"));
            newPostLink.Click();
        }
    }

    public class CreatePostCommand
    {
        private readonly string _title;
        private string _body;

        public string Body { get => _body; set => _body = value; }

        public string Title => _title;

        public CreatePostCommand(string title)
        {
            _title = title;
        }

        public CreatePostCommand WithBody(string body)
        {
            Body = body;
            return this;
        }

        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("title")).SendKeys(Title);

            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(Body);
            Driver.Instance.SwitchTo().DefaultContent();

            Thread.Sleep(1000);

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }
    }
}
