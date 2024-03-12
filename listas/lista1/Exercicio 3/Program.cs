//declaração de variaveis
double salario, watt, val_1kw, val_pagar, val_desconto;
//Entrada de dados
Console.WriteLine(" Digite o valor de um salário mínimo ");
salario = double.Parse(Console.ReadLine());
Console.WriteLine(" Digite a quantidade de quilowatts gasta na residencia");
watt = double.Parse(Console.ReadLine());
//Processamento de dados
val_1kw = salario / 7 / 100;
val_pagar = watt * val_1kw;
val_desconto = val_pagar * 0.9;
//saida de dados
Console.WriteLine("o valor em reais de cada kilowatt: {0:f2}", val_1kw);
Console.WriteLine("o valor a ser pago: {0:f2}", val_pagar);
Console.WriteLine("o valor com desconto: {0:f2}", val_desconto);