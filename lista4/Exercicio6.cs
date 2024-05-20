using System;
public class Exercicio6
{
    public void Run()
    {
        int numero;
        bool respFuncao;

        do
        {
            Console.WriteLine("Digite um número positivo ou negativo");
            numero = int.Parse(Console.ReadLine());
            if (numero != 0)
            {
                respFuncao = TipoNumero(numero);
                if (respFuncao == true)
                {
                    Console.WriteLine("O número {0} é positivo", numero);
                }
                else if (respFuncao == false)
                {
                    Console.WriteLine("O número {0} é negativo", numero);
                }
            }
            else
            {
                Console.WriteLine("Seu número é 0");
            }
        } while (numero != 0);
    }
    static bool TipoNumero(int numero)
    {
        bool resp;
        if (numero > 0)
        {
            resp = true;
        }
        else
        {
            resp = false;
        }
        return resp;
    }
}