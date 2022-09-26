﻿using System;

namespace GreenShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // In order to see the data from our SQL - we'll move our product from the Client to Web API and now in our context
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                ) ;
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Upcycle: Beyond Sustainability—Designing for Abundance",
                    Description = "William McDonough and Michael Braungart imagine how human society might, at last, begin to rewrite its role in the history of the natural world. In The Upcycle, the best-selling authors offer numerous fascinating scenarios in which humans transcend the role of mere stewards of the planet. Instead, they suggest, why not become co-creators of the simplest invention ever: abundance?",
                    ImageUrl = "https://kbimages1-a.akamaihd.net/d7bb4cc8-ee43-4156-9782-e271d2f79e1d/353/569/90/False/the-upcycle.jpg",
                    Price = 10m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Rebuilding Earth: Designing Ecoconscious Habitats for Humans",
                    Description = "Written by award-winning Canadian architect, Teresa Coady, this book is both a call to action and a plan. It starts by tracing how we ended up with our unsustainable concrete jungles, and then it lays out principles and techniques for how to build a better future.\n\nIts highly readable prose is for anyone who wants be part of, or simply imagine, a more natural and sustainably built environment.",
                    ImageUrl = "https://zerowastememoirs.com/wp-content/uploads/2020/10/Screenshot-2020-10-24-at-16.35.34.png.webp",
                    Price = 10m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Cradle to Cradle: Remaking the Way We Make Things",
                    Description = "Written by William McDonough and Michael Braungart. Did you know that up to 90% of the materials used in traditional manufacturing models ends up as waste? This book challenges the way the traditional “cradle to grave” cycle works and envisions a world where we don’t have to harm the natural environment in order to create new products.",
                    ImageUrl = "https://zerowastememoirs.com/wp-content/uploads/2020/10/Screenshot-2020-10-24-at-16.25.09.png.webp",
                    Price = 10m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Price = 4.99m,
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Price = 3.99m,
                    Title = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Price = 2.99m,
                    Title = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Price = 49.99m,
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Price = 9.99m,
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Price = 14.99m,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Price = 159.99m,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 3,
                    Price = 79.99m,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                }
                );
            }

        // We add our DB Models here -- this is where Entity Framework Core builds tables, and queries them for data
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}

