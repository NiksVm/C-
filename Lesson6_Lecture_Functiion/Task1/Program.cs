// Урок 6. - Функции
// Пример функци
// Задача 1
// Вычислить значени формулы a * b / c + d, где 
// a,b,c,d -  некоторые целые числа. Решение оформить
// в виде функции

// Создание функции:
// 1. Что будет делать функция?
// 2. Какие данные ей нужны для работы?
// 3. Что будет результатом работы?



double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
return result;
}

double result = CalculateFormula(1, 2, 3, 4);

Console.WriteLine(result);
