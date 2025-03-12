namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();
            int i = 0;
            while (i < input.Length)
            {
                char letter = input[i];
                string strNum = "" + input[i + 1];
                int num = int.Parse(strNum);
                Console.Write(new string(letter, num));
                i += 2;
            }


            string[] inp = Console.ReadLine().Split(" ");
            int sum = 0;
            foreach (string str in inp)
            {
                int num = int.Parse(str);
                sum += num;
            }


            string[] sa1 = Console.ReadLine().Split(" ");
            string[] sa2 = Console.ReadLine().Split(" ");

            int[] na1 = new int[sa1.Length];
            int[] na2 = new int[sa2.Length];
            int[] sumArr = new int[Math.Max(na1.Length, na2.Length)];

            for (int j = 0; j < sa1.Length; j++) na1[j] = int.Parse(sa1[j]);
            for (int j = 0; j < sa2.Length; j++) na2[j] = int.Parse(sa2[j]);

            for (int j = 0; j < Math.Min(na1.Length, na2.Length); j++) sumArr[j] = na1[j] + na2[j];

            for (int j = 0; j < sumArr.Length; j++)
            {
                if (sumArr[j] == 0)
                {
                    if (na1.Length > na2.Length)
                    {
                        sumArr[j] = na1[j];
                    }
                    else if (na1.Length < na2.Length)
                    {
                        sumArr[j] = na2[j];
                    }

                }
            }
            Console.WriteLine(string.Join(" ", sumArr));*/


            var msg = string.Empty;
            int numInput = int.Parse(Console.ReadLine());

            string[] names = Enum.GetNames(typeof(SomeEnum));
            for (int i = 0; i < names.Length; i++)
            {
                string? name = Enum.GetName(typeof(SomeEnum), i);
                msg += "" + name[numInput];
            }
            Console.WriteLine(msg);
        }
    }
    enum SomeEnum
    {
        Abcde,
        Fghij,
        Klmno,
        Pqrst,
        Uvwxy
    }
}
