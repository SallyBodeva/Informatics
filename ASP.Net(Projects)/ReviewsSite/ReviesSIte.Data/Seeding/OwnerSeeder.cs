using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReviesSIte.Data.Models;
using ReviesSIte.Data.Seeding.Contracts;
using ReviewsSite.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviesSIte.Data.Seeding
{
    public class OwnerSeeder:ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {

            if (dbContext.Users.Any())
            {
                return;
            }

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var userManager = serviceProvider.GetRequiredService<UserManager<Owner>>();


            await SeedUserAsync(dbContext, userManager, roleManager, "Admin", "Admin", "admin@app.bg", "admin@app.bg", configuration["Password:AdminPassword"], GlobalConstants.AdministratorRole);


            for (int i = 0; i < 25; i++)
            {
                await SeedUserAsync(dbContext, userManager, roleManager, $"UName{i}", $"ULastName{i}", $"user{i}@app.com", $"user{i}@app.com", configuration["Password:DefaultPassword"], GlobalConstants.UserRole);
            }


        }

        private static async Task SeedUserAsync(ApplicationDbContext context, UserManager<Owner> userManager, RoleManager<IdentityRole> roleManager, string firstName, string lastName, string userName, string email, string password, string roleName)
        {
            Owner owner = await userManager.FindByNameAsync(userName);
            if (owner == null)
            {
                IdentityResult result = await userManager.CreateAsync(
                    new Owner()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserName = userName,
                        Email = email,
                        SecurityStamp = "MyCustomSecurityStamp"
                    }, password);


                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }

            owner = await userManager.FindByNameAsync(userName);

            var roleExists = await roleManager.RoleExistsAsync(roleName);

            if (roleExists)
            {
                var result = await userManager.AddToRoleAsync(owner, roleName);

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
