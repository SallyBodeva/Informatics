using Microsoft.AspNetCore.Identity;
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
    public class ReviewSeeder : ISeeder
    {
        public  async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {

            if (dbContext.Reviews.Any())
            {
                return;
            }
            var userManager = serviceProvider.GetRequiredService<UserManager<Owner>>();

            List<Review> reviews = new List<Review>();

            for (int i = 0; i < 50; i++)
            {
                reviews.Add(new Review
                {
                    Description = $"Info",
                    CreationDate = DateTime.UtcNow,
                    Rating = 5,
                    Owner = (Owner)dbContext.Users.FirstOrDefault(),
                }); ;
            }
            await dbContext.Reviews.AddRangeAsync(reviews);
            await dbContext.SaveChangesAsync();
        }
    }
}
