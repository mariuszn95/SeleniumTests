using Framework;
using NUnit.Framework;

namespace Tests
{
    public class EditPage
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [Test]
        public void Author_Can_Edit_A_Page()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("trUilbAS").WithPassword("9fzw6AfgjvnAdwYH&5").Login();

            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
