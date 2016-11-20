namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create delegate from a method group. 
            Delegate1 delegate1a = new Delegate1(Function);
            Delegate1 delegate1b = Function;

            // Create delegate from an anonymous method.
            Delegate1 delegate2a = new Delegate1(delegate(int i) { return i.ToString(); });
            Delegate1 delegate2b = delegate(int i) { return i.ToString(); };

            // Create delegate from a lambda exrpession.
            Delegate1 delegate3a = new Delegate1((int i) => { return i.ToString(); });
            Delegate1 delegate3b = (int i) => { return i.ToString(); }; 

            // Create delegate from a value of a delegate type.
            Delegate2 delegate4 = new Delegate2(Function);
            Delegate1 delegate4a = new Delegate1(delegate4);
            Delegate1 delegate4b = delegate4; // Compile-time error.
        }

        delegate string Delegate1(int i);

        delegate string Delegate2(int i);

        public static string Function(int i)
        {
            return i.ToString();
        }
    }
}
