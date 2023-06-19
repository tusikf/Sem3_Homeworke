// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите любое число( желательно до 10): ");

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Таблица кубов для чисел от 1 до { number } выглядит так: ");

for (int i = 1; i <= number; i++)
{
    int kub = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"{ i }  --- { kub}");
}