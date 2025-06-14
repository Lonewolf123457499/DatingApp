using System;
using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<AppUser> Users { get; set; } = null!;
}
