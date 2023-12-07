// Рекурсия
// Напишите программу, которая принимает от пользователя 2 числа. 
// Необходимо сложить введенные числа, без прямого сложения.

// int summa(int a, int b){
//     if (b == 0)
//         return a;
//     return summa(a + 1, b - 1);
// }


// Console.Clear();    
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {a} + {b} = {summa(a, b)}");

/*
a = 5 b = 3 S = summa

S(5, 3) -> S(6, 2) -> S(7, 1) -> S(8, 0) -> 8
*/

/*
Задача 1.
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
*/


// int summaCifr(int n){
//     if (n < 10)
//         return n;
//     return summaCifr(n / 10) + n % 10;
// }

/* n = 456 S = summaCifr
S(456) -> S(45) + 6 = 4 + 5 + 6 = 15
            |
            S(4) + 5 = 4 + 5
              |
              4

*/


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // int result = 0;
// // while (n >= 10){ // n < 10 || n % 10 = n || n / 10 == 0
// //     result += n % 10;
// //     n /= 10;
// // }
// // Console.WriteLine(result + n);
// Console.WriteLine(summaCifr(n));


/*
Задача 2.
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
*/
// string printNumbers(int a){
//     if (a == 0) // n == 1
//         return ""; // return "1 "
//     return printNumbers(a - 1) + $"{a} ";
// }
/*
n = 5 P = printNumbers
P(5) -> P(4) + "5 " = "1 2 3 4 " + "5 " =  "1 2 3 4 5 "
        |
        P(3) + "4 " = "1 2 3 " + "4 " = "1 2 3 4 "
        |
        P(2) + "3 " = "1 2 " + "3 " = "1 2 3 "
        |
        P(1) + "2 " = "1 " + "2 " = "1 2 "
        |
        P(0) + "1 " = "" + "1 " = "1 "
        |
        ""
*/


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(n));

/*
Задача 3
Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
*/

// bool checkVowels(char s){
//     char[] c = {'e', 'u', 'i', 'y', 'a', 'o'};
//     foreach (char el in c){
//         if (el == s)
//             return false;
//     }
//     return true;
// }


// string printChars(string s){
//     if (s.Length == 0)
//         return "";

//     string s_new = String.Empty;
//     for (int i = 0; i < s.Length - 1; i++)
//         s_new += s[i];

//     if (checkVowels(s[s.Length - 1])){
//         return printChars(s_new) + $"{s[s.Length - 1]} ";
//     }
//     return printChars(s_new);
// }
/*
s = "hello" P = printChars
P("hello") -> P("hell")
                |
                P("hel") + "l "
                |
                P("he") + "l "
                |
                P("h")
                |
                P("") + "h "
                |
                ""
*/



// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// Console.WriteLine(printChars(initial));