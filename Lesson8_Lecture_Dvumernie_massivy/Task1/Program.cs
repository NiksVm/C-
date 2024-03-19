/*
int[,] matrix = new int [3, 5];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        matrix[i,j] = rnd.Next(1, 11);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        Console.Write($"{matrix[i,j]} ");    //Данный способ вывода данных называется интерполяция вывода строк
    }
    Console.WriteLine();
}
*/
// Создадим функцию которая будет выводить нам двумерный массив
int[,] CreateMatrix (int rowCount, int columsCount) // rowCount - с англ. - число строк, columsCount - с англ. - число столбцов
{
    int[,] matrix = new int [rowCount, columsCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
        
                    matrix[i,j] = rnd.Next(1, 11);
                }
        }
return matrix;
}

// Создадим функцию которая будет выводить на экран
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
        
             Console.Write($"{matrix[i,j]} ");    //Данный способ вывода данных называется интерполяция вывода строк
            }
        Console.WriteLine();
        }
}

int[,] matrix = CreateMatrix(4, 5); // Создаст матрицу на 4 строк и 5 столбца
ShowMatrix(matrix);