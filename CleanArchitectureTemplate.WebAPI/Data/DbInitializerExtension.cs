namespace CleanArchitectureTemplate.WebAPI.Data
{
    public static class DbInitializerExtension
    {
        public static IApplicationBuilder SeedData(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var applicationDbContext = services.GetRequiredService<ApplicationDbContext>();
                DbInitializer.Initialize(applicationDbContext);
            }
            catch
            {
                throw;
            }

            return app;
        }
    }
}
