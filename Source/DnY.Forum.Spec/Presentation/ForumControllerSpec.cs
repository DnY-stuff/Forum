namespace DnY.Forum.Presentation
{
    using Framework;
    using Application;
    using Web.Controllers;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_create_forum : with_forum_controller
    {
        It should_call_named_create_forum_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_delete_forum : with_forum_controller
    {
        It should_call_named_delete_forum_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_find_all_forum : with_forum_controller
    {
        It should_call_named_find_all_forum_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_find_all_thread_by_forum : with_forum_controller
    {
        It should_call_named_find_all_thread_by_forum_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_find_thread_by_id : with_forum_controller
    {
        It should_call_named_find_thread_by_id_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_create_new_thread : with_forum_controller
    {
        It should_call_named_create_new_thread_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_reply_thread : with_forum_controller
    {
        It should_call_named_reply_thread_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_modify_post : with_forum_controller
    {
        It should_call_named_modify_post_of_forum_service;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_try_move_thread_to_forum : with_forum_controller
    {
        It should_call_named_move_thread_to_forum_of_forum_service;
    }

    public class with_forum_controller : SpecificationFor<ForumController>
    {
        protected static Mock<IForumService> ForumService;

        public with_forum_controller()
        {
            ForumService = AutoMocker.Get<IForumService>();
        }
    }
}