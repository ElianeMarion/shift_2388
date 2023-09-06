namespace Aula01a
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Saída => Computador (aplicação) => usuário
			/*Console.WriteLine("Hello, World!");
			Console.Write("Texto");
			Console.WriteLine("Boa noite, bem vindos ao Mastering C#");
			*/
			/*Variáveis de memória -> Um espaço na memória RAM para armazenar uma informação
			nome e tipo 
			Declaração de variável no C#: tipo nome;
			 */
			int numero = 0, numero2;
			double altura;
			char letra; //1 caractere
			string nome; //texto

			//Processamento 
			//Atribuição: guardar na memória

			/*numero = 10;
			nome = "Eliane"; //texto usamos aspas
			letra = 'a'; //1 caractere usa-se apóstrofo

			//Cálculo
			numero2 = 10 + 5;
			Console.WriteLine(numero2);
			numero2 = numero + 5;
			Console.WriteLine("Resultado da soma é: " + numero2);

			//Entrada de dados => Usuário precisa enviar informações para o programa

			Console.WriteLine("Digite seu nome");
			nome = Console.ReadLine();
			Console.WriteLine("Bem vindo(a) " + nome);*/

			//Solicitar ao usuário 2 números e fazer as operação matemáticas
			//Operadores matemáticos

			/*Console.WriteLine("Digite um número: ");
			numero = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("Digite segundo número: ");
			numero2 = Convert.ToInt16(Console.ReadLine());

			int soma = numero + numero2;
			Console.WriteLine("Soma = " + soma);
			Console.WriteLine("{0} + {1} = {2}",numero,numero2, soma);

			int subtracao = numero - numero2;
			Console.WriteLine("Subtração = " + subtracao);

			int multiplicacao = numero * numero2;
			Console.WriteLine("Multiplicação = " + multiplicacao);

			int divisaoInteira = numero / numero2;
			Console.WriteLine("Divisão inteira = " + divisaoInteira);

			double divisao = numero / Convert.ToDouble(numero2);
			Console.WriteLine("Divisão = " + divisao);

			int resto = numero % numero2;
			Console.WriteLine($"Resto da divisão é: {resto}.");

			double media = (numero + numero2) / 2.0;
			Console.WriteLine("Média: {0} " , media.ToString());


			Console.WriteLine("Digite terceiro número: ");
			int numero3 = int.Parse(Console.ReadLine()); //Parse só funciona para converter texto para um tipo
			double x = double.Parse("10");*/

			/*Ocasionalmente uma ONG parceira recebe doações em dólar e precisa saber qual é o valor em reais.

			Eles pediram para que você elabore um programa que permita que o usuário digite 
			o valor da doação em dólares, converta esse valor para reais e exiba o resultado na tela.*/

			double valorDolar, valorReais;
			Console.WriteLine("Digite o valor da doação em dólares: $ ");
			valorDolar = Convert.ToDouble(Console.ReadLine());

			valorReais = valorDolar * 5.15;
			/*Console.WriteLine("Digite o valor da cotação do dólar: $ ");
			double cotacao = Convert.ToDouble(Console.ReadLine());*/
			//valorReais = valorDolar * cotacao;

			Console.WriteLine("Valor recebido em reais R$ " + valorReais);

}
}
}