// Задача 2 
// Вывод на экран квадратного числа от 1 до N 

// Создание функции
// 1. Что делает функция?
// 2. Какие данные ей нужны для работы?
// 3. Что будет с результатом работы?

void PrintSquares (int limit)    // имя функции
{
    int i = 1;
while (i <= limit)
{
    Console.Write($"{i*i} ");
    i++;
}
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);