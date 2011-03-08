namespace DnY.Forum.Domain.Model
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Thread)), Tags("Domain.Entity")]
    public class when_created_new_thread
    {
        It should_exist_its_original_post;
        It should_belong_to_some_forum;
    }

    [Subject(typeof(Post)), Tags("Domain.Entity")]
    public class when_created_new_post
    {
        It should_not_be_the_title_empty;
        It should_be_the_content_of_more_than_10_characters;
    }
}