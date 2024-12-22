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
            if (person.Age.HasValue) return person.Age.Value;
            return -1;
        }

        class Person
        {
            public string Name { get; set; } = string.Empty;
            public int? Age { get; set; }
        }
    }
}
