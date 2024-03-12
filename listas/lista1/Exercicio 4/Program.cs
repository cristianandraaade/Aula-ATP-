//declaração de variaveis
double distanc, xA, yA, xB, yB;
Console.WriteLine("Escreva as coordenadas do ponto A (xA, yA)");
xA = double.Parse(Console.ReadLine());
yA = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva as coordenadas do ponto B (xB, yB)");
xB = double.Parse(Console.ReadLine());
yB = double.Parse(Console.ReadLine());
//Processamento de Dados
distanc = Math.Sqrt(Math.Pow(xB - xA, 2) + (Math.Pow(yB - yA, 2)));
//Saida de Dados
Console.WriteLine("A distância entre os pontos A e B é {0:f2}", distanc);