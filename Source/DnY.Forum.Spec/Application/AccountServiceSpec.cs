namespace DnY.Forum.Application
{
    using Domain.Model;
    using Framework;
    using Machine.Specifications;
    using Moq;
    using It = Machine.Specifications.It;

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_create_new_user_with_valid_account_information : with_account_service
    {
        It should_create_new_user;
        It should_created_user_has_authority_as_member;
        It should_created_user_has_identity; // TODO : 차후 Persistence Layer에서 테스트되어야 할 대상
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_create_new_user_with_invalid_user_information : with_account_service
    {
        It should_occur_argument_eception;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_create_new_user_with_existed_user_information : with_account_service
    {
        It should_occur_eception;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_remove_existed_user_as_member : with_account_service
    {
        It should_remove_user;
        It should_involve_deleting_of_his_threads;
        It should_involve_deleting_of_his_posts;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_remove_existed_user_as_moderator : with_account_service
    {
        It should_remove_user;
        It should_involve_deleting_of_his_threads;
        It should_involve_deleting_of_his_posts;
        It should_invlove_clearing_of_his_forum_authrorization_if_he_is_moderator;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_remove_existed_user_as_administrator : with_account_service
    {
        // TODO : 우선 관리자는 삭제할 수 없도록 한다. 후에 좀 더 생각해보도록 한다.
        It should_occur_exception;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_remove_not_existed_user : with_account_service
    {
        It should_occur_eception;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_signin_with_existed_user : with_account_service
    {
        It should_return_a_user;
    }

    [Subject(typeof(AccountService)), Tags("Application.AccountService")]
    public class when_try_signin_with_not_existed_user : with_account_service
    {
        It should_return_a_null;
    }

    public class with_account_service : SpecificationFor<AccountService>
    {
        protected static Mock<IUserRepository> UserRepository;

        public with_account_service()
        {
            UserRepository = AutoMocker.Get<IUserRepository>();
        }
    }
}