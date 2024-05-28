using System;

class Program
{

    static void Main()
    {
        string Resp;
        do
        {
            Console.Write("\r\nDigite uma frase: ");
            string frase = Console.ReadLine();
            string Entrada = frase.ToLower();
            int vcontador = 0, vacontador = 0, vecontador = 0, vicontador = 0, vocontador = 0, vucontador = 0, ccontador = 0, espacocontador = 0;

            //Criador: José Roberto Lisboa S. Filho. 1ºano A, DS.

            for (int i = 0; i < Entrada.Length; i++)
            {
                if (Entrada[i] >= 'a' && Entrada[i] <= 'z')
                {
                    if (Entrada[i] == 'a' || Entrada[i] == 'e' || Entrada[i] == 'i' || Entrada[i] == 'o' || Entrada[i] == 'u')
                    {
                        vcontador++;
                        if (Entrada[i] == 'a')
                        {
                            vacontador++;
                        }
                        if (Entrada[i] == 'e')
                        {
                            vecontador++;
                        }
                        if (Entrada[i] == 'i')
                        {
                            vicontador++;
                        }
                        if (Entrada[i] == 'o')
                        {
                            vocontador++;
                        }
                        if (Entrada[i] == 'u')
                        {
                            vucontador++;
                        }
                    }
                    else
                    {
                        ccontador++;
                    }
                }
                else
                {
                    espacocontador++;
                }
            }
            Console.WriteLine($"Número de vogais: {vcontador}: \r\nA's: {vacontador}. \r\nE's: {vecontador}. \r\nI's: {vicontador}. \r\nO's: {vocontador}. \r\nU's: {vucontador}.");
            Console.WriteLine($"Número de consoantes: {ccontador}");
            Console.WriteLine($"Número de não alfanuméricos: {espacocontador}");
            Console.WriteLine($"\r\nDeseja contar novamente? ");
            Resp = Console.ReadLine();
        } while (Resp == "Sim" || Resp == "sim" || Resp == "S" || Resp == "s");
    }
}