﻿// Урок 2. Семинар - Введение
// Задача 1
// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго

/*Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()!); 
//int.Parse("123");
//Convert.ToInt("1123") // - конвертирует в int
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

// Ещё один варинат рещения задачи 1


if(number1 == Math.Pow(number2,2)) - //Math.Pow(number2,2) - Math.Pow - возводить в степень, в () какое число через запитую в какую степень 
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1} "); // - значок $, пишется когда мы пишем текс и добавляем переменную/математическую операцию на вывод. Вызов переменной.
}
else 
{
    Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);
}*/
//Console.WriteLine("Значение переменной number1 равно" + namber1)
//Справка фигурные скобки которые следую после функций, к примеру if можно не использовать
//но в этом случае все должно быть написано в одну строчку, к примеру: if(number1 == math.Pow(number2,2)) Console.WriteLine($"Квадрат числа {number1} равен {number2}")

// Задача 2 
// Напишите программу, которая на вход прнимает целое число N, а на выходе 
// показывает все целые числа в промежутке от N до целого числа

/*Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
num = num * (-1);
}
int i = - num;

while (i <= num)
{
    Console.Write($"{i} ");
    i++; // "++" - можно записать как i = i + 1; "--" - можно записать как i = i - 1
}*/


// Задача 3 
// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает сумму первой и последней цифры этого числа.
/*
Console.Write("Введите трехзначное число N: ");
int q = Convert.ToInt32(Console.ReadLine());  // используем разрядность числа нужно вязть 1-ое и 3-е число
while  (true) 
{
    if ((q <= 999) && (q >= 100)) break;
    Console.WriteLine("Введено НЕ трехзначное число: ");
    Console.Write("Введите трехзначное число N: ");
q = Convert.ToInt32(Console.ReadLine());
}

int q1 = q % 10; // % - это целочисленное деление c остатком покажет нам первое число(к прмиеру 5/2, остаток будет 1, 1 и запишется)
int q2 = q / 100; // % - это деление покажет нам третье число
Console.Write($"Сумма числа {q1} и числа {q2} равна {q1 + q2} ");


// Способ решения задачи 3, но вывод числа производиться рандомно
int q = new Random().Next(100, 1000); // данный пример будет сам выберать трехзначное число и выводить сумму 1-го и 3-его числа
int q1 = q % 10;
int q2 = q / 100; 
Console.Write($"Числа {q}. Сумма {q1} и {q2} равна {q1 + q2} ");
*/

//Способ решения задачи 3 "в строку"
Console.Write("Введите трехзначное число:");
string q = Console.ReadLine(); //string - функция обрезки
Console.WriteLine(Convert.ToInt32(Convert.ToString(q[0])) + 
    Convert.ToInt32(Convert.ToString(q[2]))); // Convert.ToString(q[0] - берет от трехзначного числа 1 символ([0] - это первый символ)