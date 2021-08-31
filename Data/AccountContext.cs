using Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Data
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> opt) : base(opt)
        {

        }

        public DbSet<Account> Account { get; set; }
    }
}