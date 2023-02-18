//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// void dist(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     double distance = (Math.Sqrt((Math.Pow(xb - xa, 2)) + (Math.Pow(ya - yb, 2)) + Math.Pow(zb - za, 2)));
//     System.Console.WriteLine($"Расстояние между точками равно {distance} ");
// }

// System.Console.WriteLine("Введите x первой точки");
// double x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите y первой точки");
// double y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите z первой точки");
// double z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите x второй точки");
// double x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите y второй точки");
// double y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите z второй точки");
// double z2 = Convert.ToInt32(Console.ReadLine());
// dist(x1, y1, z1, x2, y2, z2);

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// System.Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count < n)
// {
//     int x = count*count;
//     Console.Write($"{x}, ");
//     count++;
// }
// int y = count*count;
//     Console.Write($"{y}.");

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// System.Console.WriteLine("Введите пятизначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x >= 100000 || x <= 9999)
// {
//     System.Console.WriteLine("Введите именно пятизначное число");
// }
// else if (x / 10000 == x % 10 && (x / 1000)%10 == (x / 10)%10)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }
// // 