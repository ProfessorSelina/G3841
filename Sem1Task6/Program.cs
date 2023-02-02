// Задача 6: Напишите программу, которая 
// на вход принимает число и выдаёт, является 
// ли число чётным (делится ли оно на два без остатка)

// Считываем данные с консоли 
    Console.WriteLine ("целое число");
  string? inputNum = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (inputNum != null);
{
    int number = int.Parse(inputNum);

    // проверяем условие по остатку
    if ((number % 2) == 0)
    {
         Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число не четное");
    }
}