// Семинар. Функции
// Задача 1
// Задайте одномерный массив, заполненный случайными числами.
// определите количество простых чисел в этом массив.
// Примеры

// [1, 3, 4, 19, 3] => 2
// [4, 3, 4, 1, 9, 5, 21, 13] => 3

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
// Пишем функцию которая будет проверять на простые числа
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