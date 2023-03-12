// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

void PrintArrayMy(int[,] matrixarr)
{
    for (int i = 0; i < matrixarr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixarr.GetLength(1); j++)
        {
            Console.Write(matrixarr[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int rows = ReadNumber("Введите число строк: ");
int colums = ReadNumber("Введите число столбцов: ");
int leftBorder = ReadNumber("Введите число левого края массива: ");
int rightBorder = ReadNumber("Введите число правого края массива: ");

int [,] myArray = GetRandomMatrix(rows, colums, leftBorder, rightBorder);
int[,] myMatrix = GetRandomMatrix(rows,colums,leftBorder,rightBorder);
PrintMatrix(myMatrix);
Console.WriteLine("\n\n");
PrintMatrix(myArray);
Console.WriteLine("Произведение двух матриц:");
Console.WriteLine();

int [,] matrixarr = new int [rows, colums];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
         matrixarr [i, j] = matrixarr[i, j] + (myMatrix[i, j] * myArray[i, j]);
    }
}
PrintArrayMy(matrixarr);
