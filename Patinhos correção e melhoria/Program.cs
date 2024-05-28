using System;
using System.Linq;

namespace Patinhos__TPA_
{
    class Program
    {
        static void Main()
        {
            string Resp;
            int resp, utilizavel;

            //Criador: José Roberto Lisboa S. Filho. 1ºano A, DS.

            do
            {
                Console.WriteLine("\r\nAperte a tecla enter para iniciar a canção!");
                Console.ReadLine();
                Console.WriteLine("\r\nDiga quantos patinhos farão parte da canção: ");
                utilizavel = int.Parse(Console.ReadLine());
                string Qua = string.Concat(Enumerable.Repeat("Quá ", 4));
                for (resp = utilizavel - 1; resp > 1; resp--)
                {
                    Console.WriteLine(resp + 1 + " patinhos foram passear \r\n Além das montanhas \r\n Para brincar \r\n A mamãe gritou: " + Qua + " \r\n Mas só " + resp + " patinhos voltaram de lá.");
                    Console.ReadLine();
                }
                for (resp = 2; resp >= 2; resp--)
                {
                     Console.WriteLine("2 patinhos foram passear \r\n Além das montanhas \r\n Para brincar \r\n A mamãe gritou: " + Qua + " \r\n Mas só 1 patinho voltou de lá.");
                     Console.ReadLine();
                }
                for (resp = 2; resp >= 2; resp--)
                {
                    Console.WriteLine("1 patinho foi passear \r\n Além das montanhas \r\n Para brincar \r\n A mamãe gritou: " + Qua + " \r\n Mas nenhum patinho voltou de lá.");
                    Console.ReadLine();
                }
                Console.WriteLine("A mamãe patinha foi procurar \r\n Além das montanhas \r\n Na beira do mar \r\n A mamãe gritou: " + Qua + " \r\n E os " + utilizavel + " patinhos voltaram de lá.");
                Console.ReadLine();
                Console.WriteLine("Deseja Repetir a canção? ");
                Resp = Console.ReadLine();
            } while (Resp == "Sim" || Resp == "S" || Resp == "sim" || Resp == "s");
        }
    }
}