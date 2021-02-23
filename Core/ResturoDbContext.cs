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
        
    }
}
