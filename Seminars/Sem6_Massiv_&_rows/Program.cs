// Семинар 6. Массивы и строки

// ДЗ на 4 задание по функциям

/*
bool IsTrue (string value)
{
    if ( value == "q") return false;
    int num = Convert.ToInt32(value);
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    if(sum % 2 == 0)  return false;
    return true; 
}

bool work = true;
while (work)
{
    string value = Console.ReadLine();
    if(IsTrue(value))
    {
        Console.WriteLine("!!!");
    }
    else
    {
        Console.WriteLine("???");
        work = false;
    }
}
*/

// Задание 1.
// Задайте массив символов(тип char []). Создайте строку из символов этого массива.     Char - тип данных символ
// Указание 
// Коснтруктор строки вида string(char []) не использовать.
// Пример.
// ['a', 'b', 'c', 'd'] => "abcd" 
/*
string CharToString(char[] chars)
 
{
    string result = string.Empty;           // string.Empty = созадется пустая строка(пример, можно также было бы написать string result = "")
    for (int i = 0; i < chars.Length; i++)
    {
        result += chars[i];
    }
    return result;
}

char[] chars = {'a', 'b', 'c', 'd', 'e'};       // Создание массива из букв что указаны в фигурных скобках

Console.WriteLine(CharToString(chars));         //Вывод через ранее созданную функцию

*/


// Задание 2.
// Сделать так что бы мы выводили массив символов, который в последсвтии можем возвести в кавычки('). 
// Перевести строчку в массив символов.
// Пример
// ("abcdef") => a' 'b' 'c' 'd' 'e' 'f'

/*
char[] StringToChars(string str)
{
    char[] result = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        result[i] = str[i];
    }
    return result;
}

void PrintArray(char[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "' " );
    }
}

PrintArray(StringToChars("abcdef"));
*/

// Задание 3.
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
/*
static void Main()
{
    Console.WriteLine("Введите строку из латинских букв в нижне регистре:");
    string str = Console.ReadLine();

    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y'};
    int vowelCount = 0;

for (int i = 0; i < str.Length; i++)            // Данный цикл проходит по каждому символу
{
    for (int j = 0; j < vowels.Length; j++)        // для примера берем слово skip. ...Данный цикл сравнивает каждый символ
    {
        if (str[i] == vowels[j])
        {
            vowelCount++;
            break;                              // в данному случае если он находит в определеном символе совпадения, то происходит принудительная останвока цикла. Возвращаемся к i и переходим к следующему циклу 
                                                // Если он нашёл совпадения нам нет смысла проверять дальше на сходимость остальных элементов в массиве по буквам
        }
    }
}


    Console.WriteLine($"Количество гласных букв: {vowelCount}");
}
Main();
*/

// Данный вариант считается немного небрежынм. Т.к. мы все зашили в один метод.
// По-хорошему нужно отдельно сделать метод для гласных.
// Вариант написания более аккуратной версии.
// Комбинация клави opt + shift + F - форматирует текст в аккуратный вид





int VowelIsCounter(string str)
{
    str = str.ToLower();                            // Переводит введеный символ в прописной вариант. В этом случае мымодем вводить символы даже с заглавной буквы и он их тоже будет считать
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
    int vowelCount = 0;

    for (int i = 0; i < str.Length; i++)            // Данный цикл проходит по каждому символу
    {
        for (int j = 0; j < vowels.Length; j++)        // для примера берем слово skip. ...Данный цикл сравнивает каждый символ
        {
            if (str[i] == vowels[j])
            {
                vowelCount++;
                break;                              // в данному случае если он находит в определеном символе совпадения, то происходит принудительная останвока цикла. Возвращаемся к i и переходим к следующему циклу 
                                                    // Если он нашёл совпадения нам нет смысла проверять дальше на сходимость остальных элементов в массиве по буквам
            }
        }
    }
    return vowelCount;
}

Console.WriteLine("Введите строку из латинских букв в нижне регистре:");
string str = Console.ReadLine();

Console.WriteLine($"Количество гласных букв: {VowelIsCounter(str)}");

