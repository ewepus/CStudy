namespace DateTimeFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            string format = "dd.MM.yyyy HH:mm:ss"; //yyyy/MM/dd HH-mm-ss
            DateTime dateTime = DateTime.ParseExact(s, format, null );
            Console.WriteLine("{0:yyyy/MM/dd HH-mm-ss}", dateTime);
            /*
             17.02.1985 15:44:01
            */
        }
    }
}
