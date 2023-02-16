// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

//Решаем уравнение по Х
double xVolume(double b1, double k1, double b2, double k2)
{
    double xVol = (b2 - b1) / (k1 - k2);
    //double x = (b2 - b1) / (k1 - k2);
    return xVol;
}

// Решаем уравнение по У
double yVolume(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

// Ввод данных
double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");

// Рассчет значений х и у
double x = xVolume(b1, k1, b2, k2);
double y = yVolume(b1, k1, x);

// Вывод ответа в консоль
Console.WriteLine("Значение Х = " + x);
Console.WriteLine("Значение Y = " + y);
