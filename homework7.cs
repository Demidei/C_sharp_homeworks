//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void ArrayFillingDouble(double [,] arraySub1, int positionSub11,int positionSub21)
{
    if(positionSub11>-1 && positionSub21>-1)
    {
        arraySub1[positionSub11,positionSub21]= new Random().NextDouble();       
        ArrayFillingDouble(arraySub1, positionSub11-1, positionSub21); 
        ArrayFillingDouble(arraySub1, positionSub11,positionSub21-1); 
    }
}

void Show2dArray ( double [,] arraySub1)
{
    for(int i = 0; i< arraySub1.GetLength(0); i++)
    {
       for(int j = 0; j< arraySub1.GetLength(1); j++) 
       {
            Console.Write(arraySub1[i,j]+" ");        
       }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] array =new double [rows, columns];
ArrayFillingDouble (array, rows-1, columns-1);
Show2dArray (array);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
double ElementSearch (double [,] arraysub, int row, int col)
{
    return arraysub[row,col];
}

void ArrayFillingDouble(double [,] arraySub1, int positionSub11,int positionSub21)
{
    if(positionSub11>-1 && positionSub21>-1)
    {
        arraySub1[positionSub11,positionSub21]= new Random().NextDouble();       
        ArrayFillingDouble(arraySub1, positionSub11-1, positionSub21); 
        ArrayFillingDouble(arraySub1, positionSub11,positionSub21-1); 
    }
}


Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] array =new double [rows, columns];
ArrayFillingDouble (array, rows-1, columns-1);

Console.Write(" input searched row ");
rows = Convert.ToInt32(Console.ReadLine());
if(rows<=array.GetLength(0) && rows>-1)
{
    Console.Write(" input searched col ");
    columns = Convert.ToInt32(Console.ReadLine());
    if(columns<=array.GetLength(1) && columns>-1)
    {
        Console.WriteLine($"Searched element is { ElementSearch(array, rows-1,columns-1)}");
    }
    else
    {
        Console.WriteLine($"There is no such element");    
    }
}
else
{
    Console.WriteLine($"There is no such element");    
}
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void ArrayFilling(int [,] arraySub1, int positionSub11,int positionSub21)
{
    if(positionSub11>-1 && positionSub21>-1)
    {
        arraySub1[positionSub11,positionSub21]= new Random().Next(1,4);       
        ArrayFilling(arraySub1, positionSub11-1, positionSub21); 
        ArrayFilling(arraySub1, positionSub11,positionSub21-1); 
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

double[] ArrayOfColAvg (int [,] arraySub1)
{
    double [] arrayofavgofcol = new double[arraySub1.GetLength(1)];
    for (int i=0; i<arraySub1.GetLength(1); i++)
    {
        for (int j=0; j<arraySub1.GetLength(0); j++)
        {
            arrayofavgofcol[i]=arrayofavgofcol[i]+arraySub1[j,i]; 
        }        
        arrayofavgofcol[i]=arrayofavgofcol[i]/arraySub1.GetLength(0);
    }
    return arrayofavgofcol;
}

void Show2dArray ( int [,] arraySub1)
{
    for(int i = 0; i< arraySub1.GetLength(0); i++)
    {
       for(int j = 0; j< arraySub1.GetLength(1); j++) 
       {
            Console.Write(arraySub1[i,j]+" ");        
       }
        Console.WriteLine();
    }
    Console.WriteLine();
}




Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array =new int [rows, columns];
ArrayFilling (array, rows-1, columns-1);
Show2dArray(array);
ArrayShowing(ArrayOfColAvg(array));
*/
