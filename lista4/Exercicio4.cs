using System;
public class Exercicio4
{
    public void Run()
    {
        int ladoA, ladoB, ladoC;
        bool condicaoTriangulo;
        do
        {
            Console.WriteLine("Digite três lados");
            ladoA = int.Parse(Console.ReadLine());
            ladoB = int.Parse(Console.ReadLine());
            ladoC = int.Parse(Console.ReadLine());
            condicaoTriangulo = ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB);

            if (condicaoTriangulo)
            {
                TipoTriangulo(ladoA, ladoB, ladoC);
            }
            else
            {
                Console.WriteLine("Valor invalido para triângulo");
            }
        }while(condicaoTriangulo);
        static void TipoTriangulo(int ladoA, int ladoB, int ladoC){
            if((ladoA == ladoB)&&(ladoB == ladoC)){
                Console.WriteLine("triângulo equilatero");
            }
            else if((ladoA != ladoB)&&(ladoB!=ladoC)){
                Console.WriteLine("triângulo escaleno");
            }
            else{
                Console.WriteLine("triângulo isosceles");
            }
        }
    }
}