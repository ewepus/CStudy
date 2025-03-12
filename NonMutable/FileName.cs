using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            var p = new Point(1, 2); // X = 1, Y = 2

            //p.X = 3; // ОШИБКА! 
            //p.Y = 4; // ОШИБКА! 

            var p1 = new PointNonMutable() { X = 1, Y = 2 };
            var p2 = new PointNonMutable(1, 2);
            //p1.X = 3; // ОШИБКА! 
            //p2.Y = 4; // ОШИБКА! 
        }
    }
    class PointNonMutable
    {
        public readonly string _name;
        public double X { get; init; }
        public double Y { get; init; }

        public PointNonMutable() { }

        public PointNonMutable(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class PersonA
    {
        private string _name;
        private int _age;

        public string GetName() => _name;
        public string SetName(string value) => _name = value;

        public int GetAge() => _age;
        public int SetAge(int value) => _age = value;
    }
    class PersonB
    {
        private string _name;
        private int _age;

        //свойства - методы для работы с полями
        public string Name
        {
            get => _name;
            set
            {
                if (value == null || value == string.Empty)
                    throw new ArgumentException("value can't be null or empty");

                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("value must be >= 0");

                _age = value;
            }
        }
        class Line
        {
            public double X0 { get; set; }
            public double X1 { get; set; }

            public double Y0 { get; set; }
            public double Y1 { get; set; }

            public double Length
            {
                get => Math.Sqrt(Math.Pow(X1 - X0, 2) + Math.Pow(Y1 - Y0, 2));
            }
        }
    }
}
