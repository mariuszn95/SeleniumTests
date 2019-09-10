using System;
using OpenQA.Selenium;
using WordPressFramework.Navigation;
using WordPressFramework.Selenium;

namespace WordPressFramework.Pages
{
    public static class NewPostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                if (title != null)
                    return title.GetAttribute("value");
                return string.Empty;
            }
        }

        public static void GoTo()
        {
            LeftNavigation.Posts.AddNew.Select();
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

        public static bool IsInEditMode()
        {
            var editPage = Driver.Instance.FindElement(By.ClassName("icon-edit-page")).Text;
            if (editPage.Contains("Edit Page"))
                return true;
            return false;
        }
    }

    public class CreatePostCommand
    {
        public CreatePostCommand(string title)
        {
            Title = title;
        }

        private string Body { get; set; }

        private string Title { get; }

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

            Driver.Wait(TimeSpan.FromSeconds(3));

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }
    }
}