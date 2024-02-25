// Урок 2. Семинар - Введение
// Задача 1
// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()!); 
//int.Parse("123");
//Convert.ToInt("1123") // - конвертирует в int
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

/*if(number1 == number2 * number2)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}*/

// Ещё один варинат рещения задачи 1


if(number1 == Math.Pow(number2,2)) - //Math.Pow(number2,2) - Math.Pow - возводить в степень, в () какое число через запитую в какую степень 
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1} "); // - значок $, пишется когда мы пишем текс и добавляем переменную/математическую операцию на вывод. Вызов переменной.
}
else 
{
    Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);
}
//Console.WriteLine("Значение переменной number1 равно" + namber1)