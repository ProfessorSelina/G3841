// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц. 

int[,] matrix1 = new int[,]
{
    {2, 4},
    {3, 2}
};

int[,] matrix2 = new int[,]
{
    {3, 4},
    {3, 3}
};

int rows1 = matrix1.GetLength(0); // количество строк в первой матрице
int cols1 = matrix1.GetLength(1); // количество столбцов в первой матрице
int rows2 = matrix2.GetLength(0); // количество строк во второй матрице
int cols2 = matrix2.GetLength(1); // количество столбцов во второй матрице

if (cols1 != rows2)
{
    Console.WriteLine("Умножение матриц невозможно: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    return;
}

int[,] result = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;
        for (int k = 0; k < cols1; k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        result[i, j] = sum;
    }
}

// выводим результат на консоль
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write($"{result[i, j]} ");
    }
    Console.WriteLine();
}