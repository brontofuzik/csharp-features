using System;

// Reimplementing an interface in a subclass
// Explicit implementation in the superclass
namespace Example2
{
    public interface IInterface
    {
        void Method();
    }

    public class BaseClass : IInterface
    {
        void IInterface.Method()
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