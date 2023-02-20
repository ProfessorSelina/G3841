// Задача 52: Задайте двумерный массив из 
// целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[,]

{

    {1, 4, 7, 2},

    {5, 9, 2, 3},

    {8, 4, 2, 4}

};



int rows = array.GetLength(0); // количество строк

int cols = array.GetLength(1); // количество столбцов


// Используем двойной цикл ддя интерации по элементам массива
for (int j = 0; j < cols; j++)

{

    int sum = 0;

    for (int i = 0; i < rows; i++)

    {

        sum += array[i, j];

    }

    double average = (double)sum / rows;

    Console.WriteLine($"Среднее арифметическое для столбца {j}: {average}");

}