using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Interfuck
    {
    }
    //start
    interface IPrinter
    {
        void PrintToConsole(string msg);
    }

    class MyPrinter : IPrinter
    {
        //неявная реализация
        //можно вызывать методы интерфейса
        public void PrintToConsole(string msg) =>
            Console.WriteLine(msg);
    }
    class MyPrinterExplicit : IPrinter
    {
        //явная реализация
        //нельзя вызывать методы интерфейса
        void IPrinter.PrintToConsole(string msg) =>
            Console.WriteLine(msg);
    }
    //end
    //start
    interface IPrinterV1
    {
        void Print(string msg);
    }

    interface IPrinterV2
    {
        void Print(string msg);
    }

    class ConsolePrinter : IPrinterV1, IPrinterV2
    {
        void IPrinterV1.Print(string msg) =>
            Console.WriteLine($"PrinterV1: {msg}");

        void IPrinterV2.Print(string msg) =>
            Console.WriteLine($"PrinterV2: {msg}");
    }
    //end
    class Point : IEquatable<Point>
    {
        public double X { get; init; }
        public double Y { get; init; }

        // IEquatable<T>
        public bool Equals(Point? other)
        {
            if (other is null)
                return false;

            return X == other.X && Y == other.Y;
        }
    }
    interface IMyCustomInterface
    {
        void Method(); // метод
        int Property { get; set; } // свойство

        static void StaticMethod() { } // статический метод
        static int StaticProperty { get; set; } // статическое свойство
        static int StaticField; // статическое поле
    }
}
