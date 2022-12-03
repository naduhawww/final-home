﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int M, int N)
{
    if (N == M) return N;
    return M + Sum(M + 1, N);
}
Console.WriteLine($"Сумма элементов в промежутке между {M} и {N} равна {Sum(M,N)} ");