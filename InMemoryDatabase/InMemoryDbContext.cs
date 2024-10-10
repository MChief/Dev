using InMemoryDatabase.Entities;
using Microsoft.EntityFrameworkCore;

namespace InMemoryDatabase;

public class InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
}
