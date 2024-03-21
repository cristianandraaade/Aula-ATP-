//declaração de variaveis
int tempo,a,m,d;
//Entrada de dados
Console.WriteLine("Insira o número de dias sem acidentes");
tempo=int.Parse(Console.ReadLine());
//processamento de dados
a=tempo/365;
m=(tempo%365)/30;
d=(tempo%365)%30;
//saida de dados
Console.WriteLine("Dias sem acidentes: "+ a + " ano(s) " + m + " mes(es) " + d + " dia(s) ");
