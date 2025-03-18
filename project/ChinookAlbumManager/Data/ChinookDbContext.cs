using Microsoft.EntityFrameworkCore;
using ChinookAlbumManager.Models; // Ensure this is correct

namespace ChinookAlbumManager.Data
{
    public class ChinookDbContext : DbContext
    {
        public ChinookDbContext(DbContextOptions<ChinookDbContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }
    }
}