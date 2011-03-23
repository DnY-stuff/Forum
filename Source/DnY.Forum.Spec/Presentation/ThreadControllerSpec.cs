namespace DnY.Forum.Presentation
{
    using Framework;
    using Application;
    using Web.Controllers;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(ThreadController)), Tags("Presentation.ThreadController")]
    public class when_requested_thread_index_page : with_thread_controller
    {
        It should_invoked_method_named_that_FindThreadById_of_IForumService;
        It should_return_a_view_result_that_contains_form_named_Index;
        It should_return_a_view_result_that_contains_Thread_type;
    }

    [Subject(typeof(ThreadController)), Tags("Presentation.ThreadController")]
    public class when_requested_to_create_thread : with_thread_controller
    {
        It should_return_a_view_result_that_contains_input_form_named_Create;
    }

    [Subject(typeof(ThreadController)), Tags("Presentation.ThreadController")]
    public class when_requested_to_create_thread_with_input_data : with_thread_controller
    {
        It should_invoked_method_named_that_CreateNewThread_of_IForumService;
        It should_redirect_to_thread_info_page_of_forum;
    }

    [Subject(typeof(ThreadController)), Tags("Presentation.ThreadController")]
    public class when_requested_to_reply_thread : with_thread_controller
    {
        It should_return_a_view_result_that_contains_input_form_named_Reply;
    }

    [Subject(typeof(ThreadController)), Tags("Presentation.ThreadController")]
    public class when_requested_to_reply_thread_with_input_data : with_thread_controller
    {
        It should_invoked_method_named_that_ReplyThread_of_IForumService;
        It should_redirect_to_thread_info_page_of_forum;
    }

    [Subject(typeof(ThreadController)), Tags("Presentation.ThreadController")]
    public class when_requested_to_move_thread : with_thread_controller
    {
        It should_invoked_method_named_that_MoveThreadToForum_of_IForumService;
        It should_redirect_to_forum_info_page_of_forum;
    }

    public class with_thread_controller : SpecificationFor<ThreadController>
    {
        protected static Mock<IForumService> ForumService;

        public with_thread_controller()
        {
            ForumService = AutoMocker.Get<IForumService>();
        }
    }
}