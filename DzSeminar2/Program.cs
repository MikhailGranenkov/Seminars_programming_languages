//Задача 1
// int x = Convert.ToInt32(Console.Read());
// if (x % 7 == 0 && x % 23 == 0) Console.Writeline($"Число {X} кратно одновременно 7 и 23.");
// else
// {
//     Console.Writeline($"Число {X} НЕ кратно одновременно 7 и 23.");
// }
// Пчему то постоянно говорит что Не кратно.

// Рабочее решение
//Console.WriteLine((int.Parse(Console.ReadLine()!) % 161 == 0) ? "Число кратно одновременно 7 и 23." : "Число НЕ кратно одновременно 7 и 23.");



//Задача 2
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите координаты точки (X и Y):");

//         // Ввод координат с клавиатуры
//         Console.Write("Введите X: ");
//         double x = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите Y: ");
//         double y = Convert.ToDouble(Console.ReadLine());

//         // Проверка условия X ≠ 0 и Y ≠ 0
//         if (x == 0 || y == 0)
//         {
//             Console.WriteLine("Ошибка: X и Y должны быть не равны нулю.");
//         }
//         else
//         {
//             // Определение четверти
//             int quadrant = DetermineQuadrant(x, y);

//             // Вывод результата
//             Console.WriteLine($"Точка находится в {quadrant} четверти.");
//         }
//     }

//     // Метод для определения номера координатной четверти
//     static int DetermineQuadrant(double x, double y)
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



//Задача 3
// Console.Write("Введите число от 10 до 99: ");
// int number = int.Parse(Console.ReadLine()!);
// while (number < 10 || number > 99)
// {
//     Console.Write("Вы ввели неверное число!\nВведите число от 10 до 99: ");
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



//Задача 4
// РЕШЕНИЕ 1 Не выводит запятую на последнем числе
// Console.Write("Введите любое натуральное число: ");
// string inputNum = (Console.ReadLine()!);
// int number = int.Parse(inputNum);
// string outNumLine = string.Empty;
// int count = 0;
// while (count < number)
// {
//     outNumLine = outNumLine + count + ",";
//     count = count + 1;
// }
// Console.WriteLine(outNumLine + number);

// РЕШЕНИЕ 2 СДЕЛАЛ С ПРИМЕРА ИЗ СЕМИНАРА 1, ТАМ СЧИАЛИ ОТ -n ДО n.
// Console.Write("Введите любое натуральное число: ");
// int number = int.Parse(Console.ReadLine()!);
// for (int i = 0; i <= number; i++)
//     Console.Write($"{i},");

// РЕШЕНИЕ 3 СДЕЛАЛ С ПРИМЕРА ИЗ СЕМИНАРА 1, ТАМ СЧИАЛИ ОТ -n ДО n.
// Console.Write("Введите любое натуральное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int i = 0;
// while (i <= number)
// {
//     Console.Write($"{i},");
//     i++;
// }
// Так и не понял как сделать что бы счтило и отрицательные числа(