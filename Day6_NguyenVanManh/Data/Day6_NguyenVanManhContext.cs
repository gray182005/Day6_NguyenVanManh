using Day6_NguyenVanManh.Models;
using Microsoft.EntityFrameworkCore;

public class Day6_NguyenVanManhContext(DbContextOptions<Day6_NguyenVanManhContext> options) : DbContext(options)
{
    public DbSet<Day6_NguyenVanManh.Models.Product> Product { get; set; } = default!;
    public DbSet<Genre> Genre { get; set; }

    public DbSet<Movie> Movie { get; set; }
}
