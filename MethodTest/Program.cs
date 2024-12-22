namespace MethodTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            var z = SumOfSquares(x, y);
            Console.WriteLine($"Сумма квадратов чисел {x} и {y} равна: {z}");
        }
        static int SumOfSquares(int x, int y)
        {
            var result = x*x + y*y;
            return result;
        }
    }
}
