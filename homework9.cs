//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void NaturalSeries(int M, int N)
{
    if (M < N)
    {
        Console.Write($"{M}, ");
        NaturalSeries(M + 1, N);
    }
    if (M == N)
    {
        Console.Write($"{M}");
    }
     if (M > N)
    {
        Console.Write($"{N}, ");
        NaturalSeries(M , N+1);
    }
}

Console.Write(" input M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write(" input N ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalSeries(M, N);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int NaturalIntervalSum(int M, int N)
{
    if (N>=M)
    {
        
        int Sum=M+NaturalIntervalSum(M + 1, N);
        return Sum;
    }
    else
    {
        return 0;
    }
}

Console.Write(" input M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write(" input N ");
int N = Convert.ToInt32(Console.ReadLine());
if (M<=N)
{
Console.Write($"Sum of natural number from {M} to {N} is {NaturalIntervalSum(M,N)}");
}
else
{
Console.Write($"Sum of natural number from {M} to {N} is {NaturalIntervalSum(N,M)}");    
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackermann(int M, int N)
{
    if (M > 0)
    {
        if (N > 0)
        {

            return Ackermann(M - 1, Ackermann(M, N - 1));
        }
        else
        {

            return Ackermann(M - 1, 1);
        }
    }
    else
    {
        return N + 1;
    }
}

Console.Write(" input M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write(" input N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ackermann function for M={M} and N={N} is {Ackermann(M, N)}");
*/

