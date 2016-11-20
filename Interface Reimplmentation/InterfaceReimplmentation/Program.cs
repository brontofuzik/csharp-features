namespace InterfaceReimplmentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            //Example2();
            Example3();
        }

        // Implementing interface members virtually
        private static void Example1()
        {
            Example1.DerivedClass derived = new Example1.DerivedClass();
            derived.Method();                           // DerivedClass.Method()
            ((Example1.IInterface)derived).Method();    // DerivedClass.Method()
            ((Example1.BaseClass)derived).Method();     // DerivedClass.Method()
        }

        // Reimplementing an interface in a subclass
        // Explicit implementation in the superclass
        private static void Example2()
        {
            Example2.DerivedClass derived = new Example2.DerivedClass();
            derived.Method();                           // DerivedClass.Method()
            ((Example2.IInterface)derived).Method();    // DerivedClass.Method()
        }

        // Reimplementing an interface in a subclass
        // Implicit implementation in the superclass
        private static void Example3()
        {
            Example3.DerivedClass derived = new Example3.DerivedClass();
            derived.Method();                           // DerivedClass.Method()
            ((Example3.IInterface)derived).Method();    // DerivedClass.Method()
            ((Example3.BaseClass)derived).Method();     // BaseClass.Method()
        }
    }
}
