using System;
class Exercicio3
{
    public void Run()
    {
        Console.WriteLine("Digite a string a ser codificada:");
        string textoOriginal = Console.ReadLine();

        string textoCodificado = CodificarCesar(textoOriginal, 3);

        Console.WriteLine("String codificada:");
        Console.WriteLine(textoCodificado);
    }
    static string CodificarCesar(string texto, int deslocamento)
    {
        string resultado = "";

        foreach (char letra in texto)
        {
            if (char.IsLetter(letra))
            {
                char letraCodificada = (char)(letra + deslocamento);

                if (char.IsLower(letra) && letraCodificada > 'z')
                {
                    letraCodificada = (char)(letraCodificada - 26);
                }
                else if (char.IsUpper(letra) && letraCodificada > 'Z')
                {
                    letraCodificada = (char)(letraCodificada - 26);
                }

                resultado += letraCodificada;
            }
            else
            {
                resultado += letra;
            }
        }

        return resultado;
    }
}
