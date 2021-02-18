using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaSimpEncadeada
{
	class Program
	{
		static void Main(string[] args)
		{
			FilaOS minhaFila = new FilaOS { Head = null, Tail = null, Cont = 0 };

			
			int op, busc;

			do
			{
				Console.WriteLine("\nInforme a opcao desejada\n"
					+ "1 - Cadastrar Ordem de Servico\n"
					+ "2 - Remover Ordem de Servico\n"
					+ "3 - Imprimir Ordens de Servico\n"
					+ "4 - Quantidade de de Ordens de servico\n"
					+ "5 - Busca pelo numero da Ordem de Servico\n"
					+ "0 - Sair");
				op = int.Parse(Console.ReadLine());

				switch (op)
				{
					case 1:
						
						OrdemServico os = new OrdemServico();

						Console.WriteLine("Informe o numero da Ordem de Servico: ");
						os.Numero = int.Parse(Console.ReadLine());
						Console.WriteLine("Tipo de Servico: ");
						os.Tipo = Console.ReadLine();
						Console.WriteLine("Descricao do Servico");
						os.Descricao = Console.ReadLine();
						os.Data_Criacao = DateTime.Now;
						Console.WriteLine("Prazo estimado: ");
						os.Prazo = int.Parse(Console.ReadLine());
						os.Proximo = null; 
					
						minhaFila.Push(os);
						break;
					case 2:
						minhaFila.Pop();
						break;
					case 3:
						minhaFila.Print();
						break;
					case 4:
						Console.WriteLine("Quantidade de Ordem de Servico: ");
						Console.WriteLine(minhaFila.Cont);
						break;
					case 5:
						Console.WriteLine("Informe a Ordem de Servico a ser localizada");
						busc = int.Parse(Console.ReadLine());
						minhaFila.Search(busc);
						break;
					case 0:
						break;
				}
			} while (op != 0);
		}
	}
}
