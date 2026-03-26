using Microsoft.EntityFrameworkCore;
using FeedbackSystemAPI.Models;

namespace FeedbackSystemAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<user> Users { get; set;}
        public DbSet<Consultant> Consultants { get; set;}
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
