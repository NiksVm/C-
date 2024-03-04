// Урок 5. Семинар - Массивы
// Проверка и вопросы по дз
// Как ещё можно решить 4 задание прошлой домашней работы
// Как указаное введеное число отобразить все цифры этого числа через ","
// Пример 1234 -> 1,2,3,4
// РЕШЕНИЕ
/*
Console.Write("Введите число N: ");
int n = Convert.ToInt32(value: Console.ReadLine());
int m = n;  
int count = 0;
while (m > 0)
{
    count++;
    m /= 10;
}

while (count > 0)
{
    Console.Write($"{n / Convert.ToInt32(Math.Pow(10, count - 1 )) % 10}, ");
    count--;
}
*/

// Задача 1
// Задайте массив. Напишите программу, которая определяет присутствует ли заданое чило в массиве
// программа должна выдать Да/Нет
// ПРИМЕР 
// [1, 2, 4, 6, 7] вводим 9 -> Нет

// РЕШЕНИЕ

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int [n];
int[] mas2 = new int [n];
Console.WriteLine(mas);

// WHILE - пример
int ind = 0;
while (ind < mas.Length)
{                                   // Написанный выше код создаёт нам массив с 0
                                    // какую цифру мы введем вместо q столько элементов в массиве и будет
                                    // и пока массив не задан там будут одни 0.
                                    // Мы проверили на типе данных int, dooble - выдает 0, на типе данных string - выдает пустоту(т.к. это строка)

    Console.Write($"{mas[ind]} ");
    ind++;
}       
Console.WriteLine();    // прописываем что бы не было склеивания
   
// FOR - пример
for(int i = 0; i < mas.Length; i++) // задаем переменную в самом цикле for после пишем условие и прибавляем шаг(+1))
                                    // результат при этом пролучается такой же как и с циклом while
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();    // прописываем что бы не было склеивания

//FOREACH - пример
foreach (var item in mas)  // при использовании такого цикла переменная для шага цикла тоже задается в самом цикле, в нашем примере "var i"(var сам определит какой тип)
                        // особенность такого цикла в том что он не сможет изменить или перезаписать данный в массиве
{
    Console.Write($"{item} ");
}
Console.WriteLine();    // прописываем что бы не было склеивания
// Для того что бы мы могли изменять массив лучше всего использовать циклы for или while
// Для того что бы что-то мы могли поменять в цикле foreach нужно будет постоянно указывать где и что нужно менять
// Для этого может потребоваться создать функцию.
// Создание функции которая ничего не возвращает начинается со слова void 
// Void - пишется перед функцией

// Создание функции
void print_mas(int[] col)   // print_mas - так будет называться функция
{                           // в {} пишется то что будет делать функция print_mas
foreach (var item in col)   // при использовании такого цикла переменная для шага цикла тоже задается в самом цикле, в нашем примере "var i"
                            // особенность такого цикла в том что он не сможет изменить или перезаписать данный в массиве
{
    Console.Write($"{item} ");
}
Console.WriteLine();    // прописываем что бы не было склеивания
}
print_mas(mas); // вывод функции которую задали раньше

// Функция Random
int[] Random_mas(int[] col)  // функция которая возвращает int - в нашем случае число
{
    for(int i = 0; i < col.Length; i++)                                   
    {
    col[i] = new Random().Next(1,10);
    }
return col;
}
int[] new_mas = Random_mas(mas);
print_mas(new_mas);


int[] ReadLine_mas(int[] col)
{
    for(int i = 0; i < col.Length; i++)                                   
    {
    Console.WriteLine($"Введите {i} элемент массива");
    col[i] = Convert.ToInt32(Console.ReadLine());
    }
return col;
}
int[] new_mas2 = ReadLine_mas(mas2);
print_mas(new_mas2);

Console.Write("Введите искомое число ");
int m = Convert.ToInt32(Console.ReadLine());

int c_R = 0;
int c_C = 0;

for (int i = 0; i < mas.Length; i++)
{
    if (new_mas[i] == m) {c_R ++;}
    if (new_mas2[i] == m) {c_C ++;}
}
if (c_R == 0 && c_C == 0)
{
    Console.WriteLine("Нет");
}
else 
{
    if (c_R > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas");
    if (c_C > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas2");
}