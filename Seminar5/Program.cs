// Строки
// Ivan
// 0123
// Console.Clear();
// string name = "Ivan"; // String
// // name[1] - char
// char m = '5';
// Console.WriteLine(name[1]);
// Напишите программу, которая принимает на вход число. Посчитайте сумму цифр этого числа
// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!; // "234567"
// int result = 0;
// for (int i = 0; i < number.Length; i++){
//     result += Convert.ToInt32(number[i].ToString());
//     // number[i] - char
//     // number[i].ToString() - string
//     // Convert.ToInt32(number[i].ToString()) - ineteger
// }
// Console.WriteLine($"Сумма цифр числа: {result}");


// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// void InputArray(int[] array){
//     for (int i = 0; i < 10; i++){
//         array[i] = new Random().Next(-10, 11); // [-10; 10]
//     }
// }


// int evenNumbers(int[] array){
//     int count = 0;
//     foreach (int el in array){
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


// Задача 4**(не обязательно): 
// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.   

// Console.Clear();
// int number = new Random().Next(1, 100001);
// int n = number;
// int count = 0;
// while (n > 0){
//     n /= 10;
//     count++;
// }
// Console.WriteLine(number);
// // Console.WriteLine(count);
// int[] array = new int[count];
// while (count > 0){
//     array[count - 1] = number % 10;
//     number /= 10; //  234567 : 10 = 23456
//     count--; // count = count - 1
// }
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

// Задача 1
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// void InputMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 31);
//         }
//     }
// }


// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// void replaceMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i, j] = matrix[i, j] * matrix[i, j];
//         }   
//     }
//     /*
//     i = 0 j = 0, 2, 4, 6 ...
//     i = 2 j = 0, 2, 4, 6 ...
//     i = 4 j = 0, 2, 4, 6 ...
//     */
// }


// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// /*
// 1(Console.ReadLine()!). "4 5"
// 2(STRING.Split(" ")). ["4", "5"]
// 3(Select(x => int.Parse(x))). 4 5
// 4(ToArrat()). [4, 5]
// */
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// replaceMatrix(matrix);
// Console.WriteLine("Конечный массив: ");
// PrintMatrix(matrix);


// Задача 2


// void InputMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 31);
//         }
//     }
// }


// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// int summaElement(int[,] matrix){
//     int result = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 result += matrix[i, i];
//         }   
//     }
//     return result;
// }


// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine($"Сумма элементов главной диагонали: {summaElement(matrix)}");


// Задача 3


void InputMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}


void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


double[] AVG(int[,] matrix){
    double[] avg_array = new double[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        double summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];
        }
        avg_array[i] = summa / matrix.GetLength(1);
    }
    return avg_array;
}


Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine($"Среднее арифметическое строк: [{string.Join(", ", AVG(matrix))}]");