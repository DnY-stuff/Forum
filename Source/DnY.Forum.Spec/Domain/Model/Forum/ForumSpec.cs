using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Forum)), Tags("Domain.Entity")]
    public class when_created_new_forum
    {
        Establish context = () =>
                                {
                                    Moderator = new List<Member> {new Member()};
                                };


        Because of = () => NewForum = new Forum("Forum 이용관련", Moderator);
        
        It should_not_be_the_title_empty = () => NewForum.Title.ShouldNotBeEmpty();
        It should_exist_one_moderator_at_least = () =>
                                                    {
                                                        NewForum.Moderators.ShouldNotBeNull();
                                                        NewForum.Moderators.ShouldNotBeEmpty();
                                                    };

        private static Forum NewForum;
        private static IList<Member> Moderator;
    }
}