using System.Text;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
            string s = new string(charArray); // Hello

            string s1 = "hello";
            string s2 = "hello";
            string s3 = "abc";
            Console.WriteLine(s1 == s2); // True
            Console.WriteLine(s1.Equals(s2)); // True
            Console.WriteLine(s1 == s3); // False
            Console.WriteLine(s1 != s3); // True

            string s4 = string.Concat(s1, s2, s3); //до 4-ёх строк

            string[] sArr1 = { "First ", "Second ", "Third " };
            Console.WriteLine(string.Concat(sArr1)); // First Second Third

            string[] sArr2 = { "First", "Second", "Third" };
            Console.WriteLine(string.Join(" ", sArr2)); // First Second Third
            Console.WriteLine(string.Join("<->", sArr2)); // First<->Second<->Third

            string sosa = "Hello";
            Console.WriteLine("Элемент по индексу 3, sosa[3]: " + sosa[3]); // Элемент по индексу 3, sosa[3]: l

            var so = "26".Insert(1, "[4]");
            Console.WriteLine(so); // 2[4]6

            Console.WriteLine("PadLeft: "); // PadLeft: 
            Console.WriteLine("some string".PadLeft(15)); // "    some string"
            Console.WriteLine("some string".PadLeft(15, '*')); // "****some string"
            Console.WriteLine("PadRight: "); // PadRight
            Console.WriteLine("some string".PadRight(15)); // "some string    "
            Console.WriteLine("some string".PadRight(15, '*')); // "some string****"

            Console.WriteLine("Hello".Remove(2)); // He
            Console.WriteLine("Hello".Remove(2, 2)); // Heo

            Console.WriteLine("Hello, World!".Replace('!', '.')); // Hello, World.
            Console.WriteLine("Hello, World!".Replace("World", "John")); // Hello, John!

            Console.WriteLine("Hello, World!".ToUpper()); // HELLO, WORLD!
            Console.WriteLine("Hello, World!".ToLower()); // hello, world!

            Console.WriteLine("   hello   ".Trim());    // "hello"
            Console.WriteLine("***hello---".Trim('*'));    // "hello---"
            Console.WriteLine("***hello---".Trim(new char[] { '*', '-' }));    // "hello"
            Console.WriteLine("   hello   ".TrimStart());   // "hello   
            Console.WriteLine("   hello   ".TrimEnd()); // "   hello"

            foreach (var i in "1 2 3".Split(' '))
                Console.Write(i); // 123
            Console.WriteLine();
            foreach (var g in "1 2 3-4-5-6".Split(new char[] { ' ', '-' }))
                Console.Write(g); // 123456
            Console.WriteLine();

            string sad = "1 2 3 4 5";
            string[] happy = sad.Split(' ');
            foreach(var h in happy) Console.Write(h);

            Console.WriteLine(@"escape is not work: \a\t\n\x1234"); // escape is not work: \a\t\n\x1234

            //обычная конкатенация
            string outString = "";
            for (int i = 0; i < 10; i++)
                outString += i.ToString() + " - ";
            Console.WriteLine(outString); // 0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 -

            //String Builder
            var seebe = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                seebe.Append(i.ToString());
                seebe.Append(" - ");
            }
            var outString1 = seebe.ToString();
            Console.WriteLine(outString1); // 0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 -

            var sb = new StringBuilder();
            sb.Append("123");
            sb.AppendLine();
            sb.AppendFormat("{0:t} ", DateTime.Now);
            sb.AppendLine();
            sb.AppendJoin("-", new int[] { 1, 2, 3 });
            Console.WriteLine(sb.ToString());

            var stringBuilder = new StringBuilder();
            stringBuilder.Append("0123456789");
            stringBuilder.Insert(3, "abc"); //012abc3456789

            StringBuilder stringBuilder1 = new StringBuilder();
            stringBuilder1.Append("0123456789");
            stringBuilder1.Remove(3, 5); //01289

            StringBuilder stringBuilder2 = new StringBuilder();
            stringBuilder2.Append("123-456-123-456");
            stringBuilder.Replace("123", "abc"); //abc-456-abc-456
        }
    }
}
