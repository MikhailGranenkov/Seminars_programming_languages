// // Задание 1.
// // Задайте массив символов (тип char []).
// // Создайте строку из символов этого массива.

// Console.Clear();
// // char[] chars = {'a', 'b', 'c', 'd'};
// Console.Write("Введите символы через пробел: ");
// char[] chars = Console.ReadLine()!.Split().Select(i => char.Parse(i)).ToArray();
// /*  
// 1. "a b 1 2 3 4 6 c d e"
// 2. ["a", "b", "1", "2", "3", "4", "6", "c", "d", "e"]
// 3. 'a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e'
// 4. ['a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e']
// */
// string result = string.Empty; // создание пустой строки
// // string result = "";
// foreach (char element in chars){
//     result = result + element;
// }
// Console.WriteLine(result);



// Задание 2
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’] 

// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = new char[initial.Length];
// // Hello
// // 01234
// for (int i = 0; i < initial.Length; i++){
//     chars[i] = initial[i];
// }
// Console.WriteLine($"Результат: [{string.Join(" ", chars)}]");


// Задание 3
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// bool is_vowels(char el, char[] chars){
//     foreach (char x in chars){
//         if (x == el)
//             return true;
//     }
//     return false;
// }


// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = {'a', 'e', 'u', 'i', 'o', 'y'};
// int count = 0;
// for (int i = 0; i < initial.Length; i++){
//     if (is_vowels(initial[i], chars))
//         count++;
// }
// Console.WriteLine(count);


// bool is_vowels(char el, string vowels="aeuioy"){
//     for (int i = 0; i < vowels.Length; i++){
//         if (vowels[i] == el)
//             return true;
//     }
//     return false;
// }

    
// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// int count = 0;
// for (int i = 0; i < initial.Length; i++){
//     if (is_vowels(initial[i]))
//         count++;
// }
// Console.WriteLine(count);