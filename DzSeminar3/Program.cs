// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90]


// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//     }
//     return array;
// }

// void PrintArray(int[] InMass)
// {
//     Console.Write("Массив с элементами: ");
//     for(int i = 0; i < InMass.Length; i++)
//     {
//         Console.Write(InMass[i] + " ");
//     }
// }

// void Filter(int[] num) 
// { 
//     int[] n = new int[num.Length];
//     Console.WriteLine(); 
//     Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: "); 

//     for (int i = 0; i < num.Length; i++) 
//     { 
//         if (num[i] >= 20 && num[i] <= 90) 
//         { 
//             Console.Write(num[i] + " ");
//             n[i] = num[i];
//         } 
//     }
//     int countWithoutZeros = n.Count(x => x != 0);
//     Console.WriteLine();
//     Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {countWithoutZeros}");
// }

// int sizeMass = 10;
// int[] mass = FillArray(sizeMass);
// PrintArray(mass);
// Filter(mass);

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < 10; i++)
//     {
//         array[i] = new Random().Next(-10, 11); // [-10; 10]
//     }
// }


// int evenNumbers(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el % 2 == 0)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// int[] array = new int[10];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {evenNumbers(array)}");


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


// // Задаём случайные числа
// Random random = new Random();

// // Генерируем случайный массив вещественных чисел
// int arraySize = 10; // Задаём размер массива
// double[] realNumbers = new double[arraySize];

// for (int i = 0; i < arraySize; i++)
// {
//     // Генерация случайных вещественных чисел от 1 до 10 с ненулевыми дробными частями
//     realNumbers[i] = Math.Round(random.NextDouble() * 9 + 1, 2);
// }

// // Находим максимальный и минимальный элементы
// double max = realNumbers[0];
// double min = realNumbers[0];

// foreach (double number in realNumbers)
// {
//     if (number > max)
//     {
//         max = number;
//     }

//     if (number < min)
//     {
//         min = number;
//     }
// }

// // Вычисляем разницу
// double difference = max - min;


// Console.WriteLine($"Сгенерированный массив: [{string.Join(", ", realNumbers)}]");
// Console.WriteLine($"Максимальный элемент: {max}");
// Console.WriteLine($"Минимальный элемент: {min}");
// Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");


// Задача 4**(не обязательно): 
// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.   

// Console.Clear();
// int number = new Random().Next(1, 100001);
// int n = number;
// int count = 0;
// while (n > 0)
// {
//     n /= 10;
//     count++;
// }
// Console.WriteLine(number);
// int[] array = new int[count];
// while (count > 0)
// {
//     array[count - 1] = number % 10;
//     number /= 10;
//     count--; 
// }
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");