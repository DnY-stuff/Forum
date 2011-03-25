using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Thread)), Tags("Domain.Entity")]
    public class when_created_new_thread
    {
        Establish context = () =>
                                {
                                    OriginalPostWriter = new User("dkshin67@gmail.com", "password", "Dongkyu Shin");
                                    OriginalPost = new Post("환영합니다.", "blah~blah~blah~blah~blah~", OriginalPostWriter);
                                    CurrentForum = new Forum("임시 포럼", new List<User> { new User("administrator@dny.com", "password", "Administrator") });
                                };

        Because of = () => NewThread = new Thread(OriginalPost, CurrentForum);

        It should_exist_its_original_post = () => NewThread.OriginalPost.ShouldNotBeNull();
        It should_belong_to_some_forum = () => NewThread.CurrentForum.ShouldNotBeNull();

        private static Thread NewThread;
        private static Post OriginalPost;
        private static User OriginalPostWriter;
        private static Forum CurrentForum;
    }

    [Subject(typeof(Post)), Tags("Domain.Entity")]
    public class when_created_new_post
    {
        Because of = () => NewPost = new Post("지구는 대체 언제 망할까요?", "전 21개월 정도 남았다고 생각합니다.ㅎㅎㅎ", Writer);

        It should_not_be_the_title_empty = () => NewPost.Title.ShouldNotBeEmpty();
        It should_be_the_content_of_more_than_10_characters = () => NewPost.Content.Length.ShouldBeGreaterThanOrEqualTo(10);
        
        private static Post NewPost;
        private static User Writer;
    }
}