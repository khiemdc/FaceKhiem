using FaceKhiem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FaceKhiem.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Value> Values { get; set; }
    }
}