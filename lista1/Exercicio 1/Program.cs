//declaração de variaveis
int b, altura, perim, area;
double diago;
//Entrada de dados
Console.WriteLine("Digite base e altura");
b = int.Parse(Console.ReadLine());
altura = int.Parse(Console.ReadLine());
//Processamento de dados
area = b * altura;
perim = 2 * (b + altura);
diago = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(altura, 2));
//Saida de Dados
Console.WriteLine("O valor da área é: " + area);
Console.WriteLine("O valor do perimetro é: " + perim);
Console.WriteLine("O valor da diagonal é {0:f2} ",diago);