using System;
class Exercicio8
{
    public void Run()
    {
        int[,] matriz4x4 = new int[4, 4];
        preencheMatriz(matriz4x4);
        diagonalPrincipal(matriz4x4);
    }
    static void preencheMatriz(int[,] matriz4x4)
    {
        for (int i = 0; i < matriz4x4.GetLength(0); i++)
        {
            for (int j = 0; j < matriz4x4.GetLength(1); j++)
            {
                matriz4x4[i, j] = i + j;
                Console.Write(matriz4x4[i, j] + "");
            }
            Console.WriteLine();
        }
    }
    static void diagonalPrincipal(int[,] matriz4x4)
    {
        int somaDiagonal = 0;
        for (int i = 1; i < matriz4x4.GetLength(0); i++) // Começa do índice 1 para abaixo da diagonal
        {
            for (int j = 0; j < i; j++)
            {
                somaDiagonal += matriz4x4[i, j];
                Console.Write(matriz4x4[i,j]);
            }
        }
        Console.WriteLine("Soma dos números abaixo da diagonal principal " + somaDiagonal);
    }
}
