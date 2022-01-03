namespace CBoardings.Data
{
    public class BoardingDbContext : DbContext
    {
        public BoardingDbContext(DbContextOptions<BoardingDbContext> options) : base(options)
        {
        }
        public DbSet<Boarding> Boardings { get; set; }

    }
}
\