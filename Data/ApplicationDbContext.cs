using TAH1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TAH1.Controllers;

namespace TAH1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Forum> Forum { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostReply> Postreply { get; set; }
        public DbSet<personaldetail> personaldetail { get; set; }
        public DbSet<Comment> Comment { get; set; }



    }
}