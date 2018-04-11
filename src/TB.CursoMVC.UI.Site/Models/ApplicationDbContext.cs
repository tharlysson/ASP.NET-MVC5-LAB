using Microsoft.AspNet.Identity.EntityFramework;

namespace TB.CursoMVC.UI.Site.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       // public System.Data.Entity.DbSet<TB.CursoMVC.Application.ViewModels.ClienteViewModel> ClienteViewModels { get; set; }
    }
}