// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

Console.WriteLine ("Введите 3-х значное число:");
try {
	int Value = Convert.ToInt32(Console.ReadLine());
	int Length = Value.ToString().Length;
	if (Length == 3) 
    {
		int result = ( Value/10 ) % 10;
		Console.WriteLine($"Вторая цифра {result}");
	} 
    else 
    {
		Console.WriteLine("Не трехзначное число");
	}
} catch (System.Threading.ThreadAbortException) {
	System.Threading.Thread.ResetAbort();
} catch (Exception e) {
	Console.WriteLine(e.Message);
}