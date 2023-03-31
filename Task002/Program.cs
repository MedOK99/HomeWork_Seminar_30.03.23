/* Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да   */

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");

int num = int.Parse(Console.ReadLine());



int p = num % 10;   // последнее число
int d = num / 10000;  // первое число
int r = num - (d * 10000);
int d2 = r / 1000;  // второе число
int r2 = r - d2 * 1000;   //  
int d3 = r2 / 100;
int r3 = r2 - d3*100;
int p2 = r3 /10;  // предпоследнее число


if (num > 9999 && num < 100000)
{
  if (p == d && p2 == d2)
  {
    Console.WriteLine($"Число {num} является палиндромом");
  }
else
Console.WriteLine($"Число {num} НЕ является палиндромом");

}
else
Console.WriteLine("Вы ввели НЕ верное число!");




/*
int num, r, sum = 0, t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
  for (t = num; num != 0; num = num / 10)
  {
    r = num % 10;
    sum = sum * 10 + r;
  }
  if (t == sum)
    Console.Write($"{t} является палиндромом.");
  else
    Console.Write($"{t} не является палиндромом.");
}
else
  Console.Write("Введите пятизначное число! ");
*/