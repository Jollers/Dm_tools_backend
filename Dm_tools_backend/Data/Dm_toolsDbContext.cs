using Dm_tools_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dm_tools_backend.Data
{
    public class Dm_toolsDbContext : DbContext
    {
        public Dm_toolsDbContext(DbContextOptions<Dm_toolsDbContext>options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
