// Программа выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10,100);
// System.Console.WriteLine(number);

// if (number/10>number%10)
// {
//     System.Console.WriteLine(number/10);
// }
// else
// {
//     System.Console.WriteLine(number%10);
// }

//Написать программу, которая выодит случайное трехзначное число и удаляет вторую цифру этого числа

// int number = new Random().Next(100,1000);
// System.Console.WriteLine(number);

// int A = number/100;
// System.Console.Write(A);
// int B = number%10;
// System.Console.Write(B);

// Программа приимает два числа и выводит, является ли второе число кратным первому, при наличии выводит остаток.

// System.Console.WriteLine("Введите первое число ");
// int A = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ");
// int B = int.Parse(Console.ReadLine());
// int x = A%B;
// if (x == 0)
// {
// System.Console.WriteLine("кратно");
// }
// else
// {
//     System.Console.WriteLine("остаток равен " + x);
// }

//Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// System.Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());

// if (a % 7 == 0 && a % 23 == 0)
// {
// System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

// Программа принимает на вход два числа и проверяет, явлется ли одно квадратом другого (как 1 по отношению к 2, так и 2 к 1)

// System.Console.WriteLine("Введите первое число");
// int a = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int b = int.Parse(Console.ReadLine());
// if (a * a == b || b * b == a)
// {
// System.Console.WriteLine("Да");
// }
// else
// {
// System.Console.WriteLine("Нет");
// }

