namespace DnY.Forum.Framework.Sample
{
    using System;
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    [Subject(typeof(Class), "Call action do set property"), Tags("Sample.BDDFramework")]
    public class when_given_a_new_class_for_specify_ActionDoSetProperty
    {
        Establish context = () => _class = new Class();

        Because of = () => _class.ActionDoSetProperty();

        It should_set_property = () => _class.Property.ShouldNotBeNull();

        private static Class _class;
    }

    [Subject(typeof(Class), "Call function do return property"), Tags("Sample.BDDFramework")]
    public class when_given_a_new_class_for_specify_FuncDoReturnProperty
    {
        Establish context = () => _class = new Class();

        private Because of = () => _exception = Catch.Exception(() => _class.FuncDoReturnProperty());

        It should_occur_exception = () => _exception.ShouldBeOfType<CannotReturnNullValueException>();

        private static Class _class;
        private static Exception _exception;
    }

    [Subject(typeof(Class), "Call function do return property"), Tags("Sample.BDDFramework")]
    public class when_given_a_new_class_and_set_property_for_specify_FuncDoReturnProperty
    {
        Establish context = () =>
        {
            _class = new Class();
            _class.ActionDoSetProperty();
            _property = _class.Property;
        };

        Because of = () => _returnValue = _class.FuncDoReturnProperty();

        It should_return_a_value_as_not_null_ = () => _returnValue.ShouldNotBeNull();
        It should_return_a_value_equaled_class_property = () => _returnValue.ShouldEqual(_property);

        private static Class _class;
        private static object _returnValue;
        private static object _property;
    }

    public class Class
    {
        protected object _field;

        public object Property
        {
            get { return _field; }
            set { _field = value; }
        }

        public void ActionDoSetProperty()
        {
            Property = new object();
        }

        public object FuncDoReturnProperty()
        {
            if (Property == null)
                throw new CannotReturnNullValueException();

            return Property;
        }
    }

    class CannotReturnNullValueException : ApplicationException { }
}