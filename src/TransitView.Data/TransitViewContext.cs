using Microsoft.Data.Entity;

namespace TransitView.Data
{
    public class TransitViewContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=Database.db");
        }
    }
}
