namespace Interfaces
{
    internal class MainClass 
    {
        static void Main(string[] args)
        {
            var p1 = new Point() { X = 1, Y = 2 };
            var p2 = new Point() { X = 1, Y = 2 };
            var p3 = new Point() { X = 3, Y = 4 };
            Point? p4 = null;
            Console.WriteLine(p1 == p2); // False
            Console.WriteLine(p1.Equals(p2)); // True
            Console.WriteLine(p1.Equals(p3)); // False
            Console.WriteLine(p1.Equals(p4)); // False

            var mp = new MyPrinter();
            mp.PrintToConsole("Hello!"); // Hello
            IPrinter printer = (IPrinter)mp;
            printer.PrintToConsole("Test printer"); // Test printer

            var mpe = new MyPrinterExplicit();
            // Ошибка!
            // mpe.PrintToConsole("Hello!");
            ((IPrinter)mpe).PrintToConsole("Test"); // Test

            var cp = new ConsolePrinter();
            ((IPrinterV1)cp).Print("Test"); // PrinterV1: Test
            ((IPrinterV2)cp).Print("Test"); // PrinterV2: Test
        }
    }
}
