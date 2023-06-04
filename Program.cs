// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] SortedToRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         bool isRowSorted = true; // флаг "isRowSorted" проверяет отсортирован массив или нет
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int n = 0; n < array.GetLength(1) - 1; n++)
//             {
//                 if (array[i, n] < array[i, n + 1])
//                 {
//                     int temp = array[i, n + 1];
//                     array[i, n + 1] = array[i, n];
//                     array[i, n] = temp;
//                     isRowSorted = false;
//                 }
//             }
//             if (isRowSorted)
//             {
//                 break;
//             }
//         }
//     }
//     return array;
// }

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] =new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue); 
// Print2DArray(myArray); 
// myArray = SortedToRows(myArray); 
// Print2DArray(myArray); 




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue) {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) {
//         for (int j = 0; j < columns; j++) {
//             array[i, j] = rnd.Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array) {
//     for(int i = 0; i < array.GetLength(0); i++) {
//         for(int j = 0; j < array.GetLength(1); j++) {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int CalculateMinSumRows(int[,] array, int rows, int columns) {
//     int rowsMin = int.MaxValue;
//     int rowsMinSum = 0;

//     for (int i = 0; i < array.GetLength(0); i++) {
//         int rowsSum = 0;
//         for (int j = 0; j < array.GetLength(1); j++) {
//             rowsSum += array[i, j];
//         }
//         if (rowsSum < rowsMin) {
//             rowsMin = rowsSum;
//             rowsMinSum = i;
//         }
//     }
//     return rowsMinSum;
// }
// Console.WriteLine("Input rows ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max value of array element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(array);
// int rowsMinSum = CalculateMinSumRows(array, rows, columns);
// Console.WriteLine("Строка с наименьшей суммой элементов:");
// Console.Write($"{rowsMinSum + 1} строка");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Input rows - ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max value of array element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] ProductTwoMatrices (int[,] myArray1, int[,] myArray2)
// {
//     int[,] resultArray = new int[rows, columns];
//     if (myArray1.GetLength(0) != myArray2.GetLength(1))
//     {
//         Console.WriteLine(" Нельзя найти произведение двух матриц!");
//         return resultArray;
//     }
//     else
//     {
//         for (int i = 0; i < myArray1.GetLength(0); i++)
//         {
//             for (int j = 0; j < myArray2.GetLength(1); j++)
//             {
//                 resultArray[i, j] = 0;
//                 for (int n = 0; n < myArray1.GetLength(1); n++)
//                 {
//                     resultArray[i, j] += myArray1[i, n] * myArray2[n, j];
//                 }
//             }  
//         }
    
//     }
// return resultArray;
// }

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] =new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray1 = Create2DRandomArray(rows, columns, minValue, maxValue); 
// int[,] myArray2 = Create2DRandomArray(rows, columns, minValue, maxValue); 
// Print2DArray(myArray1); 
// Print2DArray(myArray2); 
// int[,] resultArray = ProductTwoMatrices(myArray1, myArray2); 
// Print2DArray(resultArray); 


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] PrintIndexArray3D(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         Console.Write("\t");
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();            
//             for (int n = 0; n < array3D.GetLength(2); n++)
//             {
//                 Console.Write($"{array3D[i, j, n]}({i},{j},{n}) ");                
//             }
            
//         }        
//     }
//     return array3D;
// }

// int[,,] Create3DArray(int[,,] array3D)
// {
//     int k = 1;
    
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int n = 0; n < array3D.GetLength(2); n++)
//             {
//                 array3D[i, j, n] += k;
//                 k += 1;
//             }
//         }
//     }
//     return array3D;
// }

// int s = 2;
// int[,,] array3D = new int[s, s, s];
// Create3DArray(array3D);

// PrintIndexArray3D(array3D);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void CreateSpiralArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int count = 1;
    int last = n - 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        while (k < last)
        {
            array[i, j++] = count++;
            k++;
        }
        k = 0;
        while (k < last)
        {
            array[i++, j] = count++;
            k++;
        }
        k = 0;
        while (k < last)
        {
            array[i, j--] = count++;
            k++;
        }
        k = 0;
        while (k < last)
        {
            array[i--, j] = count++;
            k++;
        }
        ++i; ++j;
        last -= 2;
    }
}

//вывод двумерного массива, заполненного спиралью в порядке часовой стрелки
void PrintSpiralArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[4, 4];
CreateSpiralArray(array, 4);
PrintSpiralArray(array);