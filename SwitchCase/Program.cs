namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMsgSwitch(0));
            Console.WriteLine(GetMsgSwitchCase(1));
            Console.WriteLine(GetMsg(2));
        }
        static string GetMsgSwitchCase(int status)
        {
            var msg = string.Empty;

            switch (status)
            {
                case 0: msg = "Correct value"; break;
                case 1: msg = "Bad value"; break;
                case 2: msg = "Uncertain value"; break;
                default: msg = "Unknown value"; break;
                    //switch также может использовать тип вместо константы
            }

            return msg;
        }
        static string GetMsgSwitch(int status)
        {
            var msg = status switch
            {
                0 => "Correct value",
                1 => "Bad value",
                2 => "Uncertain value",
                _ => "Unknown value"
            };

            return msg;
        }
        static string GetMsg(int status) => status switch
        {
        0 => "Correct value",
        1 => "Bad value",
        2 => "Uncertain value",
        _ => "Unknown value"
        };
    }
}
