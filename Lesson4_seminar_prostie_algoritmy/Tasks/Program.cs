// Напишите программу, котороая принимает на вход трехзначное число и 
// удаляет 2-ую цифру этого числа  

//Справка: для того что бы заработали подсказки при печатании команд в терминале требуется
// вводим dotnet sln list
// далее dotnet sln add (укзаывается имя файла с раширением "csproj")
// в моем случае это "Tasks.csproj"

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int s = num / 100*10 + num%10;
Console.WriteLine(s);
Console.WriteLine(num / 100 + "" + num%10);