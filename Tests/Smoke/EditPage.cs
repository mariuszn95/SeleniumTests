using Framework.Pages;
using NUnit.Framework;
using Tests.Utilities;

namespace Tests.Smoke
{
    public class EditPage : SetUpTest
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
