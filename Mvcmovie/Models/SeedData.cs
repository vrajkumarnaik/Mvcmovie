using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mvcmovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcmovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcmovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "star wars",
                    ReleaseDate = DateTime.Parse("2022-2-03"),
                    Genre = "funny",
                    Price = 15.20M,
                    Rating = "43",
                },
                new Movie
                {
                    Title = "hero ",
                    ReleaseDate = DateTime.Parse("1999-11-15"),
                    Genre = "Action",
                    Price = 5.55M,
                    Rating ="5"
                },
                new Movie
                {
                    Title = "ZORO",
                    ReleaseDate = DateTime.Parse("2015-07-24"),
                    Genre = "Westen",
                    Price = 11.00M,
                    Rating ="2"
                },
                new Movie
                {
                    Title = "ghost 1",
                    ReleaseDate = DateTime.Parse("2018-06-01"),
                    Genre = "Action",
                    Price = 17.10M,
                    Rating ="3"
                },
                new Movie
                {
                    Title = "ghost 2",
                    ReleaseDate = DateTime.Parse("2020-02-20"),
                    Genre = "Action",
                    Price = 20.20M,
                    Rating ="5"
                }
            );
            context.SaveChanges();
        }
    }
}