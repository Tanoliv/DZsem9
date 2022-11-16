//  Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
 
 
Console.Write("Введите число M: ");
int M =int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N =int.Parse(Console.ReadLine()!);

SumM_N(M, N);


void SumM_N(int m, int n)
{
    Console.Write($"Сумма чисел в интервале от {M} до {N} = {SumChisel(m - 1, n)}");
}

int SumChisel(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumChisel(m, n);
        return result;
    }
}

