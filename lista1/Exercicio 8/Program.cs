//declaração de variaveis
int num,u,d,c,numINV,soma1,mi,ce,de,uni,mS;
//Entrada de dados
Console.WriteLine("Insira 3 digitos");
num=int.Parse(Console.ReadLine());
//Processamento de dados
//1- Encontrar numero invertido
c=num/100;
d=(num%100)/10;
u=(num%100)%10;
numINV= u*100 + d*10 +c;
//2- somar número + número invertido
soma1=num+numINV;
Console.WriteLine("A soma é " + soma1);
//-3 multiplicar pela posição

mi= soma1/1000;
Console.WriteLine("valor milhar " + mi);
ce= (soma1%1000)/100;
Console.WriteLine("valor centena " + ce);
de= (soma1%100)/10;
Console.WriteLine("valor dezena " + de );
uni=soma1%10;
Console.WriteLine("valor unidade " + uni);
mS=(mi*0) + (ce*1)+(de*2)+(uni*3);

Console.WriteLine("Soma das multiplicações " + mS);

//4-digito verificador

int ver= mS%10;
Console.WriteLine("O digito verificador é " + ver);