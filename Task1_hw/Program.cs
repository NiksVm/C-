// ## Задача 1 
//Нужно написать код который определяет какое число больше 1-ое или 2-ое или числа равны

int c = 5;
int d = 5;

if (c > d)
{
    Console.WriteLine("Первое число больше");
}
if (c < d)
{
    Console.WriteLine("Второе число больше");
}
if (c == d)
{
    Console.WriteLine("Числа равны");
}

// ## Задача 2
// Максимальное из трех чисел
// оператор && - используется как "И" доп условие
// Варинат 1

int x = 5;
int y = 6;
int z = 7;

if (x > y && x > z)
{
    Console.WriteLine(x);
}
if (y > x && y > z)
{
    Console.WriteLine(y);
}
if (z > x && z > y)
{
    Console.WriteLine(z);
}
if (((z + x + y)/3)==x)
{
    Console.WriteLine("Числа равны");
}

// Варинат 2

/*int a = 10;
int b = 11;
int z = 2;

int result = a;

if (b > result)
{result = b;}

if (c > result)
{result = z;}

Console.WriteLine(result);*/


// ## Задача 3
//Оператор остатка % вычисляет остаток от деления левого операнда на правый.
//Для целочисленных операндов результатом a % b является значение, произведенное a - (a / b) * b. 

int v = 5;

if ((v % 2) == 0)
{
    Console.WriteLine("chentoe");
}
else
{
    Console.WriteLine("nechentoe");
}