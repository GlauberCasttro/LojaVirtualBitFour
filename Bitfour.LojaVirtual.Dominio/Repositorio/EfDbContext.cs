using Bitfour.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfour.LojaVirtual.Dominio.Repositorio
{

    //essa classe serve para fazer
    //o mapeamento das classes do seu sistema com o banco de dados
    public class EfDbContext : DbContext
    {
        //primeiramente mapeia a classe de produto que foi criado
        //para trabalhar com entity é somente fazer essa referencia para qualquer classe do sistema
        //e todo o trabalho de mapeamento quem faz é o entity


        //dbset sao todas as referencias das entidades do sistema com o banco que o entity faz
        public DbSet<Produto> Produtos { get; set; }







        //remove a pluralizaçao do banco com o sistema, ex computadores ele conevrete para computador
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }

}
