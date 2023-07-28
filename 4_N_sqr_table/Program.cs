/*Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.

2 -> 1,4
*/

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int c = 1;

while(N >= c)
{
    Console.Write($"{Convert.ToInt32(Math.Pow(c, 2))} ");
    c++;
}