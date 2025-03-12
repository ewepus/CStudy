namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] na1;

            int[] na2 = new int[5];

            na1 = new int[5]; //na1[0] = 0

            double[] dada1 = new double[3] { 0.0, 0.2343, 1245.2349 };
            double[] dada2 = { 24.23, 1412.213 };

            var sa1 = new string[3];

            var va1 = new[] { 23, 235.56 };


            int[] na3 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < na3.Length; i++)
            {
                Console.WriteLine(na3[i] + 1);
            }
            foreach(var i in na3)
            {
                Console.WriteLine(i + 1);
            }


            int[] na4 = { 1, 2, 3, 4, 5};
            Console.WriteLine(string.Join(' ', na4)); //1 2 3 4 5
            EditArray(na4);
            Console.WriteLine(string.Join(' ', na4)); //123 2 3 4 5
            static void EditArray(int[] array)
            {
                array[0] = 123;
            }


            double[,] da1 = new double[3, 3]; // массив размера 3x3
            double[,] da2 = { { 1, 2, 3 }, { 4, 5, 6 } }; // массив размера 2x3
            double[,,] da3 = new double[2, 2, 2]; // массив размера 2x2x2
            double[,,] da4 =
            {
                { { 1, 2 }, { 3, 4 } },
                { { 5, 6 }, { 7, 8 } }
            }; // массив размера 2x2x2


            // Создаем двумерный зубчатый массив, 
            // в котором количество рядов равно трём
            int[][] nm1 = new int[3][];
            // Инициализируем ряды массива nm1
            // при этом, каждый следующий ряд на единицу длиннее предыдущего
            for (int i = 0; i < nm1.Length; i++)
                nm1[i] = new int[i + 1];
            // Выведем в консоль содержимое массива nm1
            for (int i = 0; i < nm1.Length; i++)
            {
                for (int j = 0; j < nm1[i].Length; j++) Console.Write($"{nm1[i][j]} ");
                Console.WriteLine();
            }

            int[,] a2d = new int[3, 3]; //Length = 9 Rank = 2 (кол-во измерений)

            int[][] aj1 = new int[3][] { new int[1], new int[2], new int[3] };
            int[][][] aj2 = new int[2][][] { new int[2][] {new int[1], new int[2] }, new int[2][] { new int[1], new int[2] } }; 

        }
    }
}
