﻿// Урок 5. Семинар - Массивы
// Задача 1
// Задайте массив. Напишите программу, которая определяет присутствует ли заданое чило в массиве
// программа должна выдать Да/Нет
// ПРИМЕР 
// [1, 2, 4, 6, 7] вводим 9 -> Нет

// РЕШЕНИЕ

Console.WriteLine("Введите число N: ");
int q = Convert.ToInt32(value: Console.ReadLine());
int [] mas = new int [q];   // создание массива
//Console.WriteLine(mas);   // проверяли что работает(необязательная строка)
//int i = 0;

// WHILE - пример
/*while (i < mas.Length)
{
    Console.Write($"{mas[i]} ");
    i++;
} */  // Написанный выше код создаёт нам массив с 0
    // какую цифру мы введем вместо q столько элементов в массиве и будет
    // и пока массив не задан там будут одни 0.
    // Мы проверили на типе данных int, dooble - выдает 0, на типе данных string - выдает пустоту(т.к. это строка)

// FOR - пример
/*for(int i = 0; i < mas.Length; i++) // задаем переменную в самом цикле for после пишем условие и прибавляем шаг(+1))
                                    // результат при этом пролучается такой же как и с циклом while
{
    Console.Write($"{mas[i]} ");
}*/

//FOREACH - пример
foreach (var i in mas)  // при использовании такого цикла переменная для шага цикла тоже задается в самом цикле, в нашем примере "var i"
                        // особенность такого цикла в том что он не сможет изменить или перезаписать данный в массиве
{
    Console.Write($"{mas[i]} ");
    
}
Console.WriteLine();
// Для того что бы мы могли изменять массив лучше всего использовать циклы for или while
// Для того что бы что-то мы могли поменять в цикле foreach нужно будет постоянно указывать где и что нужно менять
// Для этого может потребоваться создать функцию.
// Создание функции которая ничего не возвращает. 
// Void - пишется перед функцией

// Создание функции
void print_mas(int[] col)
{
foreach (var i in mas)  // при использовании такого цикла переменная для шага цикла тоже задается в самом цикле, в нашем примере "var i"
                        // особенность такого цикла в том что он не сможет изменить или перезаписать данный в массиве
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();
}
print_mas(mas); // вывод функции