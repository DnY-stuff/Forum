namespace DnY.Forum.Application
{
    using Domain.Model;
    using Framework;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_administrator_try_to_create_new_forum : with_forum_service
    {
        It should_create_new_forum;
        It should_involve_opeartion_that_its_threads_become_a_empty_list;
        It should_involve_opeartion_that_its_moderator_assgiend_one_user_at_least;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_administrator_try_to_create_new_forum : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    public class with_forum_service : SpecificationFor<ForumService>
    {
        protected static Mock<IForumRepository> ForumRepository;
        protected static Mock<IMemberRepository> MemberRepository;
        protected static Mock<IAuthorityService> AuthorityService;

        public with_forum_service()
        {
            ForumRepository = AutoMocker.Get<IForumRepository>();
            MemberRepository = AutoMocker.Get<IMemberRepository>();
            AuthorityService = AutoMocker.Get<IAuthorityService>();
        }
    }
}