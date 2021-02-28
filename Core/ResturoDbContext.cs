using Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Core
{
    public class RestroDbContext : DbContext
    {
        public RestroDbContext(DbContextOptions <RestroDbContext> options) : base(options)
        {

        }
        DbSet<User> Users{ get; set; }
        DbSet<BookTable> BookTables{ get; set; }
        DbSet<HeaderContactDetail> HeaderContactDetails{ get; set; }
        DbSet<LinkContent> LinkContents{ get; set; }
        DbSet<SocialMedia> SocialMedias{ get; set; }
        
    }
}
