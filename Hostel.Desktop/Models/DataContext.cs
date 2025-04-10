using Microsoft.EntityFrameworkCore;

namespace Hostel.Desktop.Models;

public class DataContext : DbContext
{
    private const string ConnectionString = "Server=127.0.0.1;Port=5432;Database=hostel_db;User Id=postgres;Password=1234;";

    public DbSet<Room> Rooms { get; set; }

    public DataContext() : base()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}
