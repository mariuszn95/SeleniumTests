namespace WordPressTests.Smoke
{
    using NUnit.Framework;

    using WordPressFramework.Pages;
    using WordPressFramework.Pages.ListPostsPageEnum;
    using WordPressFramework.Pages.NewPostPage;

    using WordPressTests.Utilities;

    public class EditPageTest : SetUpTest
    {
        [Test]
        public void AuthorCanEditAPage()
        {
            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }
    }
}