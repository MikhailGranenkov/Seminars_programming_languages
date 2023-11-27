/*
Виды трансляций:
 - Компиляций(C#, C++, C, Paskal...)
 - Интерпретация(Python, Javascript)


C#(Статическая типизация данных): int n = 10; -> [10]

Python(динамическая типизация данных): n = 10 -> class <'int'> -> [10]

*/

// Ввод и вывод данных
// Console.Clear(); //  Очистка консоли
// Console.Write("Hello, world! "); // Строки внутри C# обрамляютмя двойными кавычками!!!
// Console.Write("Ivan\n"); // \n - принудительный перенос на новую строку
// Console.WriteLine("Hello Ivan!");
// Console.WriteLine("Hello Ivan!");
// Write - написать данные в консоль
// Read - считать данные из консоли

// Console.Write("Введите имя: ");
// string name = Console.ReadLine()!;
// Console.WriteLine($"Привет, {name}!"); // форматированный вывод данных


// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!); // быстрее
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!); // double
// // int m = Convert.ToInt32(Console.ReadLine());
// // "456" -> 456 -> n = 456
// Console.WriteLine($"{n} + {m} = {n + m}");
// Console.WriteLine($"{n} - {m} = {n - m}");
// Console.WriteLine($"{n} * {m} = {n * m}");
// Console.WriteLine($"{n} : {m} = {n / m} (ост. {n % m})");


// Задача 1
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// // = - действие присвоение значения
// // == - проверка на равенство
// // != - проверка на неравенство
// if (m * m == n) // ; ЗАПРЕЩЕНО
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Фигурные скобки нужно ставить, когда внутри конструкции выполняется 2 или более строчки  


// int n = int.Parse("231");
// "231" -> ["231"] -> 231 -> [231]


// Задача 2(версия 1)

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // for(begin, condition, step)
// // 1 повторение = 1 итерация
// for(int i = -n; i <= n; i++) // i = (-1) * n  i++ <-> i = i + 1 
//     Console.Write($"{i} "); // i + " "
/*
1: i = -2
        |
        -2
2:    i++ <-> i = -2 + 1 = -1
                         |
                         -1
3:                        i++ <-> i = -1 + 1 = 0
                                              |
                                              0
                                              ...
                                              |
                                              2
                                              |
                                              i++ <-> i = 2 + 1 = 3(проверку условия не прошла)
*/
// break <-> метод флажка


// Задача 2(версия 2)
/* начало комментария
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = -n;
while (i <= n){
    Console.Write($"{i} ");
    i++;
}
конец комментария */



// Задача 3

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
//  456 : 10 = 45(ост. 6)
// 456 : 100 = 4(ост. 56)
int n3 = n % 10;
int n1 = n / 100;
Console.Write(n1 + n3);