// Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Генерация массива
int[,,] Fillmatrix(int row, int col, int sec, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[row, col, sec];
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        
        }
    }
    return tempMatrix;
}

//Печать двумерного массива
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($" {matrix[i, j, k]}-({i}{j}{k})" + "\t");
            }
                    
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



int[] size = ReadInt("Задайте количество строк, столбцов и секторов через пробел : ");
int[,,] matrix = Fillmatrix(size[0], size[1], size[2], 10, 100);

PrintMatrix(matrix);
