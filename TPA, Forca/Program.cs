using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        //Nome: José Roberto Lisboa S. Filho. 1ºano A, DS.
        string Resp;
        do
        {
            int Vez = 0, Pontos = 1, Pontos2 = 1;
            string Letra, Letra2, jogador1, jogador2;
            Random Seletor = new Random();

            int Chances = 8, Chances2 = 8, Letras = 0, Letras2 = 0, i, i2;
            bool Venceu = false, Venceu2 = false, Perdeu = false, Perdeu2 = false;

            string[] Lista = new string[10];
            string[] Dicas = new string[10];

            Lista[0] = "Dados"; Dicas[0] = "Informações";
            Lista[1] = "Textos"; Dicas[1] = "Páginas";
            Lista[2] = "Programacao"; Dicas[2] = "Código";
            Lista[3] = "Modo"; Dicas[3] = "Forma";
            Lista[4] = "Chances"; Dicas[4] = "Possibilidades";
            Lista[5] = "Forca"; Dicas[5] = "Momento";
            Lista[6] = "Jogo"; Dicas[6] = "Brincadeiras";
            Lista[7] = "Dois"; Dicas[7] = "Numero";
            Lista[8] = "Numero"; Dicas[8] = "Dois";
            Lista[9] = "Conclusao"; Dicas[9] = "Final.";

            int Palavra = Seletor.Next(0, 10);
            string Adivinhe = Lista[Palavra];
            string Dica = Dicas[Palavra];
            string Revele = Adivinhe.ToUpper();

            int Palavra2 = Seletor.Next(0, 10);
            string Adivinhe2 = Lista[Palavra2];
            string Dica2 = Dicas[Palavra2];
            string Revele2 = Adivinhe2.ToUpper();

            StringBuilder Mostre = new StringBuilder(Adivinhe.Length);
            StringBuilder Mostre2 = new StringBuilder(Adivinhe2.Length);
            for (i = 0; i < Adivinhe.Length; i++)
            {
                Mostre.Append('-');
            }
            for (i2 = 0; i2 < Adivinhe2.Length; i2++)
            {
                Mostre2.Append('-');
            }

            List<char> Correto = new List<char>();
            List<char> Incorreto = new List<char>();
            List<char> Correto2 = new List<char>();
            List<char> Incorreto2 = new List<char>();

            Console.WriteLine("A Forca.");
            Console.Write("\r\n╔════╗" +
                          "\r\n║" +
                          "\r\n║" +
                          "\r\n║" +
                          "\r\n║" +
                          "\r\n║" +
                          "\r\n╩══════");

            Console.SetCursorPosition(0, 10);
            Console.Write("Informe o nome do jogador 1: ");
            jogador1 = Console.ReadLine();
            Console.SetCursorPosition(0, 12);
            Console.Write("Informe o nome do jogador 2: ");
            jogador2 = Console.ReadLine();
            Console.Clear();

            char Adivinhou, Adivinhou2;

            do
            {
                while (Venceu = false || Perdeu != true)
                {
                    Console.Write("\nJogador '" + jogador1 + "' adivinhe a letra: ");
                    Letra = Console.ReadLine().ToUpper();
                    Adivinhou = Letra[0];

                    if (Correto.Contains(Adivinhou))
                    {
                        Console.WriteLine($"Você já tentou '{Adivinhou}', e estava na palavra.");
                        continue;
                    }
                    else if (Incorreto.Contains(Adivinhou))
                    {
                        Console.WriteLine($"Você já tentou '{Adivinhou}', e não estava na palavra.");
                        continue;
                    }
                    if (Revele.Contains(Adivinhou))
                    {
                        Correto.Add(Adivinhou);
                        Pontos++;

                        for (i = 0; i < Adivinhe.Length; i++)
                        {
                            if (Revele[i] == Adivinhou)
                            {
                                Mostre[i] = Adivinhe[i];
                                Letras++;
                            }
                        }
                        if (Letras == Adivinhe.Length)
                        {
                            Venceu = true;
                            if (Venceu == true)
                            {
                                Console.WriteLine($"\nParabéns, você venceu essa roda! A palavra era: {Adivinhe}.");
                                Console.ReadKey();
                                Pontos++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Incorreto.Add(Adivinhou);
                        Console.WriteLine($"Não há nenhum '{Adivinhou}' nessa palavra!");
                        Chances--;
                        string resp;
                        switch (Chances)
                        {
                            case 7:
                                {
                                    Console.WriteLine("   ☺");
                                    Pontos--;
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("   |");
                                    Pontos--;
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / ");
                                    Console.WriteLine("Quer uma dica? ");
                                    resp = Console.ReadLine();
                                    if (resp == "Sim" || resp == "sim" || resp == "S" || resp == "s")
                                    {
                                        Console.WriteLine($"A sua dica é '{Dica}'.");
                                        Pontos--;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / \\");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("  \\|");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / \\");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("  \\|/");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / \\");
                                    break;
                                }
                            case 1:
                                {
                                    Console.WriteLine($"\nSuas tentativas acabaram, a palavra era: '{Adivinhe}'");
                                    Console.Write("\r\n╔════╗" +
                                                  "\r\n║    ☺" +
                                                  "\r\n║   /|\\" +
                                                  "\r\n║    |" +
                                                  "\r\n║   / \\" +
                                                  "\r\n║     " +
                                                  "\r\n╩═══════");
                                    Console.ReadKey();
                                    Pontos--;
                                    Perdeu = true;
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    Console.WriteLine(Mostre.ToString());
                    Vez++;
                }
            } while (Vez == 1);

            Console.Clear();

            do
            {
                while (Venceu2 = false || Perdeu2 != true)
                {
                    Console.Write("\nJogador '" + jogador2 + "' adivinhe a letra: ");
                    Letra2 = Console.ReadLine().ToUpper();
                    Adivinhou2 = Letra2[0];

                    if (Correto2.Contains(Adivinhou2))
                    {
                        Console.WriteLine($"Você já tentou '{Adivinhou2}', e estava na palavra.");
                        continue;
                    }
                    else if (Incorreto2.Contains(Adivinhou2))
                    {
                        Console.WriteLine($"Você já tentou '{Adivinhou2}', e não estava na palavra.");
                        continue;
                    }
                    if (Revele2.Contains(Adivinhou2))
                    {
                        Correto2.Add(Adivinhou2);
                        Pontos2++;

                        for (i2 = 0; i2 < Adivinhe2.Length; i2++)
                        {
                            if (Revele2[i2] == Adivinhou2)
                            {
                                Mostre2[i2] = Adivinhe2[i2];
                                Letras2++;
                            }
                        }
                        if (Letras2 == Adivinhe2.Length)
                        {
                            Venceu2 = true;
                            if (Venceu2 == true)
                            {
                                Console.WriteLine($"\nParabéns, você venceu essa rodada! A palavra era: {Adivinhe2}.");
                                Console.ReadKey();
                                Pontos2++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Incorreto2.Add(Adivinhou2);
                        Console.WriteLine($"Não há nenhum '{Adivinhou2}' nessa palavra!");
                        Chances2--;
                        string resp;
                        switch (Chances2)
                        {
                            case 7:
                                {
                                    Console.WriteLine("   ☺");
                                    Pontos2--;
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("   |");
                                    Pontos2--;
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  /");
                                    Console.WriteLine("Quer uma dica? ");
                                    resp = Console.ReadLine();
                                    if (resp == "Sim" || resp == "sim" || resp == "S" || resp == "s")
                                    {
                                        Console.WriteLine($"A sua dica é '{Dica2}'.");
                                        Pontos--;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / \\");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("  \\|");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / \\");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("   ☻");
                                    Console.WriteLine("  \\|/");
                                    Console.WriteLine("   |");
                                    Console.WriteLine("  / \\");
                                    break;
                                }
                            case 1:
                                {
                                    Console.WriteLine($"\nSuas tentativas acabaram, a palavra era: '{Adivinhe2}'");
                                    Console.Write("\r\n╔════╗" +
                                                  "\r\n║    ☺" +
                                                  "\r\n║   /|\\" +
                                                  "\r\n║    |" +
                                                  "\r\n║   / \\" +
                                                  "\r\n║     " +
                                                  "\r\n╩═══════");
                                    Console.ReadKey();
                                    Pontos2--;
                                    Perdeu2 = true;
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    Console.WriteLine(Mostre2.ToString());
                    Vez++;
                }
            } while (Vez == 1);

            Console.Clear();
            Console.SetCursorPosition(40, 0);
            Console.Write("    =======Placar=final:=======");
            Console.SetCursorPosition(40, 1);
            Console.Write("╔═════════════════════════════════╗");
            Console.SetCursorPosition(40, 2);
            Console.Write(" " + jogador1 + " : " + Pontos + "");
            Console.SetCursorPosition(40, 3);
            Console.Write("╠═════════════════════════════════╣");
            Console.SetCursorPosition(40, 4);
            Console.Write(" " + jogador2 + " : " + Pontos2 + "");
            Console.SetCursorPosition(40, 5);
            Console.Write("╚═════════════════════════════════╝");
            Console.SetCursorPosition(40, 6);
            Console.ReadKey();

            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Deseja continuar? ");
            Console.SetCursorPosition(40, 13);
            Resp = Console.ReadLine();
            Console.Clear();
        } while (Resp == "Sim" || Resp == "sim" || Resp == "S" || Resp == "s");
    }
}