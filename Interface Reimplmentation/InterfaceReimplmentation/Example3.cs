using System;

// Reimplementing an interface in a subclass
// Implicit implementation in the superclass
namespace Example3
{
    public interface IInterface
    {
        void Method();
    }

    public class BaseClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }

    public class DerivedClass : BaseClass, IInterface
    {
        public new void Method()
        {
            Console.WriteLine("DerivedClass.Method()");
        }
    }
}