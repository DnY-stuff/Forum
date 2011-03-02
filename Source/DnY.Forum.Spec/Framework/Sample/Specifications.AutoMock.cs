namespace DnY.Forum.Framework.Sample
{
    using Framework;
    using Moq;
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(DependencyController), "invoke dependency method"), Tags("Sample.BDDFramework.Automock")]
    public class when_given_a_dependency_controller : SpecificationFor<DependencyController>
    {
        Establish context = () => _dependency = AutoMocker.Get<IDependency>();

        Because of = () => ClassUnderTest.InvokeDependencyMethod();

        It should_call_dependency_method = () => _dependency.Verify(dependency => dependency.Method(), Times.Once());

        private static Mock<IDependency> _dependency;
    }

    [Subject(typeof(DependencyController), "invoke dependency method"), Tags("Sample.BDDFramework.Automock")]
    public class when_given_a_dependency_controller_using_with_dependency_object : with_dependency_object
    {
        Because of = () => ClassUnderTest.InvokeDependencyMethod();

        It should_call_dependency_method = () => Dependency.Verify(dependency => dependency.Method(), Times.Once());
    }

    public class with_dependency_object : SpecificationFor<DependencyController>
    {
        protected static Mock<IDependency> Dependency;

        public with_dependency_object()
        {
            Dependency = AutoMocker.Get<IDependency>();
        }
    }

    public interface IDependency
    {
        void Method();
    }

    public class DependencyController
    {
        protected IDependency Dependency { get; set; }

        public DependencyController(IDependency dependency)
        {
            Dependency = dependency;
        }

        public void InvokeDependencyMethod()
        {
            Dependency.Method();
        }
    }
}