using Microsoft.EntityFrameworkCore;

namespace Message_Board
{
    public class MessageBoardDbContext : DbContext
    {
        public MessageBoardDbContext(DbContextOptions<MessageBoardDbContext> options) : base(options)
        {

        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}