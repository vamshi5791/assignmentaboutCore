using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample1.Models
{
    public class mySchoolContext:DbContext
    {
        public mySchoolContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<student> students { get; set; }
        DbSet<teacher> teachers { get; set; }

    }
}
