//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int NumberLenght(int NumberSub1)
{
    if (NumberSub1>9)
    {
        int countSub = NumberLenght(NumberSub1/10)+1;
        return countSub;
    }
    else
    {
        return 1;
    }
    
}  

bool IsPalindrome ( int[] NumberSub, int positionsub, int NumberLengthSub)
{
    if (positionsub<(NumberLengthSub-positionsub-1))
    {
        if (NumberSub[positionsub]==NumberSub[NumberLengthSub-positionsub-1])
        {
            bool answerSub2 = true && IsPalindrome (NumberSub, positionsub+1, NumberLengthSub);
            return answerSub2;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return true;
    }
}


void ArrayFilling (int [] ArraySub, int NumberSub, int NumberLengthSub)
{
    int countSub2 =NumberLengthSub-1;
    while (countSub2>-1)
    {
        ArraySub[countSub2]=NumberSub%10;
        NumberSub=NumberSub/10;
        countSub2--;
    }
}

Console.Write(" input number ");
int Number = Convert.ToInt32(Console.ReadLine());
if (NumberLenght(Number)==1)
{
    Console.WriteLine("Is palindrome - true ");
}
else
{
    int [] NumberArray = new int [NumberLenght(Number)];  
    int PositionNumber = 0;
    ArrayFilling (NumberArray, Number,NumberLenght(Number));
    Console.WriteLine($"Is palindrome - {IsPalindrome(NumberArray,PositionNumber, NumberLenght(Number))} ");
}    
*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance ( double X1Sub, double X2Sub, double Y1Sub, double Y2Sub, double Z1Sub, double Z2Sub)
{
    double temp = Math.Round(Math.Sqrt((X1Sub-X2Sub)*(X1Sub-X2Sub)+(Y1Sub-Y2Sub)*(Y1Sub-Y2Sub)+(Z1Sub-Z2Sub)*(Z1Sub-Z2Sub)),2);
    return temp;
}

Console.Write(" input X coordinates of first point ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" input Y coordinates of first point ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" input Z coordinates of first point ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" input X coordinates of second point ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" input Y coordinates of second point ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" input Z coordinates of second point ");
double Z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Distance between points is {Distance(X1,X2,Y1,Y2,Z1,Z2)}");
*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void ThirdDegreeList ( int numberSub)
{
    if (numberSub!=1)
    {
        Console.Write("1, ");
        int countSub = 2;
        while (count<numberSub)
        {
            Console.Write($"{countSub*countSub*countSub}, ");
            countSub++;
        }
        Console.Write($"{numberSub*numberSub*numberSub}");
    }
    else
    {
        Console.Write("1");
    }        
}

Console.Write(" input number ");
int Number = Convert.ToInt32(Console.ReadLine());
if ((Number!=0))
{
    ThirdDegreeList(Number);
}
else
{
    Console.Write("0");
}
*/