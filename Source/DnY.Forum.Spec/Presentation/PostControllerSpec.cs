namespace DnY.Forum.Presentation
{
    using Framework;
    using Application;
    using Web.Controllers;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(PostController)), Tags("Presentation.PostController")]
    public class when_requested_to_modify_post : with_post_controller
    {
        It should_return_a_view_result_that_contains_input_form_named_Edit;
    }

    [Subject(typeof(PostController)), Tags("Presentation.PostController")]
    public class when_requested_to_modify_post_with_input_data : with_post_controller
    {
        It should_invoked_method_named_that_ModifyPost_of_IForumService;
        It should_redirect_to_thread_info_page_of_forum;
    }

    public class with_post_controller : SpecificationFor<PostController>
    {
        protected static Mock<IForumService> ForumService;

        public with_post_controller()
        {
            ForumService = AutoMocker.Get<IForumService>();
        }
    }
}