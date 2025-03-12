using System;

var isNumber1 = int.TryParse(Console.ReadLine(), out int number1);
var isNumber2 = int.TryParse(Console.ReadLine(), out int number2);
var isNumber3 = int.TryParse(Console.ReadLine(), out int number3);
if(!(isNumber1 && isNumber2 &&  isNumber3))
{
    Console.WriteLine("Ошибка!");
}
else
{
    int max = Math.Max(number1, number2);
    Console.WriteLine(max = Math.Max(max, number3));
}