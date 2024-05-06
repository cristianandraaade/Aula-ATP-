using System;
class Program
{
    public static void Main()
    {
        // declaração de variaveis
        int numeroFilhos = 0, qtdSalario = 0, qtdFilhos = 0, totalFilhos = 0;
        float salarioMensal = 0, mediaSalario = 0, mediaFilhos = 0, maiorSalario = 0, percentPessoas100 = 0, totalSalario = 0, qtdAte100 = 0;
        // entrada de dados
        do
        {
            Console.WriteLine("Insira seu salário");
            salarioMensal = float.Parse(Console.ReadLine());
            if (salarioMensal > 0)
            {
                Console.WriteLine("Insira seu número de filhos");
                numeroFilhos = int.Parse(Console.ReadLine());
                totalFilhos+=numeroFilhos;
                qtdFilhos++;
                totalSalario+=salarioMensal;
                qtdSalario++;
                if (maiorSalario < salarioMensal){
                    maiorSalario = salarioMensal;
                }
                if (salarioMensal <=100.00){
                    qtdAte100++;
                }
            }
        } while (salarioMensal > 0);
        mediaSalario = totalSalario/qtdSalario;
        mediaFilhos = totalFilhos/qtdFilhos;
        percentPessoas100 = (qtdAte100/(float)qtdSalario)*100;
        Console.WriteLine("A média do salario é " + mediaSalario);
        Console.WriteLine("A média do número de filhos é " + mediaFilhos);
        Console.WriteLine("O maior salario é " + maiorSalario);
        Console.WriteLine("O percentual de pessoas com salario até 100,00 é {0:f2}%",percentPessoas100);
    }
}