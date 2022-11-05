using JobsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsWeb;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Vacancy> Vacancies { get; set; }
    public DbSet<Summary> Summaries { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Response> Responses { get; set; }
    public DbSet<UserMessage> UserMessages { get; set; }
    public DbSet<ManagerMessage> ManagerMessages { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Chat> Chats { get; set; }
}