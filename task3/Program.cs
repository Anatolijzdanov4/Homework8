// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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


void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            int com = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                com = matrix1[i, k] * matrix2[k, j];
            }
            matrix3[i, j] = com; 
            
        }
       
    }

}



int[] size = ReadInt("Задайте количество строк и столбцов через пробел: ");
int[,] matrix1 = Fillmatrix(size[0], size[1], 1, 9);
int[,] matrix2 = Fillmatrix(size[0], size[1], 1, 9);
int[,] matrix3 = Fillmatrix(size[0], size[1], 1, 9);



MultiplyMatrix(matrix1, matrix2, matrix3);
System.Console.WriteLine("Произведение двух матриц:");
PrintMatrix(matrix3);
 


