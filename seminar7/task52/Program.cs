// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix (int rows, int colums, int leftBorder, int rightBorder)
{
    int [,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }

}

void PrintArray(int [,] myMatrix)
{
    double sum = 0;
    for (int j = 0; j < myMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            sum += myMatrix[i,j];            
        }
        Console.Write($"{sum / myMatrix.GetLength(0)}");
    }
    Console.ReadLine();    
}

int rows = ReadNumber("Введите число строк: ");
int colums = ReadNumber("Введите число столбцов: ");
int leftBorder = ReadNumber("Введите число левого края массива: ");
int rightBorder = ReadNumber("Введите число правого края массива: ");

int[,] myMatrix = GetRandomMatrix(rows,colums,leftBorder,rightBorder);
PrintMatrix(myMatrix);
PrintArray(myMatrix);