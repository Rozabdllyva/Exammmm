using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext :DbContext
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       

        public  DbSet<Salam> Salams { get; set; }   


    }
}
