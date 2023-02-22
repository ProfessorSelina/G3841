﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1" N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int n)
{
    // базовый случай: если n меньше или равно 0, прекращаем рекурсию
    if (n <= 0) 
    {
        return;
    }
    // выводим текущее число
    Console.Write($"{n}, "); 
    // вызываем функцию рекурсивно для следующего числа
    PrintNumbers(n - 1); 
}

// Примеры вызова функции PrintNumbers:
PrintNumbers(5);
PrintNumbers(8);