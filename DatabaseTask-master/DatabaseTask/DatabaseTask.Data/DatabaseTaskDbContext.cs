using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Arstid> Arstids { get; set; }
        public DbSet<MaaratudRavimid> Maaratudravimids{ get; set; }
        public DbSet<Osakond> Osakonds{ get; set; }
        public DbSet<OsakonnaInfo> OsakonnaInfos{ get; set; }
        public DbSet<Patsient> Patsients{ get; set; }
        public DbSet<Ravikulastus> Ravikulastuss{ get; set; }
        public DbSet<Ravimid> Ravimids{ get; set; }

    }
}
