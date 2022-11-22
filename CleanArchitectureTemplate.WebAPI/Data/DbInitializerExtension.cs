using CleanArchitectureTemplate.WebAPI.Entities;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitectureTemplate.WebAPI.Data
{
    public static class DbInitializerExtension
    {
        public static async Task<IApplicationBuilder> SeedData(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var applicationDbContext = services.GetRequiredService<ApplicationDbContext>();
                var userManager = services.GetRequiredService<UserManager<User>>();
                await DbInitializer.Initialize(applicationDbContext, userManager);
            }
            catch
            {
                throw;
            }

            return app;
        }
    }
}
