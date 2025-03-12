using System;

var number1 = int.Parse(Console.ReadLine());
var number2 = int.Parse(Console.ReadLine());
bool? flag = Console.ReadLine() == "null" ? null : true;

var result = AdditionOrSubtraction(number1, number2, flag);
Console.WriteLine(result);

//не относится к программе
bool? nvb1 = null;
bool nvb2 = nvb1 ?? false; //false - дефолт значение, если Nvb1 == null
Console.WriteLine(nvb1); // [пустая строка]
Console.WriteLine(nvb2); // False

int? num = 27;
if (num != null)
{
    var tmp = (int)num + 10;
    Console.WriteLine(tmp);
}

int? num1 = 27;
if (num1 is not null)
{
    var tmp = num1 + 10;
    Console.WriteLine(tmp);
}

int? num2 = 27;
if (num2 is int numValue)
{
    var tmp = numValue + 10;
    Console.WriteLine(tmp);
}

int? num3 = 27;
if (num3 is null)
{
    Console.WriteLine("Value is null");
}
int AdditionOrSubtraction(int num1, int num2, bool? flag)
{
    if(!flag.HasValue) return num1 + num2;
    return num1 * num2;
}