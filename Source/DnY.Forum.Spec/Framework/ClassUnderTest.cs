namespace DnY.Forum.Framework
{
    using Moq;

    public class ClassUnderTest<TClass> where TClass : class
    {
        readonly AutoMockContainer _container;

        public ClassUnderTest(AutoMockContainer container)
        {
            _container = container;
        }

        public AutoMockContainer Container
        {
            get { return _container; }
        }

        /// <summary>
        /// Gets an instance of the ClassUnderTest with mock objects (or stubs) pushed in for all of its dependencies
        /// </summary>
        public TClass Instance
        {
            get { return _container.Create<TClass>(); }
        }

        /// <summary>
        /// Gets the mock object for type T that would be injected into the constructor function of the ClassUnderTest
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Mock<T> Get<T>() where T : class
        {
            return _container.GetMock<T>();
        }

        /// <summary>
        /// Resolves a required service of the given type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Mock<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}