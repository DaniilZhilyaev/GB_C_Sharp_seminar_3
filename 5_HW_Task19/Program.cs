/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
string nstr = n.ToString();

if(nstr.Length == 5)
{
    if(nstr[0]==nstr[4] && nstr[1]==nstr[3]) Console.WriteLine("Это палиндром");
    else Console.WriteLine("Это не палиндром");
}
else Console.WriteLine("Число должно быть пятизначным");