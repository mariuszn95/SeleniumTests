using Tests.Utilities;
using NUnit.Framework;

namespace Tests.Posts
{
    public class AllPosts : SetUpTest
    {
//        Added posts show up in all posts
//        Can active excerpt mode
//        Can Add new
//        
//        Single post selections
//        
//        Can select a post by title
//        Can select a post by Edit
//        Can select a post by QuickEdit
//        Can trash a post
//        Can view a post
//        Can filter by author
//        Can filter by category
//        Can filter by tag
//        Can go to post comments
//        
//        Bulk actions
//        
//        Can edit multiple posts
//        Can trash multiple posts
//        Can select multiple posts
//        
//        Drop down filters
//        
//        Can filter by month
//        Can filter by category
//        Can view published only
//        Can view view drafts only
//        Can view view trash only
//        
//        Can search posts
//        
//        Added posts show up in all posts
//        Can trash a post
//        Can search posts

        [Test]
        public void Added_Posts_Show_Up()
        {
//            // Go to posts, get post count, store
//            ListPostsPage.GoTo(PostPage.Posts);
//            ListPostsPage.StoreCount();
//            
//            // Add a new post
//            NewPostPage.GoTo();
//            NewPostPage.CreatePost("Added posts show up, title")
//                .WithBody("Added posts show up, body")
//                .Publish();
//            
//            // Go to posts, get new post count
//            ListPostsPage.GoTo(PostType.Posts);
//            Assert.AreEqual(ListPostsPage.PreviousPostCount + 1, ListPostsPage.CurrentPostCount, "Count of posts did not increase");
//            
//            // Check for added post
//            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle("Added posts show up, title"));
//            
//            // Trash post (clean up)
//            ListPostsPage.TrashPost("");
//            Assert.AreEqual(ListPostsPage.PreviousPostCount, ListPostsPage.CurrentPostCount, "Couldn't trash post");
        }
    }
}
