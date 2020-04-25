using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace General.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    //کلاس مربوط به مایگریشن
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //سازنده  که از بیس یکسری اطلاعات را می گیرد
        //که تمامی سناریو را پیاده سازی می کند 
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        //دیتابیس را می سازد
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
         static ApplicationDbContext ()
        {
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
        }

        public System.Data.Entity.DbSet<General.Models.Personel> Personels { get; set; }

        public System.Data.Entity.DbSet<General.Models.Utilities.Mounth> Mounths { get; set; }

        public System.Data.Entity.DbSet<General.Models.Utilities.Year> Years { get; set; }

        public System.Data.Entity.DbSet<General.Models.BaseSalary> BaseSalaries { get; set; }

        public System.Data.Entity.DbSet<General.Models.Salary> Salaries { get; set; }
    }
}