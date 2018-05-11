using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace lojaJogos.Models {
    public class LojaJogosDB : DbContext {

        public LojaJogosDB() : base("lojaJogosDBConnectionString")
        { }

        // identificar as tabelas da base de dados
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<Jogos> Jogos { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }

        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder"> objeto que referencia o gerador de base de dados </param>      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}