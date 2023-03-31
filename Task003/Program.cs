/*    Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125    */

Console.Clear();

Console.WriteLine("Введите число:");

double cube = double.Parse(Console.ReadLine());

for (double i = 1; i < cube; i++)
{
  Console.Write($"{(Math.Pow(i, 3))}, ");
}
Console.Write(Math.Pow(cube, 3));



