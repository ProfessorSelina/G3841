﻿// .Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. 

int[,,] array = new int[2, 2, 2];
 // множество для отслеживания повторяющихся элементов
 HashSet<int> set = new HashSet<int>();

Random rnd = new Random();

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            int num;
            do
            {
                // генерируем случайное двузначное число
                num = rnd.Next(10, 100); 
            } // проверяем, не было ли оно уже в массиве
            while (set.Contains(num)); 
            array[i, j, k] = num;
            // добавляем число в множество
            set.Add(num); 
        }
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            // выводим элемент и его индексы
            Console.Write($"{array[i, j, k]}({i},{j},{k}) "); 
        }
        // переходим на новую строку
        Console.WriteLine(); 
    }
}