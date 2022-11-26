// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillMatrix(int matrixLen)
{
    int N, M;
    N = M = matrixLen;
    int[,] matrix = new int[N, M];

    
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M){
        matrix[i,j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1)){
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }

    return matrix;
}


void PrintMatrix(int[,] array)
{
    int arrLen = array.GetLength(0);
    string txt = "";
    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrLen; j++)
        {
            txt = string.Format("{0:d2}", array[i, j]);
            Console.Write($"{txt} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(4);
PrintMatrix(matrix);