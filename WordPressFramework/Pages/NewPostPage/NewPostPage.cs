namespace WordPressFramework.Pages.NewPostPage
{
    using OpenQA.Selenium;

    using WordPressFramework.Navigation;
    using WordPressFramework.Selenium;

    public static class NewPostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                if (title != null)
                {
                    return title.GetAttribute("value");
                }

                return string.Empty;
            }
        }

        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        public static void GoTo()
        {
            LeftNavigation.Posts.AddNew.Select();
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
            {
                return true;
            }

            return false;
        }
    }
}