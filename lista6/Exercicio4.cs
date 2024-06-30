using System;
class Exercicio4
{
    public void Run()
    {
        StreamReader arquivo = new StreamReader("arquivos/teste.txt");
        string leitura = arquivo.ReadLine();
        contaLetrasA(leitura);
        arquivo.Close();
    }
    public void contaLetrasA(string leitura){
        int letrasA = 0;
        foreach(char character in leitura){
            if((character == 'a') || (character == 'A')){
                letrasA++;
            }
        }
        Console.WriteLine("Letras A encontradas " + letrasA);
    }
}
