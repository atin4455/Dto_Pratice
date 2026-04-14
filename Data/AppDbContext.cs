using Dto_Pratice.Models;
using Microsoft.EntityFrameworkCore;

namespace Dto_Pratice.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users => Set<UserEntity>();
}
