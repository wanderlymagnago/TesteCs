using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro.Models;

namespace SistemaDeCadastro.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
