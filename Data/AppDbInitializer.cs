using ecommerce_mvc.Data.Enums;
using ecommerce_mvc.Models;

namespace ecommerce_mvc.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            CinemaLogoURL = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            CinemaDescription = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 2",
                            CinemaLogoURL = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            CinemaDescription = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 3",
                            CinemaLogoURL = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            CinemaDescription = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 4",
                            CinemaLogoURL = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            CinemaDescription = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 5",
                            CinemaLogoURL = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            CinemaDescription = "This is the description of the first cinema"

                        }
                    });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictueURL = "http://dotnethow.net/images/Actors/Actor-1.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictueURL = "http://dotnethow.net/images/Actors/Actor-2.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePictueURL = "http://dotnethow.net/images/Actors/Actor-3.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePictueURL = "http://dotnethow.net/images/Actors/Actor-4.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePictueURL = "http://dotnethow.net/images/Actors/Actor-5.jpeg",
                            Bio = "This is the description of the first cinema"

                        }
                    });
                    context.SaveChanges();

                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/Producers/Producer-1.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Producer()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/Producers/Producer-2.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Producer()
                        {
                            FullName = "Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/Producers/Producer-3.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Producer()
                        {
                            FullName = "Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/Producers/Producer-4.jpeg",
                            Bio = "This is the description of the first cinema"

                        },
                        new Producer()
                        {
                            FullName = "Actor 5",
                            ProfilePictureURL = "http://dotnethow.net/images/Producers/Producer-5.jpeg",
                            Bio = "This is the description of the first cinema"

                        }
                    });
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            MovieName = "Life",
                            MovieDescription = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            MovieName = "The Shawshank Redemption",
                            MovieDescription = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            MovieName = "Ghost",
                            MovieDescription = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            MovieName = "Race",
                            MovieDescription = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            MovieName = "Scoob",
                            MovieDescription = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            MovieName = "Cold Soles",
                            MovieDescription = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
