/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool IsWeek(int day)
{
    return day == 6 || day == 7;
}

Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Этот день недели " + (IsWeek(number) ? "":"будний ") + "выходной");


