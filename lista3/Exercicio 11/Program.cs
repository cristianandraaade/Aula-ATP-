using System;

class Program
{
    static void Main()
    {
        int voto, totalCandidato1 = 0, totalCandidato2 = 0, totalCandidato3 = 0, totalCandidato4 = 0;
        int totalVotosNulos = 0, totalVotosEmBranco = 0;

        Console.WriteLine("Digite o código do candidato (ou 0 para finalizar):");
        voto = int.Parse(Console.ReadLine());

        while (voto != 0)
        {
            switch (voto)
            {
                case 1:
                    totalCandidato1++;
                    break;
                case 2:
                    totalCandidato2++;
                    break;
                case 3:
                    totalCandidato3++;
                    break;
                case 4:
                    totalCandidato4++;
                    break;
                case 5:
                    totalVotosNulos++;
                    break;
                case 6:
                    totalVotosEmBranco++;
                    break;
                default:
                    Console.WriteLine("Código de voto inválido.");
                    break;
            }

            Console.WriteLine("Digite o código do próximo voto (ou 0 para finalizar):");
            voto = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Resultado da Eleição:");
        Console.WriteLine("Total de votos para o Candidato 1: " + totalCandidato1);
        Console.WriteLine("Total de votos para o Candidato 2: " + totalCandidato2);
        Console.WriteLine("Total de votos para o Candidato 3: " + totalCandidato3);
        Console.WriteLine("Total de votos para o Candidato 4: " + totalCandidato4);
        Console.WriteLine("Total de votos nulos: " + totalVotosNulos);
        Console.WriteLine("Total de votos em branco: " + totalVotosEmBranco);
    }
}
