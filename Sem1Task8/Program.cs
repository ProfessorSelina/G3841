// Задача 8: Напишите программу, которая 
// на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.


// Считываем данные с консоли 
    Console.WriteLine ("Введите целое число");
    string? inputNum = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (inputNum != null);
{
     int number = int.Parse(inputNum);

     // вводим пустую строку
    string outNumLine = string.Empty;

    // вводим счетчик начиная с 2
    int count = 2;
    // если число четное:
    if (number % 2 == 0)
    {
        while (count < number)
        {
            outNumLine = outNumLine + count + ",";
            count = count + 2;
        }

        // Вывод результата в консоль
        Console.WriteLine(outNumLine + number);
    }

    //если число не четное:
    else
    {
        // если число равно 1
        if (number == 1)
        {
            Console.WriteLine("Введите число больше 1");
        }
        else
        {
            while (count < number - 1)
            {
                outNumLine = outNumLine + count + ",";
                count = count + 2;
            }
            // Выводим результат в консоль
            Console.WriteLine(outNumLine + (number - 1));
        }

    }

}