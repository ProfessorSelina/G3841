//  Напишите программу, которая принимает 
//  на вход три числа и выдаёт максимальное из этих чисел.

// Вводим данные с консоли число 1
string? inputNum1 = Console.ReadLine();
// Вводим данные с консоли число 2
string? inputNum2 = Console.ReadLine();
// Вводим данные с консоли число 3
string? inputNum3 = Console.ReadLine();

// Проверка на нулевое значение
if (inputNum1!= null && inputNum2!= null&& inputNum3!= null)
{
    //Парсим введенное число
    int number1 = int.Parse(inputNum1);
    //Парсим введенное число
    int number2 = int.Parse(inputNum2);
    //Парсим введенное число
    int number3 = int.Parse(inputNum3);

    // Вводим максимальной переменной первое число
    int maximum = number1;

    // Сравниваем max с другими числами
    if (number2 > number1)
        maximum = number2;
    if (number3 > number2)
        maximum = number3;

    // Вывод ответа в консоль
    Console.WriteLine ("Максимальное из чисел:");
    Console.WriteLine (maximum);
}