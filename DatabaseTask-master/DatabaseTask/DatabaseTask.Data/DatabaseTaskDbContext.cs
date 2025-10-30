using System.Collections;
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
        public DbSet<Absense> Absense { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<ChildGroupHistory> ChildGroupHistory { get; set; }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Queues> Queue { get; set; }



    }
}
