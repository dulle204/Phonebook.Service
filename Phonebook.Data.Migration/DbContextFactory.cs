namespace Phonebook.Data.Migration
{
    public class PhonebookDbContextFactory : IDesignTimeDbContextFactory<PhonebookDbContext>
    {
        public PhonebookDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PhonebookDbContext> optionsBuilder = new();

            ConfigurationBuilder configBuilder = new();
            configBuilder
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables();

            var config = configBuilder.Build();
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder(config.GetConnectionString("PostgresDb"));

            optionsBuilder.UseNpgsql(builder.ConnectionString);

            PhonebookDbContext dbContext = new(optionsBuilder.Options);

            return dbContext;
        }
    }
}
