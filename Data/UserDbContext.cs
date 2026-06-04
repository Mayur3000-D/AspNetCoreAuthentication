using Microsoft.EntityFrameworkCore;
using JwtAuthDotNet9.Entities;

namespace JwtAuthDotNet9.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options):DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
    }
}
