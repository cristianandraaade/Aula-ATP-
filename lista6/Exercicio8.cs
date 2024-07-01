using System;
class Exercicio8
{
    public void Run()
    {

        Console.Write("Informe a quantidade de veículos: ");
        int veiculos = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor do aluguel por mês: ");
        double valorAluguel = double.Parse(Console.ReadLine());

        double faturamentoMensal = (veiculos * valorAluguel) / 3;

        double faturamentoAnual = faturamentoMensal * 12;

        double multaMensal = (faturamentoMensal / 10) * 0.2;

        double valorManutencaoAnual = (veiculos * 0.02) * 600;

        Console.WriteLine($"Faturamento Anual: R$ {faturamentoAnual:F2}");
        Console.WriteLine($"Valor Ganho com Multas no Mês: R$ {multaMensal:F2}");
        Console.WriteLine($"Valor Gasto com Manutenção Anual: R$ {valorManutencaoAnual:F2}");

        try
        {
            using (StreamWriter writer = new StreamWriter("arquivos/resultado.txt"))
            {
                writer.WriteLine($"Faturamento Anual: R$ {faturamentoAnual:F2}");
                writer.WriteLine($"Valor Ganho com Multas no Mês: R$ {multaMensal:F2}");
                writer.WriteLine($"Valor Gasto com Manutenção Anual: R$ {valorManutencaoAnual:F2}");
            }
            Console.WriteLine("Resultados foram gravados no arquivo resultado.txt.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Ocorreu um erro ao tentar gravar o arquivo: {e.Message}");
        }
    }
}

