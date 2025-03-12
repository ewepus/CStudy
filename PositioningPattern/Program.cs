namespace PositioningPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(-123, 23, 5);
            Console.WriteLine(GetCircleCenterQuadrantSwitchCase(circle));
            Console.WriteLine(GetCircleCenterQuadrantSwitch(circle));
            
        }
        static string GetCircleCenterQuadrantSwitchCase(Circle circle)
        {
            var result = string.Empty;
            switch (circle)
            {
                case ( > 0, > 0, _): result = "I"; break;
                case ( < 0, > 0, _): result = "II"; break;
                case ( < 0, < 0, _): result = "III"; break;
                case ( > 0, < 0, _): result = "IV"; break;
                case (0, 0, _): result = "Center"; break;
            }
            //В примере переменная circle деконструируется в кортеж вида (X, Y, Radius),
            //потом этот кортеж позиционно сравнивается с шаблонами после case'ов.

            return result;
        }

        static string GetCircleCenterQuadrantSwitch(Circle circle) =>
            circle switch
            {
                ( > 0, > 0, _) => "I",
                ( < 0, > 0, _) => "II",
                ( < 0, < 0, _) => "III",
                ( > 0, < 0, _) => "IV",
                (0, 0, _) => "Center",
                _ => "ERROR!"!
            };
    }
    struct Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public void Deconstruct(out int x, out int y, out int radius) =>
            (x, y, radius) = (X, Y, Radius);
    }
}
