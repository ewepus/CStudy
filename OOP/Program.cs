namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 123;
            Console.WriteLine(value.IsPositive());

            var pw = new PersonWorker();
            pw.PrintPersonInfo("John", 21);
            pw.PrintPersonInfo(name: "John", age: 21);
            pw.PrintPersonInfo(age: 21, name: "John");

            // count = 5, label = "test", flag = true
            pw.Method(5, "test", true);
            // count = 5, label = "warn", flag = false
            pw.Method(5, "warn");
            // count = 5, label = "", flag = true
            pw.Method(5, flag: true);
            // count = 5, label = "", flag = false
            pw.Method(5);


            var data = new double[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(AvrCalc(data)); // 3
            Console.WriteLine(AvrCalc(1, 2, 3)); // 2
            Console.WriteLine(AvrCalc()); // 0
        }
        public static double AvrCalc(params double[] data)
        {
            if (data.Length == 0)
                return 0;

            var tmp = 0.0;

            foreach (var x in data)
                tmp += x;

            var result = tmp / data.Length;

            return result;
        }
    }
    static class IntExtensions
    {
        public static bool IsPositive(this int value) =>
            value >= 0;
    }
    public class PersonWorker
    {
        public string PrintPersonInfo(string name, int age) =>
            $"Name: {name}, Age: {age}";
        public void Method(int count, string label = "", bool flag = false)
        {
            Console.WriteLine(count + label + flag);
        }
    }
    class MyClass { }

    interface IMyInterface { }

    struct MyStruct { }

    record MyRecord();

    abstract class MyAbstarctClassBase { }
    class PointV3
    {
        private readonly int _x = 0;
        private readonly int _y = 0;

        // readonly-полям можно задать значение в конструкторе
        public PointV3(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX() => _x;

        // Ошибка! Полю _x нельзя присваивать значение
        // public int SetX(int value) => _x = value; 
        public int GetY() => _y;
    }
}
