using System;

class Exercicio10
{
    public void Run()
    {
        int[,] matriz10x10 = new int[10, 10];
        preencheMatriz(matriz10x10);

        Console.WriteLine("\nMatriz original:");
        imprimeMatriz(matriz10x10);

        trocaLinhas(matriz10x10, 2, 8);
        Console.WriteLine("\nMatriz após trocar a linha 2 com a linha 8:");
        imprimeMatriz(matriz10x10);

        trocaColunas(matriz10x10, 4, 10);
        Console.WriteLine("\nMatriz após trocar a coluna 4 com a coluna 10:");
        imprimeMatriz(matriz10x10);

        trocaDiagonais(matriz10x10);
        Console.WriteLine("\nMatriz após trocar a diagonal principal com a diagonal secundária:");
        imprimeMatriz(matriz10x10);

        trocaLinhaComColuna(matriz10x10, 5, 10);
        Console.WriteLine("\nMatriz após trocar a linha 5 com a coluna 10:");
        imprimeMatriz(matriz10x10);
    }

    static void preencheMatriz(int[,] matriz)
    {
        Random sorteio = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = sorteio.Next(1, 100);
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void imprimeMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void trocaLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }
    }

    static void trocaColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }
    }

    static void trocaDiagonais(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, tamanho - 1 - i];
            matriz[i, tamanho - 1 - i] = temp;
        }
    }

    static void trocaLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho; i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna - 1];
        }
    }
}
