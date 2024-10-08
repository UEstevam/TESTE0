using Microsoft.EntityFrameworkCore;
using src.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
    {

    }

    public DbSet<Usuario> usuarios { get; set; }
}