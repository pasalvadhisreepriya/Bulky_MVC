

using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Action", DisplayOrder=1 },
                 new Category { Id=2, Name="SciFi", DisplayOrder=2 },
                  new Category { Id=3, Name="History", DisplayOrder=3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Pzexcrtvybunrctvybuni",
                    ISBN = "SWD999900111",
                    ListPrice = 95,
                    Price = 86,
                    Price50 = 78,
                    Price100 = 90,
                   CategoryId = 1,
                   ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "zexrctvybunjmbyumio ",
                    ISBN = "CAW777777701",
                    ListPrice = 49,
                    Price = 20,
                    Price50 = 30,
                    Price100 = 22,
                   CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "zxctvybunjcgvbhjnvn",
                    ISBN = "RITO5555501",
                    ListPrice = 54,
                    Price = 40,
                    Price50 = 38,
                    Price100 = 39,
                   CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "zxrctvybunimokoyujhtrfgdsdcfvgbhjnkm ",
                    ISBN = "WS3333333301",
                    ListPrice = 80,
                    Price = 63,
                    Price50 = 50,
                    Price100 = 59,
                   CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "mbvcxzsedrftyuiop;lkjhgfdsasxcvbn ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 40,
                    Price = 24,
                    Price50 = 35,
                    Price100 = 56,
                   CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "qwertyuioplkjhgfdsaZxcvbnmngfd ",
                    ISBN = "FOT000000001",
                    ListPrice = 36,
                    Price = 23,
                    Price50 = 25,
                    Price100 = 29,
                  CategoryId = 3,
                    ImageUrl=""
                }
                );
        }
    }
    }


