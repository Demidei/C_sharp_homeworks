//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void ArrayFilling(int[,] arraySub1, int positionSub11, int positionSub21)
{
    if (positionSub11 > -1 && positionSub21 > -1)
    {
        arraySub1[positionSub11, positionSub21] = new Random().Next();
        ArrayFilling(arraySub1, positionSub11 - 1, positionSub21);
        ArrayFilling(arraySub1, positionSub11, positionSub21 - 1);
    }
}

void Show2dArray(int[,] arraySub1)
{
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(1); j++)
        {
            Console.Write("{0,4}", arraySub1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void HonestlyStolenInsertionSort(int[,] arraySub1)  //надо же как-то от пузырька отползать куда-то
{
    int temp1;
    int temp2;
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(1); j++)
        {
            temp1 = arraySub1[i, j];
            temp2 = j - 1;
            while (temp2 >= 0 && arraySub1[i, temp2] < temp1)
            {
                arraySub1[i, temp2 + 1] = arraySub1[i, temp2];
                temp2--;
            }
            arraySub1[i, temp2 + 1] = temp1;
        }
    }
}

Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[rows, columns];
ArrayFilling(array, rows - 1, columns - 1);
Show2dArray(array);
HonestlyStolenInsertionSort(array);
Show2dArray(array);
*/

//Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void ArrayFilling(int[,] arraySub1, int positionSub11, int positionSub21)
{
    if (positionSub11 > -1 && positionSub21 > -1)
    {
        arraySub1[positionSub11, positionSub21] = new Random().Next();
        ArrayFilling(arraySub1, positionSub11 - 1, positionSub21);
        ArrayFilling(arraySub1, positionSub11, positionSub21 - 1);
    }
}

