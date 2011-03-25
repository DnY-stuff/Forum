namespace DnY.Forum.Domain.Model.Account
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(User)), Tags("Domain.Entity")]
    public class when_created_new_user
    {
        Establish context = () =>
                                {
                                    emailaddress = "dkshin67@gmail.com";
                                    password = "password";
                                    name = "Dongkyu Shin";
                                };


        Because of = () => _newUser = new User(emailaddress, password, name);

        It should_not_be_empty_its_email = () => _newUser.Email.ShouldNotBeEmpty();
        It should_not_be_empty_its_password = () => _newUser.Password.ShouldNotBeEmpty();
        It should_not_be_empty_its_name = () => _newUser.Name.ShouldNotBeEmpty();
        It should_have_authority_as_member = () => _newUser.Type.ShouldEqual(UserType.Member);

        private static User _newUser;
        private static string name;
        private static string password;
        private static string emailaddress;
    }
}