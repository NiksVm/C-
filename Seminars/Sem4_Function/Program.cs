// Семинар C# Функции

// Задание 1 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в этом числе
// ПРИМЕР
// 456 -> 3
// 78 -> 
// 89126 ->
// Подсказка тип будет целочисленный

// Решение

// Создаем функцию которая будет нам счиать кол-во цифр
/*
int DigitsCounter(int num)
{
    int counter = 0;        // объявляем счетчик, далее нужно будет задать цикл
    while (num > 0)
    {
        num /= 10;          // делит число на 10(пример число 345, при делении полуяится 34, 
                            // снова делим и так до тех пор пока условие не перестанет выполнятся. 
                            // При этом пока идет цикл данные будут записываться в переменную counter)
        counter++;
    }
    return counter;
}

// Объявляем переменную для ввода и вывода
Console.WriteLine("Введите число ");        // Сообщение что нужно ввести число
int num = Convert.ToInt32(Console.ReadLine());      // Запоминает введено число и записывает его в переменнкю num

Console.WriteLine(DigitsCounter(num));      // Выводит функцию
*/

// Задание 2 
// Задайте массив их N целых случайных чисел (N вводится с клавиатуры).
// Найдите кол-во чисел, которые оканчиваются на 1 и делятся нацело на 7.
// ПРИМЕР
// [1 5 11 21 81 4 0 91 2 3] => 2
// РЕШЕНИЕ

/*
int[] InputArray(int size)      // Функцияя создания массива, массив будем создавать вручную
{
    int[] arr = new int [size];     // Создание нового массива, размерность определяется переменной size
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Input {i+1} number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int ArrayCounter(int[] arr)      // Функция которая будет проверять делиться ли введено число на 7
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 10 == 1 && arr[i] % 7 == 0)     // двойное условие, будет ли остаток числа при делении на 10 равен 1 и 
                                                    // будет ли остаток числа при делении на 7 = 0. Если условием выполняется то считаем
    {
        count++;
    }
    }
    return count;
}

Console.WriteLine("Размер массива ");        
int size = Convert.ToInt32(Console.ReadLine()); 

int[] arr = InputArray(size);
Console.WriteLine(ArrayCounter(arr));
*/

// Задание 3 
// Заполниет массив на N(вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший на последнем.

// ПРИМЕР
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// РЕШЕНИЕ

int[] InputArray(int size)      // Функцияя создания массива, массив будем создавать вручную
{
    int[] arr = new int[size];   
    Random random = new Random();  // Создание нового массива, размерность определяется переменной size
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 9 + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)      // Проходимся по каждому числу из массива и собираем все в кучу, так и получим число
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int NumberOfArray(int[] array)
{
    int number = 0;
    for(int i = 0; i < array.Length; i++)
    {
        number += array[i] * (int)Math.Pow(10, array.Length - i - 1);
    }
    return number;
}

System.Console.WriteLine("Input size of array");
int size = Convert.ToInt32(Console.ReadLine());



int[] myArray = InputArray(size); 
int result = NumberOfArray(myArray);
PrintArray(myArray);
Console.WriteLine(result);