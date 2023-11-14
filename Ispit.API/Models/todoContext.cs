using Ispit.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API.Models
{
    public  class todoContext : DbContext
    {
        //public todoContext()
        //{
        //}

        public todoContext(DbContextOptions<todoContext> options):base(options)
        {
        }
        public  DbSet<TodoList> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QTGDNH3;database=todoispit;" +
                    "integrated security=true;MultipleActiveResultSets=true;TrustServerCertificate=true;");
            }
        }

      
    }
}
