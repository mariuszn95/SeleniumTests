using Framework;
using NUnit.Framework;

namespace Tests
{
    public class CreatePost
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [Test]
        public void Author_Can_Create_A_Basic_Post()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("BM0XLfhWKtkIjT87HT2Q").WithPassword("npm()!j)HkxTkNUR3g7@xsSN").Login();

            NewPostPage.GoTo();
            NewPostPage.CreatePost("This is test post title")
                .WithBody("Hi, this is the body.")
                .Publish();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "This is test post title", "Title did not match new post.");
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
