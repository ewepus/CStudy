using System.Text.Json;

namespace PersonAge
{
    internal class PersonAge
    {
        static void Main(string[] args)
        {
            var json = Console.ReadLine();
            var person = JsonSerializer.Deserialize<Person>(json);

            Console.WriteLine(GetPersonAge(person));
        }

        static int GetPersonAge(Person person)
        {
            int age = person.Age ?? -1;
            return age;
        }

        class Person
        {
            public string Name { get; set; } = string.Empty;
            public int? Age { get; set; }
        }
    }
}
