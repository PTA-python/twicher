using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Twicher.Data.Models;

namespace Twicher.Data.Helpers
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(AppDbContext appDbContext)
        {
            if (!appDbContext.Users.Any() && !appDbContext.Posts.Any())
            {
                User newUser = new User()
                {
                    FullName = "Pham Tuan Anh",
                    ProfilePictureUrl = "https://scontent.fsgn15-1.fna.fbcdn.net/v/t39.30808-6/346326625_5767787906659005_3403250123934514513_n.jpg?stp=dst-jpg_tt6&cstp=mx888x888&ctp=s888x888&_nc_cat=107&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=IdE3uC3qKJcQ7kNvwFNSYzc&_nc_oc=Adqq4beBMpcANvi0oDsBnaGZPlRQpi3sFoR1mA0J-PxYnnrHOV1yx2qTV3pMeKaxEij5gsGBWyTaNl1JffdtyV4m&_nc_zt=23&_nc_ht=scontent.fsgn15-1.fna&_nc_gid=z-qFnmO26bv3f_rbnu-e7Q&_nc_ss=7b2a8&oh=00_AQGO8VFvWKl0kALlaoZRUwa1YuIil9Xxmg1lqjzptCnzYg&oe=6A7E602F"
                };
                await appDbContext.Users.AddAsync(newUser);
                await appDbContext.SaveChangesAsync();

                var newPostWithoutImage = new Post()
                {
                    Content = "This is going to be ours first post and its test 123 test 123.",
                    ImageUrl = "",
                    NrOfReports = 0,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,

                    UserId = newUser.Id
                };

                var newPostWithImage = new Post()
                {
                    Content = "This is going to be our first post which is being loaded from the database and it has been created using our test user. This post has an image",
                    ImageUrl = "https://scontent.fsgn15-1.fna.fbcdn.net/v/t39.30808-6/484032804_1174581837381439_1566702035385630997_n.jpg?stp=cp6_dst-jpg_tt6&cstp=mx2048x1536&ctp=s2048x1536&_nc_cat=103&ccb=1-7&_nc_sid=833d8c&_nc_ohc=gZUddnFztdMQ7kNvwEPGWmM&_nc_oc=Adr7Gefs_6d8sqoQkACrc-M_ZUB1FQdlBvJ8kKnOODLKQxLEBnf8K0BlMQv6Lj5FRSb46YdGhqNw_5_MBSBVA0k0&_nc_zt=23&_nc_ht=scontent.fsgn15-1.fna&_nc_gid=37Fmplzb7OS9R0PBtOi3SQ&_nc_ss=7b2a8&oh=00_AQHdSmN3MTsL83O8CCszPwFUY5wGBi5HO7PhFNAj_QYUbw&oe=6A7E69FF",
                    NrOfReports = 0,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,

                    UserId = newUser.Id
                };

                await appDbContext.Posts.AddRangeAsync(newPostWithoutImage, newPostWithImage);
                await appDbContext.SaveChangesAsync();
            }
        }
    }
}