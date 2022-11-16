// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите число:\t");
int N =int.Parse(Console.ReadLine()!);

PrintNum( N, 1);

void PrintNum(int n, int m)
{
    if (m > n) return ;   
    
    else
    {
        PrintNum(n, m + 1);
        Console.Write($"{m + " "}| ");
    }
}   
