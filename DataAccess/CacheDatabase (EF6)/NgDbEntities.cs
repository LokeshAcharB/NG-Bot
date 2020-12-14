using System.Data.Entity;

namespace DataAccess
{
    public class NgDbEntities : DbContext
    {
        public NgDbEntities() : base("name=NgDbEntities")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<NgDbEntities>());
            Database.SetInitializer(new NgBotDBInitializer());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<Resolution> Resolutions { get; set; }

    }
}