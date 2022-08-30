//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Empower(int NumberSub, int degreeSub)
{
    double result = 1;
    if (degreeSub<0)
    {
        for (int i =1; i<=degreeSub*-1; i++)
        {
            result = result*NumberSub;
        }
        result=1/result;
    }
    else
    {
        for (int i =1; i<=degreeSub; i++)
        {
            result = result*NumberSub;
        } 
    }
    return result;
}

Console.Write(" input Number ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write(" input degree ");
int degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Number} to the power of {degree} equals {Empower(Number,degree)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigit(int NumberSub1)
{
    if (NumberSub1>0)
    {
        int countSub = SumDigit(NumberSub1/10)+NumberSub1%10;
        return countSub;
    }
    else
    {
        return 0;
    }
    
}  

Console.Write(" input number ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number>0)
{
    Console.WriteLine($"Digit sum in {Number} is {SumDigit(Number)}");    
}
else
{
    Console.WriteLine($"Digit sum in {Number} is {SumDigit(Number*-1)}");     
}
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void ArrayManualFilling(int [] arraySub1, int positionSub1)
{
    for (int i=1; i<=positionSub1; i++)
    {
        Console.Write($" input {i} of array ");
        arraySub1[i-1] = Convert.ToInt32(Console.ReadLine());
    }
}

void ArrayShowing(int [] arraySub1, int positionSub1)
{
    Console.Write("["); 
    for (int i=0; i<positionSub1-1; i++)
    {
        Console.Write($"{arraySub1[i]}, ");     
    }  
    Console.WriteLine($"{arraySub1[positionSub1-1]}]");   
}

Console.Write(" input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
ArrayManualFilling(array, size);
ArrayShowing(array, size);
*/
