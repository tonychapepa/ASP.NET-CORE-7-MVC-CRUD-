
using ControleContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleContactos.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        public DbSet<ContactoModel> contacto  { get; set; }
        public DbSet<UsuarioModel> usuario { get; set; }
    }
}
