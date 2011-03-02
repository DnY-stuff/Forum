namespace DnY.Forum.Framework
{
    using Moq;

    public static class AutoMockFactory
    {
        /// <summary>
        /// Default mock type is Loose
        /// </summary>
        public static ClassUnderTest<TClass> CreateTarget<TClass>() where TClass : class
        {
            return CreateTarget<TClass>(MockBehavior.Default);
        }

        public static ClassUnderTest<TClass> CreateTarget<TClass>(MockBehavior mockBehavior) where TClass : class
        {
            return new ClassUnderTest<TClass>(new AutoMockContainer(new MockRepository(mockBehavior)));
        }
    }
}