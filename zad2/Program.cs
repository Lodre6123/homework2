// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 1000) num = num / 10;
if (num < 100) Console.WriteLine("У данного числа, нет третьей цифры");
else
{
    int Number = num % 10;
    Console.WriteLine($"Третье цифра {num} - {Number}");
}