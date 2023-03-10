// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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
    int minsum = Int32.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            index++;
        }
    }
     Console.WriteLine("Строка с наименьшей суммой элементов под номером: " + (index) + ", с суммой элементов равной: " + (minsum));
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
Console.WriteLine();
PrintArray(myMatrix);
PrintMatrix(myMatrix);