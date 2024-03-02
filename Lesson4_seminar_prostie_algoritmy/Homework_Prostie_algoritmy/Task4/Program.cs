// Задача 4.
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую


Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(value: Console.ReadLine());
int i = 1;
while (i < n) 
{
    Console.Write($"{i}, ");
     i++;
}
Console.Write("\b\b "); 