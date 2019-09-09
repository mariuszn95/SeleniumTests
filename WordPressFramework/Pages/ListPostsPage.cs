using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WordPressFramework.Navigation;
using WordPressFramework.Selenium;

namespace WordPressFramework.Pages
{
    public class ListPostsPage
    {
        private static int _lastCount;
        public static int PreviousPostCount
        {
            get { return _lastCount; }
        }

        public static int CurrentPostCount
        {
            get { return GetPostCount(); }
        }

        public static void GoTo(PostType postType)
        {
            switch (postType)
            {
                case PostType.Page:
                    LeftNavigation.Pages.AllPages.Select();
                    break;

                case PostType.Posts:
                    LeftNavigation.Posts.AllPosts.Select();
                    break;
            }
        }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText(title));
            postLink.Click();
        }

        public static void StoreCount()
        {
            _lastCount = GetPostCount();
        }

        private static int GetPostCount()
        {
            var countText = Driver.Instance.FindElement(By.ClassName("displaying-num")).Text;
            return int.Parse(countText.Split(' ')[0]);
        }

        public static bool DoesPostExistWithTitle(string title)
        {
            try
            {
                Driver.Instance.FindElement(By.LinkText(title));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static void TrashPost(string title)
        {
            var rows = Driver.Instance.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                ReadOnlyCollection<IWebElement> links;
                links = row.FindElements(By.LinkText(title));

                if (links.Count > 0)
                {
                    Actions action = new Actions(Driver.Instance);
                    action.MoveToElement(links[0]);
                    action.Perform();
                    row.FindElement(By.ClassName("submitdelete")).Click();
                    return;
                }
            }
        }
    }

    public enum PostType
    {
        Page,
        Posts
    }
}
