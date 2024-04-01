using apidotnet.Data.Seed;
using apidotnet.Models;
using Microsoft.EntityFrameworkCore;


namespace apidotnet.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Pelicula> Pelicula { get; set;}

    public DbSet<Categoria> Categoria { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SeedCategoria());
        modelBuilder.ApplyConfiguration(new SeedPelicula());   
    }
}
