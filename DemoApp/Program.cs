namespace DemoApp;
    internal class Program
    {
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        var p1 = new Person { Name = name, Age = age };
        var p2 = ModifyPersonsName(p1);

        Console.WriteLine($"{p1.Name}, {p1.Age}");
        Console.WriteLine($"{p2.Name}, {p2.Age}");

        Person ModifyPersonsName(Person person) => new Person { Name = $"[{person.Name}]", Age = person.Age };
    }

class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
