// Семинар 3 - МАссивы 
// Задание 1
// Задайте массив. НАпииште программу, которая определяет, присутствует ли заданное число в массиве.
// Программа выдать ответ: Да/Нет
// Примеры
// [1 3 4 19 3], 8 => Нет 
// [-4 3 4 1], 3 => Да

// Решение 
// Для начала надо сделать. 
// Задать массив - какого он бует размера
// Числа из какого диапозона будет он содержать

// Console.Write("Введите размерность массива: ");
/*
int [] CreateRandowArray(int size, int min, int max)        // Создаем функицю которая будет выдвавать слуяайный массив 
{
    int [] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)        // Создаем функцию которая будет вводить нам массив
{
    for(int i = 0; i < array.Length; i++)
    {
        Console. Write(array[i] + " ");
    }   
    Console. WriteLine();
}

bool SearchNum(int[] array, int num)        //Данная функция как раз таки и будет искать нам введено число, на предмет встречается ли оно в массиве или нет(условие задачи)
{
    for (int i = 0; i < array.Length; i++)  // Данный цикл будет перебирать наш массив и проверять введеное число(условие задачи)
    {
        if(array[i] == num)                  // Условаие для цикла
        {
            return true;
        }                
    }
    return false;
}

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());



int [] myArray = CreateRandowArray(size, min, max);
PrintArray(myArray);
// Все что выше это вывод массива. Где мы задаем размерность массива, также задаем мин.число и макс.число. 

Console.WriteLine("Введите искомое число: ");       // Здесь как раз мы запрашиваем искомое число
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SearchNum(myArray, num));         // Срванивает введено число(перебором где писали цикл) и выводит true или false
*/


// Задание 2
// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10].
// Замените отрицательные элементы на положительные, а положительные на отрицательные
// Пример [1 -5 6] => [-1 5 -6]

// Решение 
/*
int [] CreateRandowArray(int size, int min, int max)        // Создаем функицю которая будет выдвавать слуяайный массив 
{
    int [] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)        // Создаем функцию которая будет вводить нам массив
{
    for(int i = 0; i < array.Length; i++)
    {
        Console. Write(array[i] + " ");
    }   
    Console. WriteLine();
}

int[] ChangeArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
        return array;
    
}


Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandowArray(size, min, max);
PrintArray(myArray);
myArray = ChangeArray(myArray);       // Перезаписываем имеющийся массив, который перемножается на -1 и выводим этот же массив но противоположным знаком
PrintArray(myArray);
*/


// Задане 3
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последней элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]
// Решение 

int [] CreateRandowArray(int size, int min, int max)        // Создаем функицю которая будет выдвавать случайный массив 
{
    int [] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)        // Создаем функцию которая будет вводить нам массив
{
    for(int i = 0; i < array.Length; i++)
    {
        Console. Write(array[i] + " ");
    }   
    Console. WriteLine();
}


int[] CompositionArray(int[] array)
{
    int[] ResultArray = new int[array.Length / 2];
    for(int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = array[i] * array[array.Length - i -1];

    }
    return ResultArray;
}


Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandowArray(size, min, max);       
PrintArray(myArray);                                            // выводим массив

PrintArray(CompositionArray(myArray));