/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int c = 1;

while(N >= c)
{
    Console.Write($"{Convert.ToInt32(Math.Pow(c, 3))} ");
    c++;
}