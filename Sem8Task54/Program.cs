//Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива. 
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int rows = array.GetLength(0); // количество строк
int cols = array.GetLength(1); // количество столбцов

for (int i = 0; i < rows; i++)
{
    // сортируем текущую строку по убыванию
    for (int j = 0; j < cols - 1; j++)
    {
        for (int k = j + 1; k < cols; k++)
        {
            if (array[i, k] > array[i, j])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}

// выводим отсортированный массив на консоль
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}