// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.

int[,] spiralArray = new int[4, 4];
int value = 1;
// Переменные для отслеживания границ заполненной части массива
int minRow = 0, maxRow = 3, minCol = 0, maxCol = 3;

while (value <= 16)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        spiralArray[minRow, i] = value;
        value++;
    }
    minRow++;
    for (int i = minRow; i <= maxRow; i++)
    {
        spiralArray[i, maxCol] = value;
        value++;
    }
    maxCol--;
    for (int i = maxCol; i >= minCol; i--)
    {
        spiralArray[maxRow, i] = value;
        value++;
    }
    maxRow--;
    for (int i = maxRow; i >= minRow; i--)
    {
        spiralArray[i, minCol] = value;
        value++;
    }
    minCol++;
}

// Вывод заполненного массива на консоль
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0,4}", spiralArray[i, j]);
    }
    Console.WriteLine();
}