void Show2dArray(int[,] arraySub1)
{
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(1); j++)
        {
            Console.Write("{0,4}", arraySub1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RowMinSum(int[,] arraySub1)
{
    int Min=0;
    int MinRow=0;
    for (int i = 0; i < arraySub1.GetLength(1); i++)
    {
        Min=Min+arraySub1[0,i];            
    }
     for (int i = 1; i < arraySub1.GetLength(0); i++)
    {
        int Sum=0;
        for (int j = 0; j < arraySub1.GetLength(1); j++)
    {
        Sum=Sum+arraySub1[i,j];
        if(Sum>Min)
        {
            break;
        }

    }
    if(Sum<Min)
    {
        Min=Sum;
        MinRow=i;
    }
    }
    return MinRow;
}

Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[rows, columns];
ArrayFilling(array, rows - 1, columns - 1);
Show2dArray(array);
Console.WriteLine($"Row with minimal sum is {RowMinSum(array)+1}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
void ArrayFilling(int[,] arraySub1, int positionSub11, int positionSub21)
{
    if (positionSub11 > -1 && positionSub21 > -1)
    {
        arraySub1[positionSub11, positionSub21] = new Random().Next(1, 6);
        ArrayFilling(arraySub1, positionSub11 - 1, positionSub21);
        ArrayFilling(arraySub1, positionSub11, positionSub21 - 1);
    }
}

void Show2dArray(int[,] arraySub1)
{
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(1); j++)
        {
            Console.Write("{0,4}", arraySub1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MatrixMultiplication(int[,] arraySub1, int[,] arraySub2)
{
    int [,] Matrix = new int [arraySub1.GetLength(0), arraySub2.GetLength(1)];
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub2.GetLength(1); j++)
        {
            for (int k = 0; k < arraySub1.GetLength(1); k++)
            {
               
                    Matrix[i, j] = Matrix[i, j] + (arraySub1[i, k] * arraySub2[k, j]);
               
            }
        }
    }
    return Matrix;
}

Console.Write(" input how many rows in first matrix ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in first matrix ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows, columns];
Console.Write(" input how many rows in second matrix ");
 rows = Convert.ToInt32(Console.ReadLine());
if (rows != array1.GetLength(1))
{
    Console.WriteLine("Incompatible matrices");
}
else
{
    Console.Write(" input how many columns in second matrix ");
    columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] array2 = new int[rows, columns];
    ArrayFilling(array1, array1.GetLength(0)-1, array1.GetLength(1)-1);
    ArrayFilling(array2, array2.GetLength(0)-1, array2.GetLength(1)-1);
    Show2dArray(array1);
    Show2dArray(array2);
    Show2dArray(MatrixMultiplication(array1,array2));
}
*/

//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
void ArrayFilling3D(int[,,] arraySub1)
{
    bool[] UniqueList = new bool[90];
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(1); j++)
        {
            for (int k = 0; k < arraySub1.GetLength(2); k++)
            {
                arraySub1[i, j, k] = new Random().Next(10, 100);
                while (UniqueList[arraySub1[i, j, k] - 10] == true)
                {
                    arraySub1[i, j, k] = new Random().Next(10, 100);
                }
                UniqueList[arraySub1[i, j, k] - 10] = true;
            }
        }
    }



}

void Show3dArray(int[,,] arraySub1)
{
    for (int i = 0; i < arraySub1.GetLength(2); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(0); j++)

        {
            for (int k = 0; k < arraySub1.GetLength(1); k++)
            {
                Console.Write("{0,4}", $"{arraySub1[j, k, i]} ({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many layers in array ");
int layer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (layer * rows * columns > 90)
{
    Console.WriteLine("Cannot fill array");
}
else
{
    int[,,] array = new int[rows, columns, layer];
    ArrayFilling3D(array);
    Show3dArray(array);
}
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void Show2dArray(int[,] arraySub1)
{
    for (int i = 0; i < arraySub1.GetLength(0); i++)
    {
        for (int j = 0; j < arraySub1.GetLength(1); j++)
        {
            Console.Write("{0,4}", arraySub1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SpiralFilling(int[,] arraySub1)
{
    int number = 1;
    int temp1 = 0;
    int temp2 = 0;

    while (number <= arraySub1.GetLength(0) * arraySub1.GetLength(1))
    {
        for (int i = temp2; i < arraySub1.GetLength(1); i++)
        {
            if (arraySub1[temp1, i] != 0)
            {
                temp2 = i - 1;
                break;
            }
            arraySub1[temp1, i] = number;
            number++;

            if (i == arraySub1.GetLength(1) - 1)
            {
                temp2 = i;
            }
        }

        if (arraySub1[temp1 + 1, temp2] != 0)
        {
            break;
        }

        for (int i = temp1+1; i < arraySub1.GetLength(0); i++)
        {
            if (arraySub1[i, temp2] != 0)
            {
                temp1 = i - 1;
                break;
            }
            arraySub1[i, temp2] = number;
            number++;

            if (i == arraySub1.GetLength(0) - 1)
            {
                temp1 = i;
            }
        }

        if (arraySub1[temp1, temp2 - 1] != 0)
        {
            break;
        }

        for (int i = temp2-1; i > -1; i--)
        {
            if (arraySub1[temp1, i] != 0)
            {
                temp2 = i + 1;
                break;
            }
            arraySub1[temp1, i] = number;
            number++;

            if (i == 0)
            {
                temp2 = i;
            }
        }

        if (arraySub1[temp1 - 1, temp2] != 0)
        {
            break;
        }

        for (int i = temp1-1; i > -1; i--)
        {
            if (arraySub1[i, temp2] != 0)
            {
                temp1 = i + 1;
                break;
            }
            arraySub1[i, temp2] = number;
            number++;

            if (i == arraySub1.GetLength(0) - 1)
            {
                temp1 = i;
            }
        }

        if (arraySub1[temp1, temp2 + 1] != 0)
        {
            break;
        }
        temp2++;
    }
}

Console.Write(" input how many rows in array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" input how many columns in array ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[rows, columns];
SpiralFilling(array);
Show2dArray(array);
*/

