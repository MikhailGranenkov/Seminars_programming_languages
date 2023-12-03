// Задача 1
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.


// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число n: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n % 7 == 0 && n % 23 == 0)
//         {
//             Console.WriteLine("да, кратно");
//         }
//         else
//         {
//             Console.WriteLine("нет, не кратно");
//         }
//     }
// }




// Задача 2
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите координаты точки (X и Y):");

//         // Вводим координаты
//         Console.Write("Введите X: ");   
//         double x = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите Y: ");
//         double y = Convert.ToDouble(Console.ReadLine());

//         // Проверка что X ≠ 0 и Y ≠ 0
//         if (x == 0 || y == 0)
//         {
//             Console.WriteLine("X и Y не должны быть равны нулю.");
//         }
//         else
//         {
//             // Определение четверти
//             int quarter = DefinitionQuarter(x, y);

//             // Печать результата
//             Console.WriteLine($"Точка находится в {quarter} четверти.");
//         }
//     }

//     // Метод определения номера координатной четверти
//     static int DefinitionQuarter(double x, double y)
//     {
//         if (x > 0 && y > 0)
//         {
//             return 1;
//         }
//         else if (x < 0 && y > 0)
//         {
//             return 2;
//         }
//         else if (x < 0 && y < 0)
//         {
//             return 3;
//         }
//         else
//         {
//             return 4;
//         }
//     }
// }



// Задача 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.


// Console.Write("Введите число от 10 до 99: ");
// int number = int.Parse(Console.ReadLine()!);
// while (number < 10 || number > 99)
// {
//     Console.Write("Вы ввели неверное число! Введите число от 10 до 99: ");
//     number = int.Parse(Console.ReadLine()!);
// }
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Наибольшая цифра этого числа: " + firstNumber);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра этого числа: " + secondNumber);
// }


// Задача 4
// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.


// Console.Write("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string s = "";
// while (num != 0)
// {
//     s = (num % 10) + "," + s;
//     num /= 10;
// }
// Console.WriteLine(s);
