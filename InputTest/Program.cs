namespace InputTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                result += 1;
                Console.WriteLine(result);
            } else
            {
                Console.WriteLine("Строка не является числом!");
            }
        }
    }
}
