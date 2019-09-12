namespace WordPressFramework.Pages
{
    using OpenQA.Selenium;

    using WordPressFramework.Selenium;

    public static class PostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.ClassName("entry-title"));
                if (title != null)
                {
                    return title.Text;
                }

                return string.Empty;
            }
        }
    }
}