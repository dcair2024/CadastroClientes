using Microsoft.EntityFrameworkCore;
using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace CadastroClientes.Models

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }

    }
}
