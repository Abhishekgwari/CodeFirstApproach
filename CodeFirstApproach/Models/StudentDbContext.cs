using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Models
{
    public class StudentDbContext:DbContext                // inherit from DbContext
    {

        public StudentDbContext(DbContextOptions options) : base(options)    // 
        {
            
        }
        public DbSet<Student> Students { get; set; }                         // Db set property  
                                                        // it represents table of our database   table name will be Students
    }
}
