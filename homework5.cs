//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
void ArrayFilling(int [] arraySub1, int positionSub1)
{
    if(positionSub1>-1)
    {
        arraySub1[positionSub1]= new Random().Next();       
        ArrayFilling(arraySub1, positionSub1-1); 
    }
}

void ArrayShowing(int [] arraySub1)
{
    Console.Write("["); 
    for (int i=0; i<arraySub1.Length-1; i++)
    {
        Console.Write($"{arraySub1[i]}, ");     
    }  
    Console.WriteLine($"{arraySub1[arraySub1.Length-1]}]");   
}

int EvenNumberCounts (int [] arraySub1)
{
    int Count=0;
    for (int i=0; i<arraySub1.Length; i++)
    {
        if (arraySub1[i]%2==0)
        {
            Count++;
        }        
    }  
    return Count;
}

Console.Write(" input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
ArrayFilling(array, size-1);
ArrayShowing(array);
Console.WriteLine($"Even numbers count is {EvenNumberCounts(array)}");
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
void ArrayFilling(int [] arraySub1, int positionSub1)
{
    if(positionSub1>-1)
    {
        arraySub1[positionSub1]= new Random().Next();       
        ArrayFilling(arraySub1, positionSub1-1); 
    }
}

void ArrayShowing(int [] arraySub1)
{
    Console.Write("["); 
    for (int i=0; i<arraySub1.Length-1; i++)
    {
        Console.Write($"{arraySub1[i]}, ");     
    }  
    Console.WriteLine($"{arraySub1[arraySub1.Length-1]}]");   
}

double OddIndexSum (int [] arraySub1)
{
    int Sum=0;
    for (int i=1; i<arraySub1.Length; i=i+2)
    {
        Sum=Sum+arraySub1[i];      
    }  
    return Sum;
}

Console.Write(" input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
ArrayFilling(array, size-1);
ArrayShowing(array);
Console.WriteLine($"Odd index sum is {OddIndexSum(array)}");
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
void ArrayFillingDouble(double [] arraySub1, int positionSub1)
{
    if(positionSub1>-1)
    {
        arraySub1[positionSub1]= new Random().NextDouble();       
        ArrayFillingDouble(arraySub1, positionSub1-1); 
    }
}

void ArrayShowing(double [] arraySub1)
{
    Console.Write("["); 
    for (int i=0; i<arraySub1.Length-1; i++)
    {
        Console.Write($"{arraySub1[i]}, ");     
    }  
    Console.WriteLine($"{arraySub1[arraySub1.Length-1]}]");   
}

double  DiffMaxMin(double [] arraySub1)
{
    double  max=arraySub1[0];
    double  min=arraySub1[0];
    for (int i=1; i<arraySub1.Length; i++)
    {
        if (max<arraySub1[i])
        {
            max=arraySub1[i];    
        }     
        else if(min>arraySub1[i])
        {
            min=arraySub1[i];
        }
    }  
    return max-min;
}

Console.Write(" input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [size];
ArrayFillingDouble(array, size-1);
ArrayShowing(array);
Console.WriteLine($"Difference between max and min is {DiffMaxMin(array)}");
*/

//Четвертая задача семинара

void ArrayFilling(int [] arraySub1, int positionSub1, int min, int max)
{
    if(positionSub1>-1)
    {
        arraySub1[positionSub1]= new Random().Next(min, max+1);       
        ArrayFilling(arraySub1, positionSub1-1,min, max); 
    }
}

void ArrayShowing(int [] arraySub1)
{
    Console.Write("["); 
    for (int i=0; i<arraySub1.Length-1; i++)
    {
        Console.Write($"{arraySub1[i]}, ");     
    }  
    Console.WriteLine($"{arraySub1[arraySub1.Length-1]}]");   
}

void NewArrayGeneration (int [] ArraySub1,int [] newarray)
{
    
    for (int i=0; i<ArraySub1.Length/2; i++)
    {
        newarray[i]=ArraySub1[i]*ArraySub1[(ArraySub1.Length-1)-i];
    }    
    if (ArraySub1.Length%2!=0)
    {
        newarray[newarray.Length-1]=ArraySub1[ArraySub1.Length/2+1] ;
    }
}

Console.Write(" input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
ArrayFilling(array, size-1, 1,6);
int [] newarray = new int [(size/2)+(size%2)];
ArrayShowing(array);
NewArrayGeneration (array,newarray);
ArrayShowing(newarray);