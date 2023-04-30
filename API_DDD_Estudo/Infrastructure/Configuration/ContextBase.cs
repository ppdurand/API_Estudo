using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }

        public DbSet<Menssage> Menssages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        //Caso a string de conexão não for configurada na Program, será aqui
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
                base.OnConfiguring(optionsBuilder); 
            }
        }
        //
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("Users").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }

        public string GetConnectionString()
        {
            return "DESKTOP-PD4CO0C\\SQLSERVEREXPRESS;Initial Catalog=API_DDD_2022;Integrated Security=False;User ID=sa;Password=0x020007B0EBF38F2E36A20596650ECA89D8BBAF24E35D8970DD57E894F7C6906507423D7A1187924BE9F94A75F6655D4E80874501D0BC166EE4C572B8DA1E81567CE757E1477D;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        }
    }
}
