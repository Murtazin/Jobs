using Jobs.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsWeb;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Vacancy> Vacancies { get; set; }
    public DbSet<Summary> Summaries { get; set; }
    public DbSet<Response> Responses { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Chat> Chats { get; set; }
}