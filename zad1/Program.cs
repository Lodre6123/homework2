/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = (number % 100)/10;
Console.Write($"Второе число это {N}");
*/

// через метод

int NumCenter(int number)
{
    
 int result = ((number % 100 ) / 10);
 return result;
}
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int fin = NumCenter(number);
Console.Write($"Вторая цифра числа {number} это {fin}");
