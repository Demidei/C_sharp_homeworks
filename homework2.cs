//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int NumberLenght(int NumberSub1)
{
    int countSub=1;
    int rangSub1 =10;
    while (NumberSub1/rangSub1!=0)
    {
        rangSub1 = rangSub1*10;
        countSub++;
    }
    return countSub;
}  

int DigitFinder(int NumberSub2, int PositionSub, int lenghtSub)
{
    int rangSub2 =10;
    while (PositionSub<lenghtSub)
    {
        NumberSub2=NumberSub2/rangSub2 ;
        PositionSub++;
    }
    NumberSub2 = NumberSub2%rangSub2 ;
    return NumberSub2;
}




Console.Write("input number ");
int Number=Convert.ToInt32(Console.ReadLine());
Console.Write("which digit are we looking for? ");
int position=Convert.ToInt32(Console.ReadLine());
if (position>NumberLenght(Number))
{
    Console.WriteLine("error - number is too short");
}
else
{
    Console.WriteLine($"{position}-th digit of number {Number} is {DigitFinder(Number, position, NumberLenght(Number))}");
}

*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int NumberLenght(int NumberSub1)
{
    int countSub=1;
    int rangSub1 =10;
    while (NumberSub1/rangSub1!=0)
    {
        rangSub1 = rangSub1*10;
        countSub++;
    }
    return countSub;
}  

int DigitFinder(int NumberSub2, int PositionSub, int lenghtSub)
{
    int rangSub2 =10;
    while (PositionSub<lenghtSub)
    {
        NumberSub2=NumberSub2/rangSub2 ;
        PositionSub++;
    }
    NumberSub2 = NumberSub2%rangSub2 ;
    return NumberSub2;
}




Console.Write("input number ");
int Number=Convert.ToInt32(Console.ReadLine());
Console.Write("which digit are we looking for? ");
int position=Convert.ToInt32(Console.ReadLine());
if (position>NumberLenght(Number))
{
    Console.WriteLine("error - number is too short");
}
else
{
    Console.WriteLine($"{position}-th digit of number {Number} is {DigitFinder(Number, position, NumberLenght(Number))}");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsDayOff (int Day)
{
    bool answerSub = (Day>5);
    return answerSub;
}

Console.Write("input the number of day of the week ");
int Day=Convert.ToInt32(Console.ReadLine());
if ((Day<8) && (Day>0))
{
    Console.Write($"Is day off? { IsDayOff(Day) }");
}
else
{
   Console.Write("incorrect number!"); 
}
*/