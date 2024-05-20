using System;
public class Exercicio7
{
    public void Run()
    {
        int mediaAlunos, quantidadeAlunos;

        Console.WriteLine("Digite o número de alunos");
        quantidadeAlunos = int.Parse(Console.ReadLine());
        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            Console.WriteLine("Digite a média do aluno");
            mediaAlunos = int.Parse(Console.ReadLine());
            AnalisaMedia(mediaAlunos);
        }
    }
    static void AnalisaMedia(int mediaAlunos)
    {
        char conceito;

        if (mediaAlunos <= 39)
        {
            conceito = 'F';
            Console.WriteLine("Sua média foi {0} e seu conceito foi {1}", mediaAlunos, conceito);

        }
        else if ((mediaAlunos >=40)&&(mediaAlunos <=59))
        {
            conceito = 'E';
            Console.WriteLine("Sua média foi {0} e seu conceito foi {1}", mediaAlunos, conceito);
        }
        else if ((mediaAlunos >=60)&&(mediaAlunos <=69))
        {
            conceito = 'D';
            Console.WriteLine("Sua média foi {0} e seu conceito foi {1}", mediaAlunos, conceito);
        }
        else if ((mediaAlunos >=70)&&(mediaAlunos <=79))
        {
            conceito = 'C';
            Console.WriteLine("Sua média foi {0} e seu conceito foi {1}", mediaAlunos, conceito);
        }
        else if ((mediaAlunos >=80)&&(mediaAlunos <=89))
        {
            conceito = 'B';
            Console.WriteLine("Sua média foi {0} e seu conceito foi {1}", mediaAlunos, conceito);
        }
        else
        {
            conceito = 'A';
            Console.WriteLine("Sua média foi {0} e seu conceito foi {1}", mediaAlunos, conceito);
        }
    }
}