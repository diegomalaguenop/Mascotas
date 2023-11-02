#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace Mascotas.Models;

public class MyContext : DbContext
{
    public DbSet<Mascota> Mascotas {get; set;}
    public MyContext(DbContextOptions options) : base(options) {}
}