// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine("Элементы массива:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
