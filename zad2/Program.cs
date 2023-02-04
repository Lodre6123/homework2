/*Напишите программу, которая выводит третью цифру заданного числа.
645 -> 5
32679 -> 6
21 -> -1
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 1000) num = num / 10;
if (num < 100) Console.WriteLine("У данного числа, нет третьей цифры");
else
{
    int Number = num % 10;
    Console.WriteLine($"Третье цифра {num} - {Number}");
}