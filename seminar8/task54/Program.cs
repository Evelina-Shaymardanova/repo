// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы 
// каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int z = 0; z < matrix.GetLength(1)-1; z++)
            {
                if (matrix[i, z] > matrix[i, z + 1])
                {
                    int temp = 0;
                    temp = matrix[i,z];
                    matrix[i, z] = matrix[i, z + 1];
                    matrix[i, z + 1] = temp;
                }
            }
        }
    }
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


int rows = ReadNumber("Введите число строк: ");
int colums = ReadNumber("Введите число столбцов: ");
int leftBorder = ReadNumber("Введите число левого края массива: ");
int rightBorder = ReadNumber("Введите число правого края массива: ");

int[,] myMatrix = GetRandomMatrix(rows,colums,leftBorder,rightBorder);
PrintMatrix(myMatrix);
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(myMatrix);
PrintMatrix(myMatrix);