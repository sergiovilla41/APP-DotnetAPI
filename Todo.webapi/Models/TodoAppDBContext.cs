using Microsoft.EntityFrameworkCore;

namespace Todo.webapi.Models
{
    public class TodoAppDBContext : DbContext
    {
        public TodoAppDBContext(DbContextOptions<TodoAppDBContext>options):base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    modelBuilder.Entity<Users>().ToTable("users");
            //    modelBuilder.Entity<TodoItems>().ToTable("todoItems");
            //}
    }
}
