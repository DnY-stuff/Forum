namespace DnY.Forum.Domain.Model.Account
{
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Member)), Tags("Domain.Entity")]
    public class when_created_new_member
    {
        Establish context = () =>
                                {
                                    emailaddress = "dkshin67@gmail.com";
                                    password = "password";
                                    name = "Dongkyu Shin";
                                };


        Because of = () => NewMember = new Member(emailaddress, password, name);

        It should_not_be_empty_its_email = () => NewMember.Email.ShouldNotBeEmpty();
        It should_not_be_empty_its_password = () => NewMember.Password.ShouldNotBeEmpty();
        It should_not_be_empty_its_name = () => NewMember.Name.ShouldNotBeEmpty();
        It should_have_authority_as_member_type = () => NewMember.Type.ShouldEqual(MemberType.Member);

        private static Member NewMember;
        private static string name;
        private static string password;
        private static string emailaddress;
    }
}