// Задача 4 
// Дано 10 гирь с разным весом в случайном порядке.
// Определить вес самой тяжелой гири.

int n = 5;
int [] array = {2, 4, 5, 10, 11};
int i = 0;
int max = array[i];
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);


// Пример применения цикла FOR
max = array[0];
for(int j = 0; j < n; j++)
{
     if (array[j] > max)
    {
        max = array[j];
    }
  
}
Console.WriteLine(max);

// Пример применения цикла FOREACH
max = array[0];
foreach(int e in array)
{
   if (e > max)     // в отличии от предыдущего варианта где указывается индекс массива, здесь она не нужна, 
                    //т.к. используется переменная(особенноть цикла foreach)
    {
        max = e;    // тут аналогично - не используется цикл, используется переменая(особенноть цикла foreach)
    } 
}
Console.WriteLine(max);