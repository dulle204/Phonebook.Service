using Microsoft.EntityFrameworkCore;
using Phonebook.Data.Models;

namespace Phonebook.Data
{
    public class PhonebookDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public PhonebookDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}