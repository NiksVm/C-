// Семинар. Функции
// Задача 1
// Задайте одномерный массив, заполненный случайными числами.
// определите количество простых чисел в этом массив.
// Примеры

// [1, 3, 4, 19, 3] => 2
// [4, 3, 4, 1, 9, 5, 21, 13] => 3
/*
int [] Random_mas(int num) // создаем функцию которая будет создовать нам случайный массив от 0 до 21
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 21);
    }
    return mas;
}
void Print_mas(int[] mas) // Создаем функцию на вывод массива
{
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
} 


bool prost(int num) // Создаем функцию которая определяет простые числа или нет
{
    if( num == 0 || num == 1) return false;
    else 
    {
       for (int i = 2; i < num; i++)
       {
        if(num % i == 0) return false;
       } 
       return true;
    }

}
// Пишем функцию которая будет считать на простые числа
int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if(prost(i)) 
        {
            Console.Write($"{i} ");
            count ++;
        }
        
    }
    Console.WriteLine();
    return count;
}


Console.Write("Введите разномерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Random_mas(n);    // Данную функцию описали выше
Print_mas(array);   // Данную функцию описали выше
Console.WriteLine(Count(array));
Console.WriteLine(prost(9));
*/

// Задание 2
// Задайте массив N слуйчайных чисел (N вводится с клавиатуры)
// Найдите кол-во чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример

// [1, 5, 11, 21, 81, 4, 0 91, 2, 3] => 2

/*
int[] FillRandowArray(int size)
{
    int[] arr = new int[size];
    for ( int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue: 0, maxValue: 999);
    }
    return arr;
}

void Print_mas(int[] mas) // Создаем функцию на вывод массива
{
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
} 

int IsInteresting(int[] arr)
{
    int count = 0; 
    foreach(int e1 in arr)
    {
        if(HaveOne(num: e1) && MultiSeven(num: e1))
        {
            count++;
        }
    }
    return count;
}
bool HaveOne(int num)
{
    if (num % 10 == 1)
    {
        return true;
    }
    return false;
}

bool MultiSeven(int num)
{
    if (num % 7 == 0)
    { return true;}
    return false;
}

Console.Write("Введите размерность одномерного массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandowArray(length);
Print_mas(arr);
Console.WriteLine($"Количество чисел удовлетворяющих условия: {IsInteresting(arr)}");

*/

// Задача 3. 
// Заполните массив на N (вводиться с консоли, не более 8)
// случайных целых чисел от 0 до 9

// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший на последнем.
// Пример

// [1,3,2,4,2,3] => 132423
// [2,3,1] => 231


/*
int[] FillRandowArray(int size) // создание случайного массива
{
    int[] arr = new int[size];
    for ( int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue: 0, maxValue: 10);
    }
    return arr;
}

void Print_mas(int[] mas) // Создаем функцию на вывод массива
{                         // пример задан массив [1,4,3,5,6]
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
} 

int num(int[] col)
{
    int n = 0;
    foreach (var item in col)
    {
        n = n * 10 + item;
    }
    return n;
}
// как он преобразовывает в число
// 1
// 1 * 10 + 4 = 14
// 14 * 10 + 3 = 143
// 143 * 10 + 5 = 1435
// 1435 * 10 + 6 = 14356...

Console.Write("Введите размерность одномерного массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandowArray(length);
Print_mas(arr);
Console.WriteLine(num(arr));
*/


// Консультация к ДЗ
for (int i = 0; i < 10; i++)
{
    if (i == 6) continue;   // Как только шаг встретить continue - то он понимает это как пропусти
    if (i == 8) break;      // break - досрочно заверши цикл
    Console.WriteLine(i);

}
// на выходе мы получим
// 0
// 1
// 2
// 3
// 4
// 5
// 7

// шаг с 6 мы пропускаем из-за continue
// шаг с 8 не вышел так как в условии стоит что если доходим до 8 цикл досрочно завершается

// создание бесконечного цикла, с остановкой на 150
int q = 1;
while (true)
{
    Console.WriteLine(q);
    if (q == 150) break;
    q++;
}