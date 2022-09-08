//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int SeekerOnRead(int StepSub, int SearchNumber)
{
    int count =0;
    for (int i=1; i<=StepSub; i++)    
    {
        Console.Write(" input number ");
        if (SearchNumber==Convert.ToInt32(Console.ReadLine()))
        {
            count++;
        }                    
    }
    return count;
}

Console.Write(" input how many numbers you will enter ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write(" input number to search ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Searched number {Number} was entered { SeekerOnRead (size,Number)} times");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void Intersection (double k1Sub, double k2Sub, double b1Sub, double b2Sub)
{
    double Xsub = (b2Sub-b1Sub)   /(k1Sub- k2Sub) ;
    double Ysub = k1Sub*Xsub+b1Sub;
    Console.WriteLine($"Interception point is ( {Xsub},{Ysub})");
}

Console.Write(" input k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" input b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" input k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" input b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
if (k1==k2)
{
    Console.WriteLine("lines are parallel");    
}
else
{
    Intersection ( k1,  k2,  b1,  b2);
}
*/
