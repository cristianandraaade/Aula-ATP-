using System;
using System.IO;

class Program
{
    static string[] produtos; // Vetor para armazenar os nomes dos produtos
    static int[] estoque; // Vetor para armazenar a quantidade em estoque de cada produto
    static int[,] vendas; // Matriz para armazenar as vendas diárias dos produtos

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1 – Importar arquivo de produtos");
            Console.WriteLine("2 – Registrar venda");
            Console.WriteLine("3 – Relatório de vendas");
            Console.WriteLine("4 – Relatório de estoque");
            Console.WriteLine("5 – Criar arquivo de vendas");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha uma opção: ");
            
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 6)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Escolha uma opção válida: ");
            }

            switch (opcao)
            {
                case 1:
                    ImportarArquivoProdutos();
                    break;
                case 2:
                    RegistrarVenda();
                    break;
                case 3:
                    RelatorioVendas();
                    break;
                case 4:
                    RelatorioEstoque();
                    break;
                case 5:
                    CriarArquivoVendas();
                    break;
                case 6:
                    Console.WriteLine("Encerrando o programa...");
                    break;
            }

        } while (opcao != 6);
    }

    static void ImportarArquivoProdutos()
    {
        string nomeArquivo = "produtos.txt";

        try
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            int numProdutos = linhas.Length;

            produtos = new string[numProdutos];
            estoque = new int[numProdutos];

            for (int i = 0; i < numProdutos; i++)
            {
                string[] dadosProduto = linhas[i].Split(',');
                produtos[i] = dadosProduto[0];
                estoque[i] = int.Parse(dadosProduto[1]);
            }

            Console.WriteLine("Arquivo de produtos importado com sucesso.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao importar arquivo: {e.Message}");
        }
    }

    static void RegistrarVenda()
    {
        if (produtos == null)
        {
            Console.WriteLine("É necessário importar o arquivo de produtos primeiro.");
            return;
        }

        if (vendas == null)
        {
            vendas = new int[produtos.Length, 30]; // 30 dias para o mês
        }

        Console.Write("Digite o número do produto (1 a " + produtos.Length + "): ");
        int numProduto = int.Parse(Console.ReadLine()) - 1;

        if (numProduto < 0 || numProduto >= produtos.Length)
        {
            Console.WriteLine("Produto inválido.");
            return;
        }

        Console.Write("Digite o dia do mês (1 a 30): ");
        int dia = int.Parse(Console.ReadLine()) - 1;

        if (dia < 0 || dia >= 30)
        {
            Console.WriteLine("Dia inválido.");
            return;
        }

        Console.Write("Digite a quantidade vendida: ");
        int quantidadeVendida = int.Parse(Console.ReadLine());

        if (quantidadeVendida <= 0)
        {
            Console.WriteLine("Quantidade inválida.");
            return;
        }

        if (quantidadeVendida > estoque[numProduto])
        {
            Console.WriteLine("Não há estoque suficiente para realizar esta venda.");
            return;
        }

        vendas[numProduto, dia] += quantidadeVendida;
        estoque[numProduto] -= quantidadeVendida;

        Console.WriteLine("Venda registrada com sucesso.");
    }

    static void RelatorioVendas()
    {
        if (produtos == null)
        {
            Console.WriteLine("É necessário importar o arquivo de produtos primeiro.");
            return;
        }

        Console.WriteLine("Relatório de Vendas:");
        Console.Write("Produto\t");
        for (int dia = 1; dia <= 30; dia++)
        {
            Console.Write($"Dia {dia}\t");
        }
        Console.WriteLine();

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.Write($"{produtos[i]}\t");
            for (int dia = 0; dia < 30; dia++)
            {
                Console.Write($"{vendas[i, dia]}\t");
            }
            Console.WriteLine();
        }
    }

    static void RelatorioEstoque()
    {
        if (produtos == null)
        {
            Console.WriteLine("É necessário importar o arquivo de produtos primeiro.");
            return;
        }

        Console.WriteLine("Relatório de Estoque:");
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"{produtos[i]}: {estoque[i]}");
        }
    }

    static void CriarArquivoVendas()
    {
        if (produtos == null)
        {
            Console.WriteLine("É necessário importar o arquivo de produtos primeiro.");
            return;
        }

        try
        {
            using (StreamWriter writer = new StreamWriter("total_vendas.txt"))
            {
                for (int i = 0; i < produtos.Length; i++)
                {
                    int totalVendas = 0;
                    for (int dia = 0; dia < 30; dia++)
                    {
                        totalVendas += vendas[i, dia];
                    }
                    writer.WriteLine($"{produtos[i]} {totalVendas}");
                }
            }

            Console.WriteLine("Arquivo de vendas criado com sucesso.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao criar arquivo: {e.Message}");
        }
    }
}
