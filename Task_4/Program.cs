namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countOfFloors = int.Parse(Console.ReadLine());

            var simpleHouse1 = new SimpleHouse();
            var simpleHouse2 = new SimpleHouse(countOfFloors);

            Console.WriteLine(simpleHouse1.CountOfFloors);
            Console.WriteLine(simpleHouse2.CountOfFloors);
        }
    }
    class SimpleHouse : House
    {
        // TODO: реализуйте конструктор без параметров

        // TODO: реализуйте конструктор с одним параметром: countOfFloors
        public SimpleHouse() : base(1)
        {

        }
        public SimpleHouse(int countOfFloors) : base(countOfFloors)
        {
        }
    }

    abstract class House
    {
        public int CountOfFloors { get; init; }

        public House(int countOfFloors) =>
            CountOfFloors = countOfFloors;
    }
}
