// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Quad of " + a + " is " + a * a); 

// Для того что бы скомментировать весь массив выделяем нужный нам скрипт/абзац и нажимаем cmd+/

// Задание 1
// Напишите программу, которая на вход принимает два целых числа и проверяет
// является ли первое число квадратом второго
// a = 25, b = 5 => да 
// a = 2, b = 10 => нет 
// a = 9, b = 3 => да 
// a = -3, b = 9 => нет 

// Console.WriteLine("Введите 1-ое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2-ое число");
// int b = Convert.ToInt32(Console.ReadLine());
//     if (a == b * b)     // условие
//     {
//         Console.WriteLine($"a = {a}, b = {b} - > yes");     // < - Если условие истинное то
//     }
//     else 
//     {
//         Console.WriteLine($"a = {a}, b = {b} - > no");      // < - Если условие ложное то
//     }

//Задание 2 
// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа
// числа в промежутке от -N до N
// Примеры 
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int start = -a;
// while(start <= a)       // цикл while будет работать до тех пор пока не найдет такле отрицательно число(пример если ввели 2 то он пройдет 
//                         //то он пройдет каждое число до -2
// {
//     Console.Write(start + ", ");
//     start++;
// }                        

//Задание 3
//  Напишите программу, которая принимает на вход 3-х значное целое число и на выходе показывает сумму первой и последней цифры этого числа
// 456 => 10
// 782 => 9
// 918 => 17
using System.Globalization;

Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a <= 999)
{
    int ed = a % 10;        //Целочисленное деление - определяем крайнюю циифру(деление без остатка: пример 7 % 2 = 5)
    int sot = a / 100;  
    Console.WriteLine("Сумма = " + (ed + sot));
}
else 
{
    Console.WriteLine("Число введено не верно");
} 
