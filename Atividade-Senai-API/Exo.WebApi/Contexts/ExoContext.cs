using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlCliente;
using Microsoft.Data.SqlClient;


namespace Exo.WebApi.Contexts

{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer('Server=localhost\\SQLEXPRESS01;'
                               + 'Database=ExoApi;Trusted_Connection=True;') 
            }
        }

        public DbSet<Projeto> Projetos {get; set;}
    }
}