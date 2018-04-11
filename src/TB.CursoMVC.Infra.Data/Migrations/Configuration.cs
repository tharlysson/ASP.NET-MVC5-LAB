using System.Data.Entity.Migrations;
using TB.CursoMVC.Infra.Data.Context;

namespace TB.CursoMVC.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CursoMvcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}