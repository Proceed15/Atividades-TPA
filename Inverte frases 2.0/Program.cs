using System;
using System.Linq;
using static System.Console;
namespace CShp_StringReverse
{
    class Program
    {

        //Criador: José Roberto Lisboa S. Filho. 1ºano A, DS.

        public static string InverteString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("Digite uma frase");
            texto = Console.ReadLine();
            WriteLine($"Texto Normal   : {texto}");
            string textoInvertido = new string(texto.Reverse().ToArray());
            WriteLine($"Texto Invertido: {textoInvertido}");
        }
    }
}
