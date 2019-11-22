services.AddDbContext<AppDbContext>(options => {
  options.UseInMemoryDatabase("supermarket-api-in-memory");
});
