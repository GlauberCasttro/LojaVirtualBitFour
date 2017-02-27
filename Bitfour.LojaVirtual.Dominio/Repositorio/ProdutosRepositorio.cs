using Bitfour.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfour.LojaVirtual.Dominio.Repositorio
{

    //essa classe é para trabalhar com o entity, a partir da criacao do context 
    //pode fazer qualquer manipulaçao com os dados do banco, excluir incluir et
     public class ProdutosRepositorio
    {
         private readonly EfDbContext _context = new EfDbContext();

         public IEnumerable<Produto> Produtos
         {
             get { return _context.Produtos; }
         }

    }
}
