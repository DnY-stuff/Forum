namespace DnY.Forum.Framework
{
    using Moq;

    public abstract class SpecificationFor<T> where T : class
    {
        protected static ClassUnderTest<T> AutoMocker;

        protected static T ClassUnderTest
        {
            get
            {
                return AutoMocker.Instance;
            }
        }

        protected SpecificationFor()
        {
            AutoMocker = AutoMockFactory.CreateTarget<T>();
        }

        protected SpecificationFor(MockBehavior mockBehavior)
        {
            AutoMocker = AutoMockFactory.CreateTarget<T>(mockBehavior);
        }
    }
}