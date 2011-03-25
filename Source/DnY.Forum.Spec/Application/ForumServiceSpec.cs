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
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_administrator_try_to_create_new_forum : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_administrator_try_to_delete_forum : with_forum_service
    {
        It should_delete_forum;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_administrator_try_to_delete_forum : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_find_all_forum : with_forum_service
    {
        It should_find_all_forum;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_find_all_threads_of_some_forum : with_forum_service
    {
        It should_find_all_threads_of_some_forum;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_find_thread_by_id : with_forum_service
    {
        It should_find_thread_info_by_id;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_member_try_to_create_new_thread : with_forum_service
    {
        It should_create_new_thread;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_member_try_to_create_new_thread : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_member_try_to_reply_thread : with_forum_service
    {
        It should_reply_to_thread;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_member_try_to_reply_thread : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_member_try_to_modify_post : with_forum_service
    {
        It should_modify_post;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_member_try_to_modify_post : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_moderator_try_to_move_thread_to_some_forum : with_forum_service
    {
        It should_move_thread_to_some_forum;
    }

    [Subject(typeof(ForumService)), Tags("Application.ForumService")]
    public class when_user_as_not_moderator_try_to_move_thread_to_some_forum : with_forum_service
    {
        It should_occur_exception_about_authorization;
    }

    public class with_forum_service : SpecificationFor<ForumService>
    {
        protected static Mock<IForumRepository> ForumRepository;
        protected static Mock<IUserRepository> UserRepository;
        protected static Mock<IAuthorityService> AuthorityService;

        public with_forum_service()
        {
            ForumRepository = AutoMocker.Get<IForumRepository>();
            UserRepository = AutoMocker.Get<IUserRepository>();
            AuthorityService = AutoMocker.Get<IAuthorityService>();
        }
    }
}