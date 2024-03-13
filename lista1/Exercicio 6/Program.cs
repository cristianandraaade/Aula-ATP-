// declaração de variaveis
int a,b,aux;
// entrada de dados
Console.WriteLine("Insira o valor de A");
a=int.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor de B");
b=int.Parse(Console.ReadLine());
//Processamento de dados
aux=a;
a=b;
b=aux;
//saida de dados
Console.WriteLine("O valor de A é " + a);
Console.WriteLine("O valor de B é "+ b);

