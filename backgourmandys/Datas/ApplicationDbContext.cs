using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;

namespace backgourmandys.Datas;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Cake> Cakes { get; set; }
}