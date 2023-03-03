using DigitaliaFreelanceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitaliaFreelanceAPI.Context {
    public class ApplicationDbContext : DbContext {
        public DbSet<Receipt> Receipts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


    }
}