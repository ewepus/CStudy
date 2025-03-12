namespace AndOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // целое число
            var b = (20, "hello"); // кортеж из 2-х элементов

            if (a is >= 5 and <= 15)
                Console.WriteLine("Значение в интервале [5, 15]");
            else if (a is < 5 or > 15)
                Console.WriteLine("Значение вне интервала [5, 15]");

            if (b is not (_, "hello"))
                Console.WriteLine("Второй элемент кортежа не равен \"hello\"");


            PersonProcessing(new Person());
        }
        private static void PersonProcessing(Person person)
        {
            if (person is { Name: "John", Age: 53 })
                Console.WriteLine("VIP");
            else
                Console.WriteLine("Not VIP");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
