namespace KeywordNewInMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ch = new ChildClass();
            ch.OwnBaseMethod(); // OwnBaseMethod() in ChildClass
            ch.VirtualMethod(); // VirtualMethod() in ChildClass

            BaseClass bc = ch;
            bc.OwnBaseMethod(); // OwnBaseMethod() in BaseClass
            bc.VirtualMethod(); // VirtualMethod() in ChildClass
        }
    }
    class BaseClass
    {
        public void OwnBaseMethod() =>
            Console.WriteLine("OwnBaseMethod() in BaseClass");

        public virtual void VirtualMethod() =>
            Console.WriteLine("VirtualMethod() in BaseClass");
    }

    class ChildClass : BaseClass
    {
        public new void OwnBaseMethod() =>
            Console.WriteLine("OwnBaseMethod() in ChildClass");

        public override void VirtualMethod() =>
            Console.WriteLine("VirtualMethod() in ChildClass");
    }
}
