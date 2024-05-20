using System;
public class Exercicio2{
    public void Run(){

        float salario,totalSalario=0;
        int numeroFilhos,totalFilhos=0, quantidadePessoas = 0;
        string confirm;

        do{
            Console.WriteLine("Insira seu salário e número de filhos");
            salario = float.Parse(Console.ReadLine());
            numeroFilhos = int.Parse(Console.ReadLine());
            totalSalario+=salario;
            totalFilhos+=numeroFilhos;
            quantidadePessoas++;
            Console.WriteLine("Adicionar mais um? s/n");
            confirm = Console.ReadLine();
        }while(confirm == "s");
        CalculaMedia(totalSalario, quantidadePessoas);

        static void CalculaMedia(float salario, int quantidadePessoas){
            float mediaPopulacao = salario/quantidadePessoas;
            Console.WriteLine("Media da população: " + mediaPopulacao );
        }
    }
}