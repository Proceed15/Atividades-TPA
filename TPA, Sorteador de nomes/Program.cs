using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string Resp;
        //Nome: José Roberto Lisboa S. Filho. 1ºano A, DS.
        do
        {
            string[] nome = new string[5];
            string texto;
            int i;

            Console.WriteLine("\r\nSorteador de nomes! \n");

            Console.WriteLine("Digite os nomes abaixo separados por vírgula: \n");
            texto = Console.ReadLine();
            nome = texto.Split(',');

            Console.WriteLine("Nomes a serem sorteados: ");

            for (i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"{i + 1} = {nome[i]}");
            }

            for (i = 0; i < nome.Length; i++)
            {
                while (Repetido(nome, nome[i], i))
                {
                    Console.WriteLine("\r\nAlgum nome dos digitados acima se repete. Por favor digite somente nomes diferentes. \n");
                    Console.WriteLine("Digite os nomes abaixo separados por vírgula: \n");
                    texto = Console.ReadLine();
                    nome = texto.Split(',');
                }
            }

            Console.WriteLine();

            Random random = new Random();
            nome = nome.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("Nomes que foram sorteados: \n");
            foreach (var ie in nome)
            {
                Console.WriteLine($"--> {ie}");
            }

            Console.WriteLine("\r\nDeseja continuar? ");
            Resp = Console.ReadLine();
        } while (Resp == "Sim" || Resp == "sim" || Resp == "S" || Resp == "s");

        static bool Repetido(string[] array, string frase, int f)
        {
            bool repete = false;
            int i;
            for (i = 0; i < f; i++)
            {
                if (frase == array[i])
                {
                    repete = true;
                }
            }
            return repete;
        }
    }
}