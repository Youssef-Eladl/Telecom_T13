namespace Telecom_T13.Data
{
    using Microsoft.EntityFrameworkCore;
    using Telecom_T13.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer_Profile> Customer_Profiles { get; set; }
    }

}
