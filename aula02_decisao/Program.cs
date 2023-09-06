namespace aula02_decisao
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Solitar o salário do funcionário
			 * Verificar qual faixa de desconto
			 * calcular o desconto e exibir 
			 * salário bruto, o desconto, salario líquido*/
			double salario, descontoINSS, salarioLiquido;
			double aliquota = 0, teto = 0;
			Console.WriteLine("Digite seu salário: R$ ");
			salario = double.Parse(Console.ReadLine());
			//salario = Convert.ToDouble(Console.ReadLine());
			if (salario <= 1045)
			{
				aliquota = 7.5;
			}
			else if (salario <= 2089.60)
			{
				aliquota = 9;
			}
			else if (salario <= 3134.40)
			{
				aliquota= 12;
			}
			else if (salario <= 6101.06)
			{
				aliquota= 14;
			}
			else
			{
				teto = 877.24;
			}

			if (teto == 0)
				descontoINSS = salario * (aliquota / 100);
			else
				descontoINSS = 877.24;
			salarioLiquido = salario - descontoINSS;
			Console.WriteLine("Salário R$ " + salario +
							  "\nDesconto: R$ " + descontoINSS +
							  "\nSalário liquido: R$ " + salarioLiquido);
		}
	}
}