using System;
class Program
{
    public static void Main()
    {
        //declaração de variaveis
        int anoAtual = 2024;
        int anoNascimento, idadeAtual;
        char valid;

        //Entrada de dados
        Console.WriteLine("Digite o ano que vocé nasceu ");
        anoNascimento = int.Parse(Console.ReadLine());
        Console.WriteLine("Você já fez aniversário este ano?(Responda Com S ou N)");
        valid = char.Parse(Console.ReadLine());
        idadeAtual = anoAtual - anoNascimento;
        // Processamento de dados

        switch (valid)
        {
            case 'S':
                Console.WriteLine("Você possuí " +  idadeAtual  + " anos");
                if (idadeAtual >= 18)
                {
                    Console.WriteLine("Você pode conseguir a carteira de habilitação");
                }
                else
                {
                    Console.WriteLine("Você não pode conseguir a carteira de habilitação");
                }
                break;
            case 'N':
                idadeAtual--;
                Console.WriteLine("Você possuí " +  idadeAtual  + " anos");
                if (idadeAtual >= 18)
                {
                    Console.WriteLine("Você pode conseguir a carteira de habilitação");
                }
                else
                {
                    Console.WriteLine("Você não pode conseguir a carteira de habilitação");
                }
                break;    
        }
    }
}
