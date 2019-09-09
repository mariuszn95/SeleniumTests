using NUnit.Framework;
using WordPressFramework.Pages;
using WordPressTests.Utilities;

namespace WordPressTests.Smoke
{
    public class CreatePostTest : SetUpTest
    {
        [Test]
        public void Author_Can_Create_A_Basic_Post()
        {
            NewPostPage.GoTo();
            NewPostPage.CreatePost("This is test post title")
                .WithBody("Hi, this is the body.")
                .Publish();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "This is test post title", "Title did not match new post.");
        }
    }
}