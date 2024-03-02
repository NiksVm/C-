// Задача 3.
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите двузначное чило: ");
int q = Convert.ToInt32(value: Console.ReadLine());
while  (true) 
{
    if ((q <= 99) && (q >= 10)) break;
    Console.WriteLine("Введеное число не соответствует условиям");
    Console.Write("Введите двузначное число N: ");
q = Convert.ToInt32(Console.ReadLine());
}
int q1 = q / 10;
int q2 = q % 10;
if (q1 == q2) {Console.WriteLine("Числа равны");}
else
{if (q1 > q2) {Console.WriteLine($"Наибольшее число - {q1}");}
else {Console.WriteLine($"Наибольшее число - {q2}");}}