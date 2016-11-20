using System;

// Implementing interface members virtually
namespace Example1
{
    public interface IInterface
    {
        void Method();
    }

    public class BaseClass : IInterface
    {
        public virtual void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("DerivedClass.Method()");
        }
    }
}