namespace DnY.Forum.Domain.Model
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Forum)), Tags("Domain.Entity")]
    public class when_created_new_forum
    {
        It should_not_be_the_title_empty;
        It should_exist_one_moderator_at_least;
    }
}