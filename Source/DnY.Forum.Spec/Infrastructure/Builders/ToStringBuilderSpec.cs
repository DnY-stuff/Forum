namespace DnY.Forum.Infrastructure.Builders
{
    using Log;
    using Machine.Specifications;

    [Subject(typeof(ToStringBuilder), "call ReflectionToString"), Tags("Infrastructure")]
    public class when_given_null_object
    {
        Establish context = () => obj = null;

        Because of = () => objString = ToStringBuilder.ReflectionToString(obj);

        It should_not_return_null = () => objString.ShouldNotBeNull();
        It should_return_a_string_containing_null_information = () => objString.ShouldNotBeEmpty();
        It should_return_a_string_and_it_is = () => { if (logger.IsInfoEnabled) logger.Info(objString); };

        public static readonly ILog logger =
            LogFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static object obj;
        private static string objString;
    }

    [Subject(typeof(ToStringBuilder), "call ReflectionToString"), Tags("Infrastructure")]
    public class when_given_a_object_includes_property_that_is_not_null
    {
        Establish context = () =>
                                {
                                    propertyValue = 100;
                                    obj = new TestObject(propertyValue);
                                };

        Because of = () => objString = ToStringBuilder.ReflectionToString(obj);

        It should_return_a_string_containing_the_property = () => objString.ShouldContain(propertyValue.ToString());
        It should_return_a_string_and_it_is = () => { if (logger.IsInfoEnabled) logger.Info(objString); };

        public static readonly ILog logger =
            LogFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static int propertyValue;
        private static object obj;
        private static string objString;
    }

    [Subject(typeof(ToStringBuilder), "call ReflectionToString"), Tags("Infrastructure")]
    public class when_given_a_derived_object
    {
        Establish context = () =>
                                {
                                    propertyValueOfType = 100;
                                    propertyValueOfSuperType = 999;
                                    obj = new TestSubObject(propertyValueOfType, propertyValueOfSuperType);
                                };

        Because of = () => objString = ToStringBuilder.ReflectionToString(obj);

        It should_return_a_string_containing_the_property = () => objString.ShouldContain(propertyValueOfType.ToString());
        It should_return_a_string_containing_the_type_string = () => objString.ShouldContain(typeof(TestSubObject).ToString());
        It should_return_a_string_containing_the_property_of_supertype = () => objString.ShouldContain(propertyValueOfSuperType.ToString());
        It should_return_a_string_and_it_is = () => { if (logger.IsInfoEnabled) logger.Info(objString); };

        public static readonly ILog logger =
            LogFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static int propertyValueOfType;
        private static int propertyValueOfSuperType;
        private static object obj;
        private static string objString;
    }

    #region << Test Classes >>

    public class TestObject
    {
        protected int a;
        public TestObject() {}

        public TestObject(int a)
        {
            this.a = a;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public int getA()
        {
            return a;
        }
    }

    public class TestSubObject : TestObject
    {
        private int b;

        public TestSubObject()
            : base(0) {}

        public TestSubObject(int a, int b)
            : base(a)
        {
            this.b = b;
        }

        public override bool Equals(object o)
        {
            if (o == this)
            {
                return true;
            }
            if (!(o is TestSubObject))
            {
                return false;
            }
            var rhs = (TestSubObject) o;
            return base.Equals(o) && (b == rhs.b);
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int getB()
        {
            return b;
        }
    }

    #endregion
}