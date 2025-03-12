using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Class1
    {
        static void Main(string[] args)
        {
            // Создадим несколько объектов класса Object
            object obj1 = new object();
            object obj2 = new object();
            object obj3 = obj1;

            // # Метод GetType()
            // Посмотрим на тип obj1
            Console.WriteLine($"Тип obj1: {obj1.GetType().Name}");
            Console.WriteLine($"Тип obj1: {obj1.GetType().FullName}");

            // Создадим переменную типа int,
            // но ее значение присвоим переменной типа Object
            object intObj = 123;
            // Посмотрим на тип intObj
            Console.WriteLine($"Тип intObj: {intObj.GetType().Name}");

            // # Метод ToString()
            Console.WriteLine($"obj1.ToString(): {obj1.ToString()}");
            // Вариант эквивалентный приведенному выше
            Console.WriteLine($"obj1.ToString(): {obj1}");

            // # Метод Equals()            
            Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");
            Console.WriteLine($"obj1.Equals(obj3): {obj1.Equals(obj3)}");

            // # Метод GetHashCode()            
            Console.WriteLine($"obj1.GetHashCode(): {obj1.GetHashCode()}");
        }
    }
    abstract class Shape
    {
        private readonly int _color = 0;

        public Shape(int color) =>
            _color = color;

        public abstract double Square();
    }
    class Rectangle : Shape
    {
        private readonly int _x;
        private readonly int _y;

        public Rectangle(int x, int y, int color)
            : base(color)
        {
            _x = x;
            _y = y;
        }

        public override double Square() =>
            _x * _y;
    }
}
