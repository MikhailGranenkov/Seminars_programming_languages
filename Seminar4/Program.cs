// Массивы(Array)

// Список(List) <-> import array
// data = [34, 12.5, "Ivan", True]
// 34 - int
// 12.5 - double
// "Ivan" - string

// int[] array = new int[5];
// int[] array = {34, -10, 23, 9, 8};
// array.Length = 5
// [34, -10, 23, 9, 8]
//  0    1   2   3  4
// Console.WriteLine($"0-й элемент: {array[0]}");
// Console.WriteLine($"1-й элемент: {array[1]}");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine(string.Join(", ", array));


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 11); // [-10, 10]
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n]; // 0.0
// // Random().NextDouble() - (0, 1)
// // от 20 до 30
// // Random().NexDouble() * (end - start) + start;
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(new Random().NextDouble() * (30 - 20) + 20, 2);
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Функции и процедуры

// void test(ref int m) // процедура
// {
//     m = m + 10;
// }


// Console.Clear();
// int n = 7;
// test(ref n);
// Console.WriteLine(n);


// Напишите программу, которая принимает от пользователя 2 числа и возвращает наибольшее из них
// int maxNumber(int a, int b){ // Функция
//     if (a > b)
//         return a;
//     return b; // a <= b
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Наибольшее значение: {maxNumber(n, m)}");



// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(-10, 11); // [-10, 10]
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// inputArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 0){
//     int x = n % 10;
//     Console.Write($"{x}, ");
//     n /= 10;
// }
// 567 : 10 = 56 (ост. 7)
// 567 : 10 = 56

// 56 : 10 = 5(ост. 6)
// 56 : 10 = 5


// Задача 1

// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(1, 101); // [0, 100]
// }

// bool isPrime(int n){
//     for (int i = 2; i <= n / 2; i++){
//         if (n % i == 0)
//             return false;
//     }
//     return true;
// }
// // 9 % 3 = 0
// // 9:3
// // 9:1
// // 9:9
// // int [217]

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Простые числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//     if (isPrime(array[i]) == true)
//         Console.Write($"{array[i]} ");
// }



// Задача 2


// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(0, 101); // [-1000, 1000]
// }


// int isCheck(int[] array){
//     int count = 0;
//     foreach (int element in array){
//         if (element % 10 == 1 && element % 7 == 0)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Резльтат: {isCheck(array)}");


// Задача 3


// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(0, 10); // [0; 9]
// }


// int formingNumber(int[] array)
// {
//     int result = 0;
//     int i = array.Length - 1;
//     foreach (int el in array){
//         result += el * Convert.ToInt32(Math.Pow(10, i));
//         i--;
//     }
//     return result;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 0 || n > 8){
//     Console.Write("Вы ошиблись! Введите число от 0 до 8: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {formingNumber(array)}");
// Console.WriteLine($"Результат: {string.Join("", array)}");