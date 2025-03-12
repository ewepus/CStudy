namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enum s = TypeOS.Windows;
            Season ss; //default Spring
            Season sss = Season.Summer;
            var ssss = Season.Winter;

            Season season;
            int seasonNumber;

            season = Season.Winter; //Winter
            seasonNumber = (int)season; //3
            season -= 2; //Summer
            seasonNumber = (int)season; //1


            // GetUnderlyingType
            var type = Enum.GetUnderlyingType(typeof(Season));
            Console.WriteLine(type); // System.Int32

            // Parse
            var s1 = Enum.Parse(typeof(Season), "Winter");
            Console.WriteLine(s1); // Winter

            // ToString
            var s2 = Season.Autumn;
            var s2Str = s2.ToString();
            Console.WriteLine(s2Str); // Autumn

            // ToObject
            var s3 = Enum.ToObject(typeof(Season), 2);
            Console.WriteLine(s3); // Autumn

            // IsDefine
            var isDef2 = Enum.IsDefined(typeof(Season), 2); // true
            var isDef5 = Enum.IsDefined(typeof(Season), 5); // false

            string? name = Enum.GetName(typeof(Season), 1); //Summer
            string[] names = Enum.GetNames(typeof(Season)); //Spring Summer Autumn Winter
            Season season1 = Season.Spring;
            string? nameByEnum = Enum.GetName<Season>(season1); //Spring
            string[] namesByEnum = Enum.GetNames<Season>();// Spring Summer Autumn Winter
            Season[] v1 = (Season[]) Enum.GetValues(typeof(Season));// Spring Summer Autumn Winter
            Season[] v2 = Enum.GetValues<Season>();// Spring Summer Autumn Winter

            Months summerMonths = Months.June | Months.July | Months.August;
            Console.WriteLine($"Летние месяцы: {summerMonths}"); // Летние месяцы: June, July, August
            Months summerAndAutumn = summerMonths | Months.September | Months.October | Months.November;
            Console.WriteLine($"Осенние месяцы: {summerMonths ^ summerAndAutumn}"); // Осенние месяцы: September, October, November
        }
        static string WorkAtDay(Season season) =>
            season switch
            {
                Season.Spring => "Весна",
                Season.Summer => "Лето",
                Season.Autumn => "Осень",
                Season.Winter => "Зима"
            };
    }
    enum TypeOS
    {
        Windows, //default 0
        Linux,   //default 1
        MacOS    //default 2
    }
    
    enum Season
    {
        Spring,Summer,Autumn,Winter
    }

    [Flags]
    enum Months
    {
        January = 2,
        February = 4,
        March = 8,
        April = 16,
        May = 32,
        June = 64,
        July = 128,
        August = 256,
        September = 512,
        October = 1024,
        November = 2048,
        December = 4096,
    }
}
