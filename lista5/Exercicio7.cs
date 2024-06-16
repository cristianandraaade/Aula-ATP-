using System;
class Exercicio7
{
    public void Run()
    {
        int[,] matriz5x5 = new int[5, 5];
        int soma1, soma2, soma3, soma4, soma5;
        preencheMatriz(matriz5x5);
        soma1 = calcularSoma1(matriz5x5);
        soma2 = calcularSoma2(matriz5x5);
        soma3 = calcularSoma3(matriz5x5);
        soma4 = calcularSoma4(matriz5x5);
        soma5 = calcularSoma5(matriz5x5);
        Console.WriteLine("Resultado da Soma 1 = {0}", soma1);
        Console.WriteLine("Resultado da Soma 2 = {0}", soma2);
        Console.WriteLine("Resultado da Soma 3 = {0}", soma3);
        Console.WriteLine("Resultado da Soma 4 = {0}", soma4);
        Console.WriteLine("Resultado da Soma 5 = {0}", soma5);
    }
    static void preencheMatriz(int[,] matriz5x5)
    {
        for (int i = 0; i < matriz5x5.GetLength(0); i++)
        {
            for (int j = 0; j < matriz5x5.GetLength(1); j++)
            {
                matriz5x5[i, j] = i + j;
                Console.Write(matriz5x5[i, j] + "");
            }
            Console.WriteLine();
        }
    }
    static int calcularSoma1(int[,] matriz5x5)
    {
        int soma1 = 0;
        for (int i = 3; i < 4; i++)
        {
            for (int j = 0; j < matriz5x5.GetLength(1); j++)
            {
                soma1 += matriz5x5[i, j];
            }
        }
        return soma1;
    }
    static int calcularSoma2(int[,] matriz5x5)
    {
        int soma2 = 0;
        for (int i = 0; i < matriz5x5.GetLength(0); i++)
        {
            for (int j = 1; j < 2; j++)
            {
                soma2 += matriz5x5[i, j];
            }
        }
        return soma2;
    }
    static int calcularSoma3(int[,] matriz5x5)
    {
        int soma3 = 0;
        for (int i = 0; i < matriz5x5.GetLength(0); i++)
        {
            for (int j = 0; j < matriz5x5.GetLength(1); j++)
            {
                if (i == j)
                {
                    soma3 += matriz5x5[i, j];
                }
            }
        }
        return soma3;
    }
    static int calcularSoma4(int[,] matriz5x5)
    {
        int soma4 = 0;
        int n = matriz5x5.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            soma4 += matriz5x5[i, n - 1 - i];
        }
        return soma4;
    }
    static int calcularSoma5(int[,] matriz5x5)
    {
        int soma5 = 0;
        for (int i = 0; i < matriz5x5.GetLength(0); i++)
        {
            for (int j = 0; j < matriz5x5.GetLength(1); j++)
            {
                soma5+=matriz5x5[i,j];
            }
        }
        return soma5;
    }
}
