using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Worker> Workers { get; set; }
}