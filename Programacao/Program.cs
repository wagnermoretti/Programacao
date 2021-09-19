using System;
using System.Collections;

namespace Programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a palavra inicial: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("Entre com a letra que deseja remover: ");
            char letra = char.Parse(Console.ReadLine());
            ArrayList myAL = new ArrayList();


            var charArray = palavra.ToCharArray();
            char[] final = new char[charArray.Length - 1];
            var contador = 0;

            for (int i = 0; i < charArray.Length-1; i++)
            {
                if(charArray[i] != letra)
                {
                    final[contador] = charArray[i];
                    contador++;
                }
            }
            string s = new string(final);
            Console.WriteLine(s.Replace(" ", ""));
            Console.WriteLine(palavra.Length);
            Console.WriteLine(s.Replace(" ", "").Length);
        }
    }
}
