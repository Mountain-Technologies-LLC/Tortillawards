using Tortillawards.Components.Account.Pages.Manage;

namespace Tortillawards.Data;

internal static class ApplicationDbSeed
{
    internal static IApplicationBuilder Seed(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ApplicationDbContext>();

        var exists = context.Ballots.FirstOrDefault(x => x.Name == "Tau Kappa Epsilon 2014 Awards");

        if (exists != null)
        {
            return app;
            context.Remove(exists);
        }

        var applicationUser = new ApplicationUser
        {
            Email = "TestEmail",
            Name = "Anthony J. Pearson",
        };

        var ballot = new Ballot
        {
            Name = "Tau Kappa Epsilon 2014 Awards",
            CreatedBy = applicationUser,
            Awards = [
                    new Award
                    {
                         Name = "Most likely to score a date on Tinder.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Who has most Love?",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Who has the most Esteem?",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Who gives the most charity?",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to act like a diva?",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to die due to a nerf gun.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Ryan McDougall Drunk Asshole Award",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Likely to survive apocalypse.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Best Friend Award",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Would make the best house husband.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Grows good hair (good facial hair).",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "This guy will probably graduate.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to dive and take a bullet for you.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to train to be a jedi.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Teacher's Pet",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to win this award for no reason",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most Self Love (Hairy Palms)",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to break out into song.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Forgets a child at gas station",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Loud Fart Award",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to be a famous Teke.",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                         Name = "Most likely to be sorted into Gryffindor",
                         Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "Most likely to be sorted into Slytherin.",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "Most likey to feed the hungry",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "Wakes up in another country.",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "Does not see the stop sign, walks into it.",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "Uses a human as a sheild, badass.",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "Most likely to send a text message he will regret.",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              }
                         },
                    },
                    new Award
                    {
                        Name = "The Boxer Bro",
                        Nominations = {
                              new Nomination
                              {
                                   Name = "Jared Munson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Parker Lindo",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Quinn Glasgow",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Nick Hoover",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "James Seegebarth",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Michael Hirsch",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Kevin Gysberg",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Matt Seafolk",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Scott Reid",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Skluzacek",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Jared Hill",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Barrett Hultgren",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Alex Miller",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Joe McGrath",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Micah Grove",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Hunter Schultz",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Samuel Derosier",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Denny Ha",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Jesse Arvidson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Stewart Rinker",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Danny Gagnon",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Chris Zentner",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Aaron Carlson",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Ben Jacobs",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Aaron Paskiewicz",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Dan Finazzo",
                                   Votes = []
                              },
                              new Nomination
                              {
                                   Name = "Lucas Tousignant",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                              new Nomination
                              {
                                   Name = "Anthony Pearson",
                                   Votes = {
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        },
                                        new Vote
                                        {
                                             CreatedBy = applicationUser
                                        }
                                   }
                              },
                         },
                    }
               ]
        };

        context.Add(ballot);

        context.SaveChanges();

        return app;
    }
}
