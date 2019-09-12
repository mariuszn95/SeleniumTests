namespace WordPressTests.Smoke
{
    using NUnit.Framework;

    using WordPressFramework.Pages;
    using WordPressFramework.Pages.NewPostPage;

    using WordPressTests.Utilities;

    public class CreatePostTest : SetUpTest
    {
        [Test]
        public void AuthorCanCreateABasicPost()
        {
            NewPostPage.GoTo();
            NewPostPage.CreatePost("This is test post title").WithBody("Hi, this is the body.").Publish();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "This is test post title", "Title did not match new post.");
        }
    }
}