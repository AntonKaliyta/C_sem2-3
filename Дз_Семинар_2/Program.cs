// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// System.Console.WriteLine("Введите трехначное число");
// int a = int.Parse(Console.ReadLine());
// if (a >= 1000 || a <= 99)
// {
//     System.Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число");
// }
// else
// {
//     int result = (a - (a / 100) * 100 - (a % 10))/10;
//     System.Console.WriteLine(result);
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(не решена)

// System.Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a > -100 && a < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (a > 1000 || a < -1000)
//     {
//         a = a / 10;
//     }
//     int result = a % 10;
//     System.Console.WriteLine(result);
// }



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


System.Console.WriteLine("Введите цифру");
int day = int.Parse(Console.ReadLine());

if (day < 8 && day > 0)
{
    if (day > 5)
    {
    System.Console.WriteLine("Да");
    }
    else
    {
    System.Console.WriteLine("Нет");
    }   
}
else
{
  System.Console.WriteLine("Введите день недели(1-7)");  
}