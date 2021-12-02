var dbContext = new PhonebookDbContextFactory().CreateDbContext(args);

dbContext.Database.Migrate();