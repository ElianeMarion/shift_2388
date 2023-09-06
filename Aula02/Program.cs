namespace Aula02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Solitar o salário do funcionário
			 * Verificar qual faixa de desconto
			 * calcular o desconto e exibir 
			 * salário bruto, o desconto, salario líquido*/
			/*double salario, descontoINSS, salarioLiquido;
			Console.WriteLine("Digite seu salário: R$ ");
			salario= double.Parse(Console.ReadLine());
			//salario = Convert.ToDouble(Console.ReadLine());
			if(salario <= 1045)
			{
				descontoINSS = salario * 0.075; //  7,5 / 100 | salario * 7.5 / 100
				salarioLiquido = salario - descontoINSS;
				Console.WriteLine("Salário R$ " + salario +
								  "\nAlíquota: 7,5 % - Desconto: R$ " + descontoINSS +
								  "\nSalário liquido: R$ " + salarioLiquido);
			}
			else if(salario <= 2089.60)
			{
				descontoINSS = salario * 0.09; //  9 / 100 | salario * 9 / 100
				salarioLiquido = salario - descontoINSS;
				Console.WriteLine("Salário R$ " + salario +
								  "\nAlíquota: 9 % - Desconto: R$ " + descontoINSS +
								  "\nSalário liquido: R$ " + salarioLiquido);
			}
			else if (salario <= 3134.40)
			{
				descontoINSS = salario * 0.12; //  12 / 100 | salario * 12 / 100
				salarioLiquido = salario - descontoINSS;
				Console.WriteLine("Salário R$ " + salario +
								  "\nAlíquota: 12 % - Desconto: R$ " + descontoINSS +
								  "\nSalário liquido: R$ " + salarioLiquido);
			}
			else if (salario <= 6101.06)
			{
				descontoINSS = salario * 0.14; //  14 / 100 | salario * 14 / 100
				salarioLiquido = salario - descontoINSS;
				Console.WriteLine("Salário R$ " + salario +
								  "\nAlíquota: 14 % - Desconto: R$ " + descontoINSS +
								  "\nSalário liquido: R$ " + salarioLiquido);
			}
			else
			{
				descontoINSS = 877.24; 
				salarioLiquido = salario - descontoINSS;
				Console.WriteLine("Salário R$ " + salario +
								  "\nDesconto do Teto: R$ " + descontoINSS +
								  "\nSalário liquido: R$ " + salarioLiquido);
			}


			/*
			int num;
			Console.WriteLine("Digite um número: ");
			num = Convert.ToInt32(Console.ReadLine());
			if(num == 0)
			{
				Console.WriteLine("Zero");
			}
			else if (num > 0 ) {
				Console.WriteLine("Número Positivo");
			}
			else
			{
				Console.WriteLine("Número Negativo");
			}
			//Verificar se o número é par
			int x = 10;
			if(x%2 == 0) // x = 2 => Atribuindo 2 na variável x | Comparação usamos ==
			{
				Console.WriteLine($"{x} é par");
			}
			*/
			//Pedir para o usuário digitar 2 notas e calcular a média
			//media >= 7 aluno aprovado, senão se media < 4 reprovado senão está de exame

			double nota1, nota2, media;
			Console.WriteLine("Digite a primeira nota: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a segunda nota: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2)/2;
			if(media >= 7)
			{
				Console.WriteLine($"Aluno aprovado com média {media}");
			}
			else if (media < 4)
			{
				Console.WriteLine($"Aluno reprovado com média {media}");
			}
			else
			{
				Console.WriteLine("Aluno de exame.\nDigite a nota do exame: ");
				double exame = Convert.ToDouble(Console.ReadLine());
				double novaMedia = (exame + media) / 2;
				if(novaMedia >= 6)
					Console.WriteLine($"Aluno aprovado no exame com média {novaMedia}");
				else
					Console.WriteLine($"Aluno reprovado no exame com média {novaMedia}");
			}
			/*int idade;
			Console.WriteLine("Informe sua idade");
			idade = Convert.ToInt32(Console.ReadLine());
			if (idade >= 18) {
				Console.WriteLine("Bem vindo ao sistema");
				Console.WriteLine("Você pode assistir o filme");
				Console.WriteLine("Você pode dirigir");
			}
			else
			{
				Console.WriteLine("Você não pode assistir o filme");
			}
			Console.WriteLine("Fora da decisão, todos visualizam");
			
			*/
			/*
			Console.WriteLine(@"
███████╗██╗░█████╗░██████╗░  ██████╗░░█████╗░███╗░░██╗░█████╗░████████╗██╗░█████╗░███╗░░██╗
██╔════╝██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║
█████╗░░██║███████║██████╔╝  ██║░░██║██║░░██║██╔██╗██║███████║░░░██║░░░██║██║░░██║██╔██╗██║
██╔══╝░░██║██╔══██║██╔═══╝░  ██║░░██║██║░░██║██║╚████║██╔══██║░░░██║░░░██║██║░░██║██║╚████║
██║░░░░░██║██║░░██║██║░░░░░  ██████╔╝╚█████╔╝██║░╚███║██║░░██║░░░██║░░░██║╚█████╔╝██║░╚███║
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░░░░  ╚═════╝░░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝

░██████╗██╗░░░██╗░██████╗████████╗███████╗███╗░░░███╗
██╔════╝╚██╗░██╔╝██╔════╝╚══██╔══╝██╔════╝████╗░████║
╚█████╗░░╚████╔╝░╚█████╗░░░░██║░░░█████╗░░██╔████╔██║
░╚═══██╗░░╚██╔╝░░░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║
██████╔╝░░░██║░░░██████╔╝░░░██║░░░███████╗██║░╚═╝░██║
╚═════╝░░░░╚═╝░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝");

			Console.WriteLine("Boas vindas ao FIAP Donation System!");
			Thread.Sleep(3000);
			Console.Clear();

			Console.WriteLine("**********************");
			Console.WriteLine("Registro de usuário");
			Console.WriteLine("**********************\n");
			//Nome, telefone, email, senha, apelido.
			string nome, telefone, email, senha, apelido;
			Console.Write("Digite o nome do usuário que deseja registrar: ");
			nome = Console.ReadLine();
			Console.Write("Digite o telefone do usuário: ");
			telefone = Console.ReadLine();
			Console.Write("Digite o email do usuário: ");
			email = Console.ReadLine();
			Console.Write("Digite a senha do usuário: ");
			senha = Console.ReadLine();
			Console.Write("Digite o apelido do usuário: ");
			apelido = Console.ReadLine();
			Console.ReadKey();*/
		}
	}
}