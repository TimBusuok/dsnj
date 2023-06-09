// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumMassive(int num, int end)
{
    if(num == end)
    {
        return num.ToString();
    }
    return (num + ", " + NumMassive(num - 1, end));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int n = EnterData("Введите число: ");
string massive = NumMassive(n,1);
Console.WriteLine(massive);
