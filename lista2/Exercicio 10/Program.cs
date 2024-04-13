using System;
class Program
{
    public static void Main()
    {
        //declaração de variavel
        int velocidadeAvenida, velocidadeMotorista, difVelocidade;
        // entrada de dados
        Console.WriteLine("Insira a velocidade máxima da avenida");
        velocidadeAvenida = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a velocidade que o motorista estava");
        velocidadeMotorista = int.Parse(Console.ReadLine());
        // processamento e saida de dados
        difVelocidade = velocidadeMotorista - velocidadeAvenida ;
        if (velocidadeMotorista <= velocidadeAvenida)
        {
            Console.WriteLine("O motorista respeitou a lei");
        }
        else
        {
            if (difVelocidade <= 10)
            {
                Console.WriteLine("Multa de 50 reais");
            }
            else if ((difVelocidade >= 11) && (difVelocidade <= 30))
            {
                Console.WriteLine("Multa de 100 reais");
            }
            else
            {
                Console.WriteLine("Multa de 200 reais");
            }
        }
    }
}

