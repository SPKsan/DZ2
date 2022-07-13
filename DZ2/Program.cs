//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число.");
while (true)
{
    string input = Console.ReadLine();
    
        Console.WriteLine("{0} >{1}", input, input[1]);
    
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



Console.WriteLine("Введите число:");
string numbers = Console.ReadLine();   // прям здесь считываем цифры со ввода

string thirdNumber()
{

    if (numbers.Length <= 2)
    {          // если длина символов в строке меньше 2
        return "В числе нет третьей цифры!";
    }
    else
    {
        return "Третья цифра в числе " + numbers + " : " + numbers[2];  // выведи символ с индексом 2
    }
}


Console.WriteLine(thirdNumber());

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели от 1 до 7 :");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        {
            Console.WriteLine("Понедельник");
            break;
        }
    case 2:
        {
            Console.WriteLine("Вторник");
            break;
        }
    case 3:
        {
            Console.WriteLine("Среда");
            break;
        }
    case 4:
        {
            Console.WriteLine("Четверг");
            break;
        }
    case 5:
        {
            Console.WriteLine("Пятница");
            break;
        }
    case 6:
        {
            Console.WriteLine("Суббота - Выходной");
            break;
        }
    case 7:
        {
            Console.WriteLine("Воскресенье - Выходной");
            break;
        }

        
}
*/