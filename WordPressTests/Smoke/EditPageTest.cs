using NUnit.Framework;
using WordPressFramework.Pages;
using WordPressTests.Utilities;

namespace WordPressTests.Smoke
{
    public class EditPageTest : SetUpTest
    {
        [Test]
        public void Author_Can_Edit_A_Page()
        {
            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }
    }
}
