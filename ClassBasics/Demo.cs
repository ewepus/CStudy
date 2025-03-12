using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Demo
    {
        // Константа
        public const int Const = 123;

        // Поле
        private string _objectField = string.Empty;
        private static string _staticField = string.Empty;

        // Свойство
        public int Property { get; set; }

        // Метод
        public string Method(string arg)
        {
            return arg + "123";
        }

        // Конструктор экземпляра
        public Demo()
        {
            _objectField = "object's field";
        }

        // Конструктор типа
        static Demo()
        {
            _staticField = "type's field";
        }

        // Типы
        private class SubClass { }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 18;
            int age = person.Age;

            Circle circle1 = new Circle();
            // Примеры приведения к базовому классу
            // up cast
            ShapeBruh fig1 = new Circle();
            ShapeBruh fig2 = circle1;
            // Пример приведения к классу-наследнику
            // down cast
            Circle circle2 = (Circle)fig1;


            var ch1 = new ChildClass();
            Console.WriteLine();
            var ch2 = new ChildClass(7);
        }
    }
    class ShapeBruh 
    {
        public int Color { get; set; }
        //virtual - можно переопределить
        public virtual string GetDescription() =>
        $"Figure with color: {Color}";
    }
    class Circle : ShapeBruh 
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
        public override string GetDescription() =>
        $"Circle: center in ({X}, {Y}), radius: {Radius}, color: {Color}";
    }
    class Person
    {
        private string _name = string.Empty;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
    class SubClass : SuperClass
    {
        public SubClass()
            : base() =>
            Console.WriteLine("SubClass constructor");

        public override void Method()
        {
            base.Method();

            Console.WriteLine("SubClass.Method()");
        }
    }

    class SuperClass
    {
        public SuperClass() =>
            Console.WriteLine("Superclass constructor");

        public virtual void Method() =>
            Console.WriteLine("Superclass.Method()");
    }
    class BaseClass
    {
        private readonly int _value = -1;

        public BaseClass() =>
            Console.WriteLine($"BaseClass: _value = {_value}");

        public BaseClass(int value)
        {
            _value = value;
            Console.WriteLine($"BaseClass: _value = {_value}");
        }

    }

    class ChildClass : BaseClass
    {
        public ChildClass() =>
            Console.WriteLine("Конструктор класса ChildClass");

        // Явный вызов конструктора базового класса с параметром
        public ChildClass(int value)
            : base(value) =>
            Console.WriteLine("Конструктор класса ChildClass");
    }
}
