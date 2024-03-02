// Домашнее задание по семинару - "Простые алгоритмы"
// Задача 1.
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");
int q = Convert.ToInt32(value: Console.ReadLine());
if (q % 7 ==0 && q % 23 ==0)
{
  Console.WriteLine("Число КРАТНО 7 и 23");
}
else if (q % 7 ==0)
{
    Console.WriteLine("Число кратно только 7");
}
else if (q % 23 ==0)
{
    Console.WriteLine("Число кратно только 23");
}
else
{
    Console.WriteLine("Число НЕ КРАТНО 7 и 23");
}