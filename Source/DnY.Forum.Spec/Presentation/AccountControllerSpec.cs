namespace DnY.Forum.Presentation
{
    using Framework;
    using Application;
    using Web.Controllers;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_try_create_account : with_account_controller
    {
        It should_call_named_create_account_of_account_service;
        It should_return_a_view_result_that_created_account_info_as_action_result;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_try_remove_account : with_account_controller
    {
        It should_call_named_remove_account_of_account_service;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_try_sign_in : with_account_controller
    {
        It should_call_named_sign_in_of_account_service;
    }

    [Subject(typeof(AccountController)), Tags("Presentation.AccountController")]
    public class when_try_sign_out : with_account_controller
    {
        It should_call_named_sign_out_of_account_service;
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