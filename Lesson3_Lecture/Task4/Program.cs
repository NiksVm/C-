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
