using System;
using System.Text;
class Exercicio9
{
    public void Run()
    {
        int opcao;
        Console.WriteLine("Selecione a opção do programa");
        Console.WriteLine("0 PARA INSERIR DADOS ||| 1 PARA LER OS DADOS");
        opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 0:
                recebeDados();
                break;
            case 1:
                leDados();
                break;
        }
    }
    public void recebeDados()
    {
        int matricula;
        string telefone;
        StreamWriter escreve = new StreamWriter("arquivos/teste4.txt", true, Encoding.ASCII);
        do
        {
            Console.WriteLine("Insira a matricula do aluno");
            matricula = int.Parse(Console.ReadLine());
            if (matricula != 0)
            {
                Console.WriteLine("Insira o telefone do aluno");
                telefone = Console.ReadLine();
                escreve.WriteLine("Matricula " + matricula + " Telefone " + telefone);
            }
        } while (matricula != 0);
        escreve.Close();
    }
    public void leDados()
    {
        string linha;
        StreamReader leitura = new StreamReader("arquivos/teste4.txt");
        linha = leitura.ReadLine();
        while(linha != null){
            Console.WriteLine(linha);
            linha = leitura.ReadLine();
        }        
    }
}
