// See https://aka.ms/new-console-template for more information
using System;

namespace TPA__Csharp_1
{

    class Program
    {
        private static int i;

        static void Main(string[] args)
        {

            //Criado por José Roberto Lisboa S. Filho em 2021.

            int opc;

            do
            {

                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.Write("MENU, vetores, matrizes e funções em CSharp");
                Console.SetCursorPosition(30, 1);
                Console.Write("======================");
                Console.SetCursorPosition(30, 5);
                Console.Write("[1]Data");
                Console.SetCursorPosition(30, 7);
                Console.Write("[2]Regiao");
                Console.SetCursorPosition(30, 9);
                Console.Write("[3]Ate_1000");
                Console.SetCursorPosition(30, 11);
                Console.Write("[4]Tabuada");
                Console.SetCursorPosition(30, 13);
                Console.Write("[5]Fim");


                Console.SetCursorPosition(30, 17);
                Console.Write("========================");
                Console.SetCursorPosition(30, 19);
                Console.Write("Digite a sua opção(por número): ");
                opc = int.Parse(Console.ReadLine());
                Console.Write("================================\n");



                switch (opc)
                {
                    case 1:
                        {
                            Data();
                            break;
                        }
                    case 2:
                        {
                            Regiao();
                            break;
                        }
                    case 3:
                        {
                            Ate_1000();
                            break;
                        }
                    case 4:
                        {
                            Tabuada();
                            break;
                        }
                    case 5:
                        {
                            Fim();
                            break;
                        }
                    default:
                        {
                            Console.SetCursorPosition(30, 20);
                            Console.Write("Opção Inválida, tente de novo!");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (opc != 5);

        }

        static void Data()
        {
            //Data.
            string[] dia = { "", "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };
            string[] mes = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string Resp;
            string data;
            int posicao;


            do
            {

                Console.Clear();

                Console.Write("Encontrando o nome do dia da semana ou mes...");

                Console.Write("======================================");


                Console.Write("\n\nDigite um número (1 a 12): ");

                posicao = int.Parse(Console.ReadLine());


                Console.Write("Deseja consultar o dia da semana (D) ou o mes (M)? ");

                data = Console.ReadLine();


                if (data == "d" || data == "D")
                {
                    if (posicao < 1 || posicao > 7)
                    {
                        Console.Write("___Dia da semana inválido!");

                    }


                    else
                    {
                        Console.Write("___" + posicao + " corresponde a " + dia[posicao]);

                    }
                }


                else if (data == "m" || data == "M")
                {
                    if (posicao < 1 || posicao > 12)
                    {
                        Console.Write("___Mês inválido!");

                    }


                    else
                    {
                        Console.Write("___" + posicao + " corresponde a " + mes[posicao]);

                    }
                }

                Console.Write("\n___Deseja continuar(S/N)? ");

                Resp = Console.ReadLine();


            } while (Resp == "Sim" || Resp == "S" || Resp == "sim" || Resp == "s");
        }

        static void Regiao()
        {
            //Região.
            string[,] estado = new string[27, 2];
            string texto, resp;
            bool achou;


            do
            {
                //Estrutura de Matrix.
                estado[0, 0] = "AC"; estado[0, 1] = "Acre";
                estado[1, 0] = "AL"; estado[1, 1] = "Alagoas";
                estado[2, 0] = "AP"; estado[2, 1] = "Amapá";
                estado[3, 0] = "AM"; estado[3, 1] = "Amazonas";
                estado[4, 0] = "BA"; estado[4, 1] = "Bahia";
                estado[5, 0] = "CE"; estado[5, 1] = "Ceará";
                estado[6, 0] = "DF"; estado[6, 1] = "Distrito Federal";
                estado[7, 0] = "ES"; estado[7, 1] = "Espírito Santo";
                estado[8, 0] = "GO"; estado[8, 1] = "Goiás";
                estado[9, 0] = "MA"; estado[9, 1] = "Maranhão";
                estado[10, 0] = "MT"; estado[10, 1] = "Mato Grosso";
                estado[11, 0] = "MS"; estado[11, 1] = "Mato Grosso do Sul";
                estado[12, 0] = "MG"; estado[12, 1] = "Minas Gerais";
                estado[13, 0] = "PA"; estado[13, 1] = "Pará";
                estado[14, 0] = "PB"; estado[14, 1] = "Paraíba";
                estado[15, 0] = "PR"; estado[15, 1] = "Paraná";
                estado[16, 0] = "PE"; estado[16, 1] = "Pernambuco";
                estado[17, 0] = "PI"; estado[17, 1] = "Piauí";
                estado[18, 0] = "RJ"; estado[18, 1] = "Rio de Janeiro";
                estado[19, 0] = "RN"; estado[19, 1] = "Rio Grande do Norte";
                estado[20, 0] = "RS"; estado[20, 1] = "Rio Grande do Sul";
                estado[21, 0] = "RO"; estado[21, 1] = "Rondônia";
                estado[22, 0] = "RR"; estado[22, 1] = "Roraima";
                estado[23, 0] = "SC"; estado[23, 1] = "Santa Catarina";
                estado[24, 0] = "SP"; estado[24, 1] = "São Paulo";
                estado[25, 0] = "SE"; estado[25, 1] = "Sergipe";
                estado[26, 0] = "TO"; estado[26, 1] = "Tocantins";

                Console.Clear();
                Console.Write("*** Pesquisando Estados ***\n");
                Console.Write("===========================\n\n");

                Console.Write("Informe uma sigla ou um estado: ");
                string str2 = Console.ReadLine();
                texto = str2.ToUpper();

                achou = false;
                for (i = 0; i < 27; i++)
                {

                    if (texto == estado[i, 0])
                    {
                        Console.Write("___" + texto + " corresponde a " + estado[i, 1] + "\n\n");
                        achou = true;
                        break;
                    }
                    if (texto == estado[i, 1])
                    {
                        Console.Write("___" + texto + " corresponde a " + estado[i, 0] + "\n\n");
                        achou = true;
                        break;
                    }
                };

                if (achou == false)
                {
                    Console.Write("___Sigla ou estado não cadastrado.");
                }

                Console.Write("\n___Deseja continuar?(S/N) ");
                resp = Console.ReadLine();

            } while (resp == "Sim" || resp == "S" || resp == "sim" || resp == "s");
        }

        static void Ate_1000()
        {
            //Ate_1000.
            string[] unidade = { "zero", "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seicentos", "setecentos", "oitocentos", "novecentos" };
            string Resp;


            int n, nd, ne, dd;



            do
            {

                Console.Clear();

                Console.Write("Esperando o seu número (até mil)...\n");

                Console.Write("=====================\n");


                Console.Write("___Digite um número inteiro: ");

                n = int.Parse(Console.ReadLine());



                if (n < 0 || n > 1000)
                {
                    Console.Write("___Número fora dos limites estabelecidos");

                }

                else if (n < 20)
                {
                    Console.Write(unidade[n]);

                }
                else if (n < 100)
                {
                    ne = n / 10;



                    nd = n % 10;




                    Console.Write(dezena[ne]);



                    if (nd > 0)
                    {
                        Console.Write(" e " + unidade[nd]);

                    }
                }

                else if (n > 100 && n < 1000)
                {
                    ne = n / 100;


                    dd = n % 100;



                    Console.Write(centena[ne]);


                    if (dd > 0 && dd <= 19)
                    {
                        Console.Write(" e " + unidade[dd]);
                    }


                    else if (dd >= 20)
                    {
                        Console.Write(" e " + dezena[dd / 10]);


                        int x = dd % 10;

                        if (x != 0)
                        {
                            Console.Write(" e " + unidade[x]);

                        }
                    }
                }


                else if (n == 100)
                {
                    Console.Write("Cem");

                }

                else if (n == 1000)
                {
                    Console.Write("Mil");


                }

                Console.Write("\n___Deseja continuar(S/N)?");

                Resp = Console.ReadLine();


            } while (Resp == "Sim" || Resp == "S" || Resp == "sim" || Resp == "s");

        }

        static void Tabuada()
        {
            //Tabuada.

            int x, y;
            string pausa;



            Console.Write("\n\n\t\t\t\t\t\t  ##Bem vindo ao programa de##");


            Console.Write("\n\t\t\t\t\t\t             Tabuada!");
            Console.Write("\n\t\t\t\t\t\t  =============================\n\n");

            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 5; x++)
                {
                    Console.Write("\t" + x + " x " + y + " = " + x * y + "\t");

                }
                Console.Write("\n");
            }
            Console.Write("\n\t____________________________________________________________________________________________________________");

            Console.Write("\n");

            for (y = 1; y <= 10; y++)
            {

                for (x = 6; x <= 10; x++)
                {
                    Console.Write("\t" + x + " x " + y + " = " + x * y + "\t");

                }
                Console.Write("\n");
            }
            Console.Write("Aperte a tecla 'Enter' for voltar ao menu anterior. ");

            pausa = Console.ReadLine();

        }

        static void Fim()
        {
            //Fim.
            string pausa;
            Console.Write("Programa encerrado, tenha um Bom dia!");
            pausa = Console.ReadLine();
        }
    }
}
