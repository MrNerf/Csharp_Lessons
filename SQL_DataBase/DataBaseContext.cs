using System.Data.Entity;

namespace SQL_DataBase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DbConnectionString")
        {
        }
        //Collection of tables
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
