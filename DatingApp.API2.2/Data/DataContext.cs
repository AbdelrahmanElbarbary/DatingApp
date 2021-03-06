using DatingApp.API2._2.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API2._2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options){}
    
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}