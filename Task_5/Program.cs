namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nm = new NewModule();
            nm.Method();
        }
    }
    class NewModule : BaseModule
    {
        public override void Method()
        {
            base.Method();
            Console.WriteLine("NewModule.Method()");
        }
        // TODO: переопределеите метод Method()
    }

    class BaseModule
    {
        public virtual void Method()
        {
            Console.WriteLine("BaseModule.Method()");
        }
    }
}
