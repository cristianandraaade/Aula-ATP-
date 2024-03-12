//declaração de variaveis
double hip, cat1, cat2;
//Entrada de dados
Console.WriteLine("Digite dois catetos");
cat1 = double.Parse(Console.ReadLine());
cat2 = double.Parse(Console.ReadLine());
//Processamento de dados
hip = Math.Sqrt(Math.Pow(cat1, 2) + (Math.Pow(cat2, 2)));
//Saida de dados
Console.WriteLine("O valor da hipotenusa é: {0:f2} ", hip);