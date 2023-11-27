// Семинар 2
// Алгебра Логики(Булевская Алгебра) - 0(False) или 1(True)
// Алфавит десятичной СС: 0 1 2 3 4 5 6 7 8 9
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = 8 ->       1 * 1 = True
// n = 18 ->      1 * 0 = False
// Console.WriteLine(n > 3 && n < 15);  // ???
// n = 18 ->  1 * (0 + 1) = 1 * 1 = True
// 0 + 1 = 1
// 1 + 1 = 1
// 0 + 0 = 0
// Console.WriteLine(n > 3 && (n < 15 || n % 2 == 0));
// bool(Boolean) - True or False
// if (n > 10) == True
//    n *= 2;

// &&(and) - конъюнкция(логическое умножение)
// ||(or) - дизъюнкция(логическое сложение)


// Задание 1
// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999){ // 23 < 100 || 23 > 999 -> 1 + 0 = 1
//     Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
/*
a = 256 => 26
a = 891 => 81
*/  
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3 * 1);


// Задание 2

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999){
//     Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// // 385 : 10 = 38 (ост. 5)
// // 38 : 10 = 3 (ост. 8)
// int n2 = (n / 10) % 10;
// int n3 = n % 10, result = 1;
// // 1 * n2 * n2... * n2
// //       n3 раз
// for (int i = 1; i <= n3; i++){
//     result = result * n2;
// }
// // n = 345, n2 = 4, n3 = 5
// // 1: result = 1 * 4 = 4
// // 2: result = 4 * 4 = 16
// // 3: result = 16 * 4 = 64
// // 4: result = 64 * 4 = 256
// // 5: result = 256 * 4 = 1024
// Console.WriteLine($"{n2}^{n3} = {result}");


// Задание 3
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int firstNumber = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int secondNumber = int.Parse(Console.ReadLine()!);
// if (firstNumber % secondNumber == 0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine($"нет, {firstNumber % secondNumber}");



// Задание 4
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
number = Math.Abs(number); // модуль числа |-5| = 5
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else{
    Console.WriteLine(number % 1000 / 100);
}
// 456 -> 4
// 3129 -> 1
// 59602 -> 6
// 123456 -> 4
// 9012381 -> 3
// % 100 -> 99(max)
// n % 1000 -> 999(max)
// |int| < 2175......