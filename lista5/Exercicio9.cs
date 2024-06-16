using System;
class Exercicio9
{
    public void Run()
    {
        int[,] matrizA = new int[4, 6];
        int[,] matrizB = new int[4, 6];
        int[,] matrizS;
        int[,] matrizD;
        preencheMatrizes(matrizA, matrizB);
        matrizS = calculaMatrizS(matrizA, matrizB);
        matrizD = calculaMatrizD(matrizA, matrizB);
        for (int i = 0; i < matrizS.GetLength(0); i++)
        {
            for (int j = 0; j < matrizS.GetLength(1); j++)
            {
                Console.Write(matrizS[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < matrizD.GetLength(0); i++)
        {
            for (int j = 0; j < matrizD.GetLength(1); j++)
            {
                Console.Write(matrizD[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void preencheMatrizes(int[,] matrizA, int[,] matrizB)
    {
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizA[i, j] = i + j;
                Console.Write(matrizA[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < matrizB.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
            {
                matrizB[i, j] = i + j;
                Console.Write(matrizB[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static int[,] calculaMatrizS(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizS = new int[4, 6];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizS[i, j] += matrizA[i, j];
            }
        }
        for (int i = 0; i < matrizB.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
            {
                matrizS[i, j] += matrizB[i, j];
            }
        }
        return matrizS;
    }
    static int[,] calculaMatrizD(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizD = new int[4, 6];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizD[i, j] += matrizA[i, j];
            }
        }
        for (int i = 0; i < matrizB.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
            {
                matrizD[i, j] -= matrizB[i, j];
            }
        }
        return matrizD;
    }
}