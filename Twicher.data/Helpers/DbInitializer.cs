using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twicher.Data.Helpers.Constants;
using Twicher.Data.Models;

namespace Twicher.Data.Helpers
{
    public static class DbInitializer
    {
        public static async Task SeedUsersAndRolesAsync(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            //Roles
            if (!roleManager.Roles.Any())
            {
                foreach (var roleName in AppRoles.All)
                {
                    if (!await roleManager.RoleExistsAsync(roleName))
                    {
                        await roleManager.CreateAsync(new IdentityRole<int>(roleName));
                    }
                }
            }

            //Users with Roles
            if (!userManager.Users.Any(n => !string.IsNullOrEmpty(n.Email)))
            {
                var userPassword = "Coding@1234?";
                var newUser = new User()
                {
                    UserName = "PTA",
                    Email = "phamtuananh019619@gmail.com",
                    FullName = "Pham Tuan Anh",
                    ProfilePictureUrl = "https://www.facebook.com/photo/?fbid=784010643105229&set=a.103652741141026",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(newUser, userPassword);
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(newUser, AppRoles.User);


                var newAdmin = new User()
                {
                    UserName = "admin.admin",
                    Email = "admin@gmail.com",
                    FullName = "PTA Admin",
                    ProfilePictureUrl = "https://www.facebook.com/photo/?fbid=784010643105229&set=a.103652741141026",
                    EmailConfirmed = true
                };

                var resultNewAdmin = await userManager.CreateAsync(newAdmin, userPassword);
                if (resultNewAdmin.Succeeded)
                    await userManager.AddToRoleAsync(newAdmin, AppRoles.Admin);
            }
        }

        public static async Task SeedAsync(AppDbContext appDbContext)
        {
            //if (!appDbContext.Users.Any() && !appDbContext.Posts.Any())
            //{
            //    var newUser = new User()
            //    {
            //        FullName = "Pham Tuan Anh",
            //        ProfilePictureUrl = "https://www.facebook.com/photo/?fbid=784010643105229&set=a.103652741141026"
            //    };
            //    await appDbContext.Users.AddAsync(newUser);
            //    await appDbContext.SaveChangesAsync();

            //    var newPostWithoutImage = new Post()
            //    {
            //        Content = "This is going to be our first post which is being loaded from the database and it has been created using our test user.",
            //        ImageUrl = "",
            //        NrOfReports = 0,
            //        DateCreated = DateTime.UtcNow,
            //        DateUpdated = DateTime.UtcNow,

            //        UserId = newUser.Id
            //    };

            //    var newPostWithImage = new Post()
            //    {
            //        Content = "This is going to be our first post which is being loaded from the database and it has been created using our test user. This post has an image",
            //        ImageUrl = "https://www.facebook.com/photo/?fbid=1154298489409774&set=pcb.1154299436076346",
            //        NrOfReports = 0,
            //        DateCreated = DateTime.UtcNow,
            //        DateUpdated = DateTime.UtcNow,

            //        UserId = newUser.Id
            //    };

            //    await appDbContext.Posts.AddRangeAsync(newPostWithoutImage, newPostWithImage);
            //    await appDbContext.SaveChangesAsync();
            //}
        }
    }
}