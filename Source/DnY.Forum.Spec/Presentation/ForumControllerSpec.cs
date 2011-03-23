namespace DnY.Forum.Presentation
{
    using Framework;
    using Application;
    using Web.Controllers;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_requested_to_create_forum : with_forum_controller
    {
        It should_return_a_view_result_that_contains_input_form_named_Create;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_requested_to_create_forum_with_input_data : with_forum_controller
    {
        It should_invoked_method_named_that_CreateForum_of_IForumService;
        It should_redirect_to_main_page_of_forum;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_requested_to_delete_forum : with_forum_controller
    {
        It should_invoked_method_named_that_DeleteForum_of_IForumService;
        It should_redirect_to_main_page_of_forum;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_requested_forum_index_page : with_forum_controller
    {
        It should_invoked_method_named_that_FindAllForum_of_IForumService;
        It should_return_a_view_result_that_contains_form_named_Index;
        It should_return_a_view_result_that_contains_collection_of_Forum_type;
    }

    [Subject(typeof(ForumController)), Tags("Presentation.ForumController")]
    public class when_requested_forum_index_page_with_forum_id : with_forum_controller
    {
        It should_invoked_method_named_that_FindAllThreadByForum_of_IForumService;
        It should_return_a_view_result_that_contains_form_named_Details;
        It should_return_a_view_result_that_contains_collection_of_Thread_type;
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