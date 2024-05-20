using System;
public class Exercicio1
{
    public void Run()
    {

        float notaUm, notaDois, notaTres;
        char opcao;
        int numeroAlunos;

        Console.WriteLine("Digite a quantidade de alunos");
        numeroAlunos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroAlunos; i++)
        {
            Console.WriteLine("Digite suas três notas");
            notaUm = float.Parse(Console.ReadLine());
            notaDois = float.Parse(Console.ReadLine());
            notaTres = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("A) Média Aritmética");
            Console.WriteLine("P) Média Ponderada");
            opcao = char.Parse(Console.ReadLine());
            CalculaMedias(notaUm, notaDois, notaTres, opcao);
        }
        
        static void CalculaMedias(float a, float b, float c, char opcao)
        {
            opcao = char.ToLower(opcao);
            if (opcao == 'a')
            {
                float mediaArit = (a + b + c) / 3;
                Console.WriteLine("Media aritmética: {0:f2}", mediaArit);
            }
            else if (opcao == 'p')
            {
                float mediaPond = ((a * 5) + (b * 3) + (c * 2)) / (5 + 3 + 2);
                Console.WriteLine("Media ponderada: {0:f2}", mediaPond);
            }
            else
            {
                Console.WriteLine("Opção Invalida");
            }
        }
    }
}