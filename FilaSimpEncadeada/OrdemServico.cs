using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaSimpEncadeada
{
	class OrdemServico
	{
		public int Numero { get; set; }
		public string Tipo { get; set; }
		public string Descricao { get; set; }
		public DateTime Data_Criacao { get; set; }
		public int Prazo { get; set; }
		public OrdemServico Proximo { get; set; }

		public override string ToString()
		{
			return "\n >>>DADOS DA O.S <<<\nNumero da O.S: " + Numero + "\nTipo: " + Tipo + "\nDescricao: " + Descricao + "\nData do Pedido: " + Data_Criacao + "\nPrazo em dias: " + Prazo;
		}
	}
}
