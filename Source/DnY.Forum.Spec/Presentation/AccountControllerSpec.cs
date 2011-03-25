namespace DnY.Forum.Presentation
{
    using Framework;
    using Application;
    using Web.Controllers;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_requested_to_create_user : with_account_controller
    {
        It should_return_a_view_result_that_contains_input_form_named_Create;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_requested_to_create_user_with_input_data : with_account_controller
    {
        It should_invoked_method_named_that_CreateUser_of_IAccountService;
        It should_redirect_to_main_page_of_forum;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_requested_to_remove_user : with_account_controller
    {
        It should_invoked_method_named_that_RemoveUser_of_IAccountService;
        It should_redirect_to_main_page_of_forum;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_requested_to_sign_in : with_account_controller
    {
        It should_return_a_view_result_that_contains_input_form_named_Login;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_requested_to_sign_in_with_user_data : with_account_controller
    {
        It should_invoked_method_named_that_SignIn_of_IAccountService;
        It should_redirect_to_main_page_of_forum;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_requested_to_sign_out : with_account_controller
    {
        It should_invoked_method_named_that_SignOut_of_IAccountService;
        It should_redirect_to_main_page_of_forum;
    }

    public class with_account_controller : SpecificationFor<AccountController>
    {
        protected static Mock<IAccountService> AccountService;

        public with_account_controller()
        {
            AccountService = AutoMocker.Get<IAccountService>();
        }
    }
}