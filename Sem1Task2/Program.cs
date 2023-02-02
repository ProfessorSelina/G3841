// Напишите программу, которая на 
// вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Считываем данные с консоли 1 число
    Console.WriteLine ("Введите число 1");
  string? inputNum1 = Console.ReadLine();

// Считываем данные с консоли 2 число
    Console.WriteLine ("Введите число 2");
  string? inputNum2 = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (inputNum1 != null && inputNum2 != null)
{
    int number1=int.Parse(inputNum1);
    int number2=int.Parse(inputNum2);
    if (number1>number2)
    {
        Console.Write ("Число ");
        Console.Write (number1);
        Console.Write ("больше");
        Console.Write (number2);
    }
    else
    {
        Console.Write (" Число ");


        Console.Write (number2);

        
        Console.Write (" больше числа ");



        Console.Write (number1);


    }
}
