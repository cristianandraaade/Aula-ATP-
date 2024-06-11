using System;
class Program
{
    public static void Main()
    {
        int opcao;
        string? resp = "n";
        do
        {
            Console.WriteLine("Informe:");
            Console.WriteLine("1) Para executar o exercicio 1.");
            Console.WriteLine("2) Para executar o exercicio 2.");
            Console.WriteLine("3) Para executar o exercicio 3.");
            Console.WriteLine("4) Para executar o exercicio 4.");
            Console.WriteLine("5) Para executar o exercicio 5.");
            Console.WriteLine("6) Para executar o exercicio 6.");
            Console.WriteLine("7) Para executar o exercicio 7.");
            Console.WriteLine("8) Para executar o exercicio 8.");
            Console.WriteLine("9) Para executar o exercicio 9.");
            Console.WriteLine("10) Para executar o exercicio 10.");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    Exercicio1 exercicio1 = new Exercicio1();
                    exercicio1.Run();
                    break;
                case 2:
                    Exercicio2 exercicio2 = new Exercicio2();
                    exercicio2.Run();
                    break;
                case 3:
                    Exercicio3 exercicio3 = new Exercicio3();
                    exercicio3.Run();
                    break;
                case 4:
                    Exercicio4 exercicio4 = new Exercicio4();
                    exercicio4.Run();
                    break;
                case 5:
                    Exercicio5 exercicio5 = new Exercicio5();
                    exercicio5.Run();
                    break;
                case 6:
                    Exercicio6 exercicio6 = new Exercicio6();
                    exercicio6.Run();
                    break;
                case 7:
                    Exercicio7 exercicio7 = new Exercicio7();
                    exercicio7.Run();
                    break;
                case 8:
                    Exercicio8 exercicio8 = new Exercicio8();
                    exercicio8.Run();
                    break;
                case 9:
                    Exercicio9 exercicio9 = new Exercicio9();
                    exercicio9.Run();
                    break;
                case 10:
                    Exercicio10 exercicio10 = new Exercicio10();
                    exercicio10.Run();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.WriteLine("Deseja executar novamente? (s/n)");
            resp = Console.ReadLine();
        } while (resp.ToLower().Equals("s"));
    }
}