using Framework.Pages;
using NUnit.Framework;
using Tests.Utilities;

namespace Tests.Smoke
{
    public class CreatePost : SetUpTest
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
