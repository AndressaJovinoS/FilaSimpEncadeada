using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaSimpEncadeada
{
	class FilaOS
	{
		public OrdemServico Head { get; set; }
		public OrdemServico Tail { get; set; }
		public int Cont { get; set; }

		public bool Vazia()
		{
			if ((Head == null) && (Tail == null))
				return true;
			return false;
		}

		public void Push(OrdemServico aux)
		{
			if (Vazia())
			{
				Head = aux;
				Tail = aux;
			}
			else
			{
				Tail.Proximo = aux;
				Tail = aux;
			}
			Cont++;
			Console.WriteLine("Inserido com sucesso! ");
			Console.ReadKey();
		}

		public void Print()
		{
			if (Vazia())
			{
				Console.WriteLine("Impossivel imprimir, Fila Vazia! ");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("\n>>> As Ordens de Servicos sao: <<<\n");
				OrdemServico aux = Head;
				do
				{
					Console.WriteLine(aux.ToString());
					aux = aux.Proximo;
				} while (aux != null);
				Console.WriteLine("\n >>> FIM <<<");
			}
		}

		public void Pop()
		{
			if (Vazia())
			{
				Console.WriteLine("Impossivel remover, Fila Vazia! ");
				Console.ReadKey();
			}
			else
			{
				Head = Head.Proximo;
				Cont--;
				Console.WriteLine("Removido com sucesso! ");

				if (Head == null)
				{
					Tail = null;
					Console.WriteLine("Fila vazia novamente! ");
					Console.ReadKey();
				}
			}
		}

		public void Search(int busc)
		{
			bool found = false;

			if (Vazia())
			{
				Console.WriteLine("Impossivel encontrar, Fila Vazia! ");
				Console.ReadKey();
			}
			else
			{
				OrdemServico aux = Head;
				do
				{
					if (busc == aux.Numero)
					{
						Console.WriteLine(">>> Ordem encontrada! <<<\n" + aux.ToString());
						found = true;
					}
					aux = aux.Proximo;
				} while (aux != null);
				Console.WriteLine("\n >>> FIM <<<");
			}
		}
	}
}
