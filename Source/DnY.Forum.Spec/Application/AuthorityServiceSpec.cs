namespace DnY.Forum.Application
{
    using Domain.Model;
    using Framework;
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(AuthorityService)), Tags("Application")]
    public class when_given_a_user_as_administrator : SpecificationFor<AuthorityService>
    {
        Establish context = () => administrator = new Member("aaa@gmail.com", "1111", "Dongkyu Shin") {Type = MemberType.Administrator};

        It should_return_value_that_has_administrator_level = () => ClassUnderTest.HasAdministratorLevel(administrator).ShouldBeTrue();
        It should_return_value_that_has_moderator_level = () => ClassUnderTest.HasModeratorLevel(administrator).ShouldBeTrue();
        It should_return_value_that_has_member_level = () => ClassUnderTest.HasMemberLevel(administrator).ShouldBeTrue();
        
        private static Member administrator;
    }

    [Subject(typeof(AuthorityService)), Tags("Application")]
    public class when_given_a_user_as_moderator : SpecificationFor<AuthorityService>
    {
        Establish context = () => moderator = new Member("aaa@gmail.com", "1111", "Dongkyu Shin") { Type = MemberType.Moderator };

        It should_return_value_that_has_not_administrator_level = () => ClassUnderTest.HasAdministratorLevel(moderator).ShouldBeFalse();
        It should_return_value_that_has_moderator_level = () => ClassUnderTest.HasModeratorLevel(moderator).ShouldBeTrue();
        It should_return_value_that_has_member_level = () => ClassUnderTest.HasMemberLevel(moderator).ShouldBeTrue();

        private static Member moderator;
    }

    [Subject(typeof(AuthorityService)), Tags("Application")]
    public class when_given_a_user_as_member : SpecificationFor<AuthorityService>
    {
        Establish context = () => member = new Member("aaa@gmail.com", "1111", "Dongkyu Shin") { Type = MemberType.Member };

        It should_return_value_that_has_not_administrator_level = () => ClassUnderTest.HasAdministratorLevel(member).ShouldBeFalse();
        It should_return_value_that_has_not_moderator_level = () => ClassUnderTest.HasModeratorLevel(member).ShouldBeFalse();
        It should_return_value_that_has_member_level = () => ClassUnderTest.HasMemberLevel(member).ShouldBeTrue();

        private static Member member;
    }
}