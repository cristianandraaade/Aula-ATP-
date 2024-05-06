using System;

class Program
{
    static void Main()
    {
        double precoCompra, precoVenda;
        int countLucroMenor10 = 0, countLucroEntre10E20 = 0, countLucroMaior20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        Console.WriteLine("Informe o preço de compra da mercadoria (ou digite 0 para encerrar):");
        precoCompra = double.Parse(Console.ReadLine());

        while (precoCompra != 0)
        {
            Console.WriteLine("Informe o preço de venda da mercadoria:");
            precoVenda = double.Parse(Console.ReadLine());

            totalCompra += precoCompra;
            totalVenda += precoVenda;

            double lucro = precoVenda - precoCompra;
            lucroTotal += lucro;

            if (lucro < precoCompra * 0.1)
                countLucroMenor10++;
            else if (lucro >= precoCompra * 0.1 && lucro <= precoCompra * 0.2)
                countLucroEntre10E20++;
            else
                countLucroMaior20++;

            Console.WriteLine("Informe o preço de compra da próxima mercadoria (ou digite 0 para encerrar):");
            precoCompra = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mercadorias com lucro < 10%: " + countLucroMenor10);
        Console.WriteLine("Mercadorias com lucro entre 10% e 20%: " + countLucroEntre10E20);
        Console.WriteLine("Mercadorias com lucro > 20%: " + countLucroMaior20);
        Console.WriteLine("Valor total de compra: " + totalCompra);
        Console.WriteLine("Valor total de venda: " + totalVenda);
        Console.WriteLine("Lucro total: " + lucroTotal);
    }
}
