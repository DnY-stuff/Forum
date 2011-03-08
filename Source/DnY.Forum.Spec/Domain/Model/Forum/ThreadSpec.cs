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
                                    OriginalPostWriter = new Member();
                                    OriginalPost = new Post("ȯ���մϴ�.", "blah~blah~blah~blah~blah~", OriginalPostWriter);
                                    CurrentForum = new Forum("�ӽ� ����", new List<Member>{new Member()});
                                };

        Because of = () => NewThread = new Thread(OriginalPost, CurrentForum);

        It should_exist_its_original_post = () => NewThread.OriginalPost.ShouldNotBeNull();
        It should_belong_to_some_forum = () => NewThread.CurrentForum.ShouldNotBeNull();

        private static Thread NewThread;
        private static Post OriginalPost;
        private static Member OriginalPostWriter;
        private static Forum CurrentForum;
    }

    [Subject(typeof(Post)), Tags("Domain.Entity")]
    public class when_created_new_post
    {
        Because of = () => NewPost = new Post("������ ��ü ���� ���ұ��?", "�� 21���� ���� ���Ҵٰ� �����մϴ�.������", Writer);

        It should_not_be_the_title_empty = () => NewPost.Title.ShouldNotBeEmpty();
        It should_be_the_content_of_more_than_10_characters = () => NewPost.Content.Length.ShouldBeGreaterThanOrEqualTo(10);
        
        private static Post NewPost;
        private static Member Writer;
    }
}