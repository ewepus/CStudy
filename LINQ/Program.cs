using System.Linq;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //no LINQ SELECT
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int[] b = new int[a.Length];

            for (var i = 0; i < a.Length; i++)
                b[i] = a[i] * a[i];

            Console.WriteLine($"a: {string.Join(' ', a)}");
            Console.WriteLine($"b: {string.Join(' ', b)}");
            //yes LINQ SELECT
            int[] c = { 1, 2, 3, 4, 5, 6 };

            int[] d = c.Select(x => x * x)
                .ToArray();

            Console.WriteLine($"a: {string.Join(' ', c)}");
            Console.WriteLine($"b: {string.Join(' ', d)}");

            //no LINQ WHERE
            int[] e = { 1, -2, 3, -4, 5, -6 };
            var f = new List<int>();

            for (var i = 0; i < e.Length; i++)
            {
                if (e[i] >= 0)
                    f.Add(e[i]);
            }

            Console.WriteLine($"a: {string.Join(' ', e)}");
            Console.WriteLine($"b: {string.Join(' ', f)}");
            //yes LINQ WHERE
            int[] g = { 1, -2, 3, -4, 5, -6 };

            int[] h = g.Where(x => x >= 0)
                .ToArray();

            Console.WriteLine($"a: {string.Join(' ', g)}");
            Console.WriteLine($"b: {string.Join(' ', h)}");

            //no LINQ AGGREGATE
            int[] j = { 1, 2, 3, 4, 5, 6 };

            var sum = 0;
            for (var i = 0; i < j.Length; i++)
            {
                sum += j[i];
            }

            Console.WriteLine($"a: {string.Join(' ', j)}");
            Console.WriteLine($"sum = {sum}");
            //yes LINQ AGGREGATE
            int[] k = { 1, 2, 3, 4, 5, 6 };

            var sum1 = a.Aggregate((x, y) => x + y);

            Console.WriteLine($"a: {string.Join(' ', k)}");
            Console.WriteLine($"sum = {sum1}");
            
            //LINQ FOREACH?
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6};
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
