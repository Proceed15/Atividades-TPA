        using System;
		class Program
		{
	static void Main(string[] args)
	{
		int opc;
		string Resp;

		do
		{
			Console.Clear();
			Console.WriteLine("Bem-vindo a Calculadora!");
			Console.ReadLine();
			Console.Clear();

			Console.SetCursorPosition(30, 2);
			Console.Write("Menu, Calculadora.");
			Console.SetCursorPosition(30, 6);
			Console.Write("[1]Soma.");
			Console.SetCursorPosition(30, 8);
			Console.Write("[2]Subtração.");
			Console.SetCursorPosition(30, 10);
			Console.Write("[3]Multiplicação.");
			Console.SetCursorPosition(30, 12);
			Console.Write("[4]Divisão.");
			Console.SetCursorPosition(30, 14);
			Console.Write("[5]Todas as operações apresentadas.");
			Console.SetCursorPosition(30, 18);

			Console.SetCursorPosition(30, 22);
			Console.Write("Para selecionar o tipo de operação a ser realizada, digite a sua opção por número: ");
			opc = int.Parse(Console.ReadLine());
			Console.Clear();

			switch (opc)
			{
				case 1:
					{
						Soma();
						break;
					}
				case 2:
					{
						Subtracao();
						break;
					}
				case 3:
					{
						Multiplicacao();
						break;
					}
				case 4:
					{
						Divisao();
						break;
					}
				case 5:
					{
						Tudo();
						break;
					}
				default:
					{
						Console.SetCursorPosition(30, 20);
						Console.Write("Número inválido, tente de novo!");
						Console.ReadKey();
						break;
					}
			}

			static void Soma()
			{
				int a, b;

				Console.WriteLine("Digite o primeiro número: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Digite o segundo número: ");
				b = int.Parse(Console.ReadLine());

				int resultado1 = a + b;
				Console.WriteLine("Soma: " + a + " + " + b + " = " + resultado1);
			}

			static void Subtracao()
			{
				int a, b;

				Console.WriteLine("Digite o primeiro número: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Digite o segundo número: ");
				b = int.Parse(Console.ReadLine());

				int resultado2 = a - b;
				Console.WriteLine("Subtração: " + a + " - " + b + " = " + resultado2);
			}

			static void Multiplicacao()
			{
				int a, b;

				Console.WriteLine("Digite o primeiro número: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Digite o segundo número: ");
				b = int.Parse(Console.ReadLine());
				
				int resultado3 = a * b;
				Console.WriteLine("\nMultiplicação: " + a + " * " + b + " = " + resultado3);
			}

			static void Divisao()
			{
				int a, b;

				Console.WriteLine("Digite o primeiro número: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Digite o segundo número: ");
				b = int.Parse(Console.ReadLine());
				
				int resultado4 = a / b;
				Console.WriteLine("\nDivisão: " + a + " / " + b + " = " + resultado4);
			}

			static void Tudo()
			{

				int a, b;

				Console.WriteLine("Digite o primeiro número: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Digite o segundo número: ");
				b = int.Parse(Console.ReadLine());
				Console.Clear();

				int resultado1 = a + b;
				int resultado2 = a - b;
				int resultado3 = a * b;
				int resultado4 = a / b;

				Console.WriteLine("Soma: " + a + " + " + b + " = " + resultado1);

				Console.WriteLine("\nSubtração: " + a + " - " + b + " = " + resultado2);

				Console.WriteLine("\nMultiplicação: " + a + " * " + b + " = " + resultado3);

				Console.WriteLine("\nDivisão: " + a + " / " + b + " = " + resultado4);
			}
			Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Deseja Continuar? ");
			Resp = Console.ReadLine();
		    }while (Resp == "Sim" || Resp == "S" || Resp == "sim" || Resp == "s");
		    }
}