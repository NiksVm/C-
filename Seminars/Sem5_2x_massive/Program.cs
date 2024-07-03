// Семинар 5. Двумерные массивы
// В чем разница между одномерным и двумерным массивом? 
// В одномерном массиве одна строка, пример [1, 2, 4, 5]
// В двумерном массиве имеет несколько строк. Пример двумерного массива:
//    0 1 2 3
// 0 [1 4 9 5]
// 1 [3 1 5 7]
// 2 [4 6 2 6]

// Первый индекс отвечает за строку. Второй индекс отвечает за столбец.
// Цикл For будет создоваться внешний и внутрений.

// Описание метода по созданию и наполнению двумерного массива
/*
int[,] CreateRandomMatrix(int rows, int columns, int min, int max)           //для инф.[,] - двумерный массив
{
int[,] matrix = new int[rows, columns];                                     // Созадние нового массива c учетом переменных rows, columns
Random random = new Random();                                               // Проходит сперва по строкам
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)    
        {                                                                  // Проходит сперва по столбцам
        matrix[i, j] = random.Next(min, max + 1);
        }                                                                   // Выводим массив то что прошли циклы
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)                                             // Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {                                                                       // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                   // Проходит сперва по столбцам
        {
            Console.Write(matrix[i, j] + " ", ConsoleColor.Green);          // Выводим массив, то что прошли циклы
        }
        Console.WriteLine();
    }   
    
}

PrintMatrix(CreateRandomMatrix(3,4,20,99));
*/

// Задание 1 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.
// Пример 
// 2 3 4 3       4 3 16 3
// 1 3 4 1  =>   4 3 4 1
// 2 9 5 4       4 9 25 4

// Решение(методы создания массива взяли выше что бы не писать)

/*
int[,] EvenNumsToQuad(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {                                                                       // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                 
        {
        if(i % 2 == 0 && j % 2 == 0)                                        // Условия вывода(из задачи)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
        }
        
    }   
    return matrix;
}


int[,] CreateRandomMatrix(int rows, int columns, int min, int max)           //для инф.[,] - двумерный массив
{
int[,] matrix = new int[rows, columns];                                     // Созадние нового массива c учетом переменных rows, columns
Random random = new Random();                                               // Проходит сперва по строкам
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)    
        {                                                                  // Проходит сперва по столбцам
        matrix[i, j] = random.Next(min, max + 1);
        }                                                                   // Выводим массив то что прошли циклы
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)                                             // Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {                                                                       // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                   // Проходит сперва по столбцам
        {
            Console.Write(matrix[i, j] + " ", ConsoleColor.Green);          // Выводим массив, то что прошли циклы
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число от...:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число до...:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);                                            // Выводит двумерный массив
matrix = EvenNumsToQuad(matrix);                                // изменяет его с помощью метода EvenNumsToQuad
PrintMatrix(matrix);                                            // Выводит измененный с помощью метода выше двумерный массив
*/



// Задание 2
// Задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали(с индексами (0, 0), (1, 1) и т. д.)
// Пример
//  2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10 
//  2 9 5 4

// Решение 
/*
int SumOfMainDiagonal(int[,] matrix)          // Обявляем методы который будет считать сумму цифр главной диагонали
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {                                                                       // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                 
        {
        if(i  == j) 
        {
            sum += matrix[i, j];
        }
        }
        
    }  
    return sum;

}   



int[,] CreateRandomMatrix(int rows, int columns, int min, int max)           //для инф.[,] - двумерный массив
{
int[,] matrix = new int[rows, columns];                                     // Созадние нового массива c учетом переменных rows, columns
Random random = new Random();                                               // Проходит сперва по строкам
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)    
        {                                                                  // Проходит сперва по столбцам
        matrix[i, j] = random.Next(min, max + 1);
        }                                                                   // Выводим массив то что прошли циклы
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)                                             // Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {                                                                       // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                   // Проходит сперва по столбцам
        {
            Console.Write(matrix[i, j] + " ", ConsoleColor.Green);          // Выводим массив, то что прошли циклы
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число от...:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число до...:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);                                        //
Console.WriteLine(SumOfMainDiagonal(matrix));
*/

// Задание 3
// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из среднених арифметических значений по строкам двумерного массива
// Пример
//  2 3 4 3
//  4 3 4 1 => [3 3 5]
//  2 9 5 4

// ! Методы создания и вывода массива копируем из прошлой задачиж.
// ! по сути нам остается вывести только метод который заключается в условии задачи


double[] SrAr(int[,] matrix)                        // Метод который суммирует по строкам цифры в двумерном массиве и делит на их кол-во
{
    double[] result = new double[matrix.GetLength(0)];
    
     for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {   
        int sum = 0;                                                                    // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                 
        {
            sum += matrix[i, j];                                                // посчитали сумму элементов этой строки
        }
        result[i] = (double)sum / matrix.GetLength(1);                          // Сумму цифр строки делит на кол-во цифр в строке
        }
        return result;
    } 

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}



int[,] CreateRandomMatrix(int rows, int columns, int min, int max)           //для инф.[,] - двумерный массив
{
int[,] matrix = new int[rows, columns];                                     // Созадние нового массива c учетом переменных rows, columns
Random random = new Random();                                               // Проходит сперва по строкам
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)    
        {                                                                  // Проходит сперва по столбцам
        matrix[i, j] = random.Next(min, max + 1);
        }                                                                   // Выводим массив то что прошли циклы
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)                                             // Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)                           // GetLength - по сути тоже самое что и Length в одномерном массиве, если мы ставим (0), то это число строк.
    {                                                                       // Если мы поставим в GetLength в (1), то это число столбцов.
        for (int j = 0; j < matrix.GetLength(1); j++)                                   // Проходит сперва по столбцам
        {
            Console.Write(matrix[i, j] + " ", ConsoleColor.Green);          // Выводим массив, то что прошли циклы
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число от...:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число до...:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);                                        //
PrintArray(SrAr(matrix));
