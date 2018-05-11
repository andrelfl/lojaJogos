namespace lojaJogos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lojaJogos.Models.LojaJogosDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(lojaJogos.Models.LojaJogosDB context)
        {
            
        }
    }
}
