namespace DnY.Forum.Domain.Model
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Forum)), Tags("Domain.Entity")]
    public class when_created_new_forum
    {
        Because of = () => NewForum = new Forum();
        
        It should_not_be_the_title_empty = () => NewForum.Title.ShouldNotBeEmpty();
        It should_exist_one_moderator_at_least = () =>
                                                    {
                                                        NewForum.Moderators.ShouldNotBeNull();
                                                        NewForum.Moderators.ShouldNotBeEmpty();
                                                    };

        private static Forum NewForum;
    }
}