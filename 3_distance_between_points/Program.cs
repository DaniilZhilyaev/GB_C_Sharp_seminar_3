/*Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine()!);

double result = Math.Sqrt((Convert.ToDouble(Math.Pow(x2 - x1, 2)))+(Convert.ToDouble(Math.Pow(y2 - y1, 2))));
Console.WriteLine(result);