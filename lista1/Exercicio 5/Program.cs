//declaração de variaveis
double montante; //valor total da aplicação
double p; //aplicação mensal
double i; //taxa
double n; //meses 
//Entrada de dados 
Console.WriteLine("Insira o valor da aplicação mensal, o valor da taxa e o número de meses");
p = double.Parse(Console.ReadLine());
i = double.Parse(Console.ReadLine());
n = double.Parse(Console.ReadLine());
//Processamento de dados
montante = p * ((Math.Pow(1 + i, n) - 1) / i);
//Saida de Dados
Console.WriteLine("o valor do montante é {0:c2}", montante);