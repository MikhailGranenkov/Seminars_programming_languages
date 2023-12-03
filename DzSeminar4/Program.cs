// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите число, либо введите q для завершения программы:");

//         while (true)
//         {
//             string input = Console.ReadLine();

//             if (input.ToLower() == "q")
//             {
//                 Console.WriteLine("Программа завершена");
//                 break;
//             }
//             if (int.TryParse(input, out int number))
//             {
//                 if (IsEvenSumOfDigits(number))
//                 {
//                     Console.WriteLine($"Сумма чисел {number} чётная! Программа завершена");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Неверный ввод. Пожалуйста, введите правильное целое число или 'q' для выхода!");
//             }
//         }
//     }

//     static bool IsEvenSumOfDigits(int number)
//     {
//         int sum = 0;
//         foreach (char digit in number.ToString())
//         {
//             if (int.TryParse(digit.ToString(), out int digitValue))
//             {
//                 sum += digitValue;
//             }
//         }

//         return sum % 2 == 0;
//     }
// }


// Задача 2:
// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// using System;

// class Program

// {
//     static void Main()
//     {
//         // Задали размер массива
//         int arraySize = 10;

//         // Генерируем массив случайных трёхзначных чисел
//         int[] randomNumbers = GenerateRandomNumbers(arraySize);

//         // Отображаем сгенерированный массив
//         Console.WriteLine("Сгенерированный массив:");
//         DisplayArray(randomNumbers);

//         // Считаем количество чётных чисел в массиве
//         int evenCount = CountEvenNumbers(randomNumbers);
//         Console.WriteLine($"Количество чётных чисел в массиве равно: {evenCount}");
//     }

//     static int[] GenerateRandomNumbers(int size)
//     {
//         Random random = new Random();
//         int[] numbers = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             numbers[i] = random.Next(100, 1000); // Генерируем случайное трёхзначное число
//         }

//         return numbers;
//     }

//     static void DisplayArray(int[] array)
//     {
//         foreach (var number in array)
//         {
//             Console.Write(number + " ");
//         }
//         Console.WriteLine();
//     }

//     static int CountEvenNumbers(int[] array)
//     {
//         int count = 0;

//         foreach (var number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }

//         return count;
//     }
// }


// Задача 3: 
// Напишите программу, которая перевернёт одномерный
// массив (первый элемент станет последним, второй – предпоследним и т.д.)

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите размер массива: ");
//         int arraySize;

//         while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
//         {
//             Console.WriteLine("Ошибка. Введите целое положительное число для размера массива.");
//         }

//         // Генерируем массив случайных чисел
//         int[] randomNumbers = GenerateRandomNumbers(arraySize);

//         Console.WriteLine("Сгенерированный массив:");
//         DisplayArray(randomNumbers);

//         // Переворачиваем массив
//         InvertArray(randomNumbers);

//         Console.WriteLine("Перевёрнутый массив:");
//         DisplayArray(randomNumbers);
//     }

//     static int[] GenerateRandomNumbers(int size)
//     {
//         Random random = new Random();
//         int[] numbers = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             numbers[i] = random.Next(1, 100); // Генерируем случайные двухзначные числа
//         }

//         return numbers;
//     }

//     static void InvertArray(int[] array)
//     {
//         int length = array.Length;
//         for (int i = 0; i < length / 2; i++)
//         {
//             // Меняем местами элементы в позициях i и (длина - 1 - i)
//             int temp = array[i];
//             array[i] = array[length - 1 - i];
//             array[length - 1 - i] = temp;
//         }
//     }

//     static void DisplayArray(int[] array)
//     {
//         foreach (var element in array)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();
//     }
// }



