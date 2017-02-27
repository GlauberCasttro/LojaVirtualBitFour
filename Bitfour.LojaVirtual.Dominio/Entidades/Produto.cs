using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfour.LojaVirtual.Dominio.Entidades
{
   public class Produto
    {
        public int ProdudtoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string categoria { get; set; }
    }
}
