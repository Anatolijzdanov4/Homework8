// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//Генерация массива
int[,] Fillmatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);

        }
    }
    return tempMatrix;
}

//Печать двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

//ВВод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse); ;
}


void SumLineElements(int[,] matrix)
{
    int tempSumLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
            sumLine += matrix[i, j];
        }
        return;
    }
    Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
}







int[] size = ReadInt("Задайте количество строк и столбцов через пробел: ");
int[,] matrix = Fillmatrix(size[0], size[1], 0, 9);

PrintMatrix(matrix);


System.Console.WriteLine();
SumLineElements(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);