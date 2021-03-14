using Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Core
{
    public class RestroDbContext : DbContext
    {
        public RestroDbContext(DbContextOptions <RestroDbContext> options) : base(options)
        {

        }
       
        public DbSet<User> Users{ get; set; }
       public  DbSet<BookTable> BookTables{ get; set; }
        public DbSet<HeaderContactDetail> HeaderContactDetails{ get; set; }
        public DbSet<LinkContent> LinkContents{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        
    }
}
