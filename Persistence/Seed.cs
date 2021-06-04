using System;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.RingHonor.Any())
            {
                new RingHonor
                {
                    History = "Created in 2000, the Baltimore Ravens Ring of Honor is to honor former players and personnel who made outstanding contributions to the Baltimore Ravens and the Baltimore Colts organizations.",
                    Team = new Teams 
                    {
                        City = "Baltimore",
                        TeamName = "Ravens",
                        LogoURL = "https://static.www.nfl.com/t_q-best/league/api/clubs/logos/BAL",
                        Players = new List<Players>
                        {
                            new Players
                            {
                                Name = "Earnest Byner",
                                Position = "RB, Coach",
                                Notes = "The Tie Between Two Cities",
                                YearInducted = 2001,
                                YearsActive = 1996 - 2003
                            },
                             new Players
                             {
                                 Name = "Johnny Unitas",
                                 Position = "QB",
                                 YearInducted = 2002,
                                 YearsActive = 1956 - 1972
                             },
                             new Players
                             {
                                 Name = "Lenny Moore",
                                 Position = "HB",
                                 YearInducted = 2002,
                                 YearsActive = 1956 - 1967
                             },
                             new Players
                             {
                                 Name = "Art Donovan",
                                 Position = "DT",
                                 YearInducted = 2002,
                                 YearsActive = 1953 - 1961
                             },
                             new Players
                             {
                                 Name = "Jim Parker",
                                 Position = "OL",
                                 YearInducted = 2002,
                                 YearsActive = 1957 = 1967
                             },
                             new Players
                             {
                                 Name = "Raymond Berry",
                                 Position = "WR",
                                 YearInducted = 2002,
                                 YearsActive = 1955 - 1967
                             },
                             new Players
                             {
                                 Name = "Ted Hendricks",
                                 Position = "LB",
                                 YearInducted = 2002,
                                 YearsActive = 1969 - 1973
                             },
                             new Players 
                             {
                                 Name = "John Mackey",
                                 Position = "TE",
                                 YearInducted = 2002,
                                 YearsActive = 1963 - 1971
                             },
                             new Players
                             {
                                 Name = "Gino Marchetti",
                                 Position = "DE",
                                 YearInducted = 2002,
                                 YearsActive = 1953 = 1966
                             },
                             new Players
                             {
                                 Name = "Art Modell",
                                 Position = "Owner",
                                 Notes = "Returned the NFL to Baltimore"
                                 YearInducted = 2004,
                                 YearsActive = 1996 - 2003
                             },
                             new Players
                             {
                                 Name = "Michael McCrary",
                                 Position = "DE",
                                 YearInducted = 2004,
                                 YearsActive = 1997 - 2002
                             },
                             new Players
                             {
                                 Name = "Peter Boulware",
                                 Position = "LB",
                                 YearInducted = 2006,
                                 YearsActive = 1997 - 2005
                             },
                             new Players
                             {
                                 Name = "Jonathan Ogden",
                                 Position = "LT",
                                 YearInducted = 2008,
                                 YearsActive = 1996 - 2007
                             },
                            new Players
                            {
                                Name = "Matt Stover",
                                Position = "K",
                                YearInducted = 2011,
                                YearsActive = 1996 - 2008
                            },
                            new Players
                            {
                                Name = "Jamal Lewis",
                                Position = "RB",
                                YearInducted = 2012,
                                YearsActive = 2000 - 2006
                            },
                            new Players
                            {
                                Name = "Ray Lewis",
                                Position = "LB",
                                YearInducted = 2013,
                                YearsActive = 1996 - 2012
                            },
                            new Players
                            {
                                Name = "Todd Heap",
                                Position = "TE",
                                YearInducted = 2014,
                                YearsActive = 2001 - 2010
                            },
                            new Players
                            {
                                Name = "Ed Reed",
                                Position = "FS",
                                YearInducted = 2015,
                                YearsActive = 2002 - 2012
                            },
                            new Players
                            {
                                Name = "Brian Billick",
                                Position = "Head Coach",
                                YearInducted = 2019,
                                YearsActive = 1999 - 2007
                            },
                            new Players
                            {
                                Name = "Haloti Ngata",
                                Position = "DT",
                                YearInducted = 2021,
                                YearsActive = 2006 - 2014
                            },
                            new Players
                            {
                                Name = "Marshal Yanda",
                                Position = "OG",
                                YearInducted = 2021,
                                YearsActive = 2007 - 2019
                            }
                        }
                    }
                },
                new RingHonor 
                {
                    History = "The Cincinnati Bengals introduced a Ring of Honor for their historical team in April of 2021. They announced two inductees, but will let their fans choose two others between a list of 17 other great players to complete its first Ring of Honor class.",
                    Team = new Teams
                    {
                        City = "Cincinnati",
                        TeamName = "Bengals",
                        LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/CLE.svg",
                        Players = new List<Players>
                        {
                            new Players
                            {
                                Name = "Paul Brown",
                                Position = "Team Founder, Head Coach, General Manager",
                                YearInducted = 2021,
                                YearsActive = 1968 - 1991
                            },
                            new Players
                            {
                                Name = "Anthony Mu&#241;oz",
                                Position = "LT",
                                YearInducted = 2021,
                                YearsActive = 1980 = 1992
                            }
                        }
                    }
                }
                new RingHonor 
                {
                    History = "Established in 2010, the Cleveland Browns Ring of Honor commemorates the past greats of the Cleveland Browns franchise. The Inaugural class featured the 16 players who were already inducted into the Pro Football Hall of Fame.",
                    Team = new Teams
                    {
                        City = "Cleveland",
                        TeamName = "Browns",
                        LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/CLE.svg",
                        Players = new List<Players>
                        {
                            new Players
                            {
                                Name = "Jim Brown",
                                Position = "FB",
                                YearInducted = 2010,
                                YearsActive = 1957 - 1965
                            },
                            new Player
                            {
                                Name = "Paul Brown",
                                Position = "Head Coach",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1962
                            },
                            new Players
                            {
                                Name = "Joe DeLamielleure",
                                Position = "OG",
                                YearInducted = 2010,
                                YearsActive = 1980 - 1984
                            },
                            new Players
                            {
                                Name = "Len Ford",
                                Position = "DE",
                                YearInducted = 2010,
                                YearsActive = 1950 - 1957
                            },
                            new Players
                            {
                                Name = "Frank Gatski",
                                Position = "C",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1956
                            },
                            new Players
                            {
                                Name = "Otto Graham",
                                Position = "QB",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1955
                            },
                            new Players
                            {
                                Name = "Lou Groza",
                                Position = "OT, K",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1959 1961 - 1967, 
                            },
                            new Players
                            {
                                Name = "Gene Hickerson",
                                Position = "OG",
                                YearInducted = 2010,
                                YearsActive = 1958 - 1960 1962 - 1973,
                            },
                            new Players
                            {
                                Name = "Leroy Kelly",
                                Position = "RB",
                                YearInducted = 2010,
                                YearsActive = 1964 - 1973
                            },
                            new Players
                            {
                                Name = "Dante Lavelli",
                                Position = "WR",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1956
                            },
                            new Players
                            {
                                Name = "Mike McCormack",
                                Position = "OT",
                                YearInducted = 2010,
                                YearsActive = 1954 - 1962
                            },
                            new Players
                            {
                                Name = "Bobby Mitchell",
                                Position = "WR, RB",
                                YearInducted = 2010,
                                YearsActive = 1958 - 1961
                            },
                            new Players
                            {
                                Name = "Marion Motley",
                                Position = "FB",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1953
                            },
                            new Players
                            {
                                Name = "Ozzie Newsome",
                                Position = "TE",
                                YearInducted = 2010,
                                YearsActive = 1978 - 1990
                            },
                            new Players 
                            {
                                Name = "Paul Warfield",
                                Position = "WR",
                                YearInducted = 2010,
                                YearsActive = 1964 - 1969 1976 - 1977
                            },
                            new Players
                            {
                                Name = "Bill Willis",
                                Position = "OT, OG",
                                YearInducted = 2010,
                                YearsActive = 1946 - 1953
                            },
                            new Players
                            {
                                Name = "Joe Thomas",
                                Position = "LT",
                                YearInducted = 2018,
                                YearsActive = 2007 - 2017
                            },
                            new Players
                            {
                                Name = "Clay Matthews",
                                Position = "LB",
                                YearInducted = 2019,
                                YearsActive = 1978 - 1993
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Pittsburgh",
                            TeamName = "Steelers",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Created in 1980 to honor former players, administrators, and coaches who had a significant role in the franchise. The requirements to get inducted into the Wall of Fame are: the individual must ahve played with the team for three years and must be retired. The selection committee is comprised of club personnel and media members.",
                        Team = new Teams
                        {
                            City = "Buffalo",
                            TeamName = "Bills",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {   
                        History = "",
                        Team = new Teams
                        {
                            City = "Miami",
                            TeamName = "Dolphins",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "New England",
                            TeamName = "Patriots",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "New York",
                            TeamName = "Jets",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "As the newest NFL Franchise, the Houston Texans began their Ring of Honor in 2017.",
                        Team = new Teams
                        {
                            City = "Houston",
                            TeamName = "Texans",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Andre Johnson",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = 2003 - 2014
                                },
                                new Players
                                {
                                    Name = "Bob McNair",
                                    Position = "Founding Owner",
                                    YearInducted = 2019,
                                    YearsActive = 2002 - 2018
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Established in 1996 and inducted longtime owner, Robert Irsay, as its first inductee before his passing the year following.",
                        Team = new Teams
                        {
                            City = "Indianapolis",
                            TeamName = "Colts",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Robert Irsay",
                                    Position = "Owner",
                                    YearInducted = 1996,
                                    YearsActive = 1972 - 1997
                                },
                                new Players
                                {
                                    Name = "Bill Brooks",
                                    Position = "WR",
                                    YearInducted = 1998,
                                    YearsActive = 1986 - 1992
                                },
                                new Players
                                {
                                    Name = "Ted Marchibroda",
                                    Position = "Head Coach",
                                    YearInducted = 2000,
                                    YearsActive = 1975 - 1979 1992 - 1995
                                },
                                new Players
                                {
                                    Name = "Chris Hinton",
                                    Position = "OT, OG",
                                    YearInducted = 2001,
                                    YearsActive = 1983 - 1989
                                },
                                new Players
                                {
                                    Name = "Jim Harbaugh",
                                    Position = "QB",
                                    YearInducted = 2005,
                                    YearsActive = 1994 - 1997
                                },
                                new Players
                                {
                                    Name = "Tony Dungy",
                                    Position = "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = 2002 - 2008
                                },
                                new Players
                                {
                                    Name = "Marvin Harrison",
                                    Position = "WR",
                                    YearInducted = 2011,
                                    YearsActive = 1996 - 2008
                                },
                                new Players
                                {
                                    Name = "Edgerrin James",
                                    Position = "RB",
                                    YearInducted = 2012,
                                    YearsActive = 1999 - 2005
                                },
                                new Players
                                {
                                    Name = "Eric Dickerson",
                                    Position = "RB",
                                    YearInducted = 2013,
                                    YearsActive = 1987 - 1991
                                },
                                new Players
                                {
                                    Name = "Marshall Faulk",
                                    Position = "RB",
                                    YearInducted = 2013,
                                    YearsActive = 1994 - 1998
                                },
                                new Players
                                {
                                    Name = "Jeff Saturday",
                                    Position = "C",
                                    YearInducted = 2015,
                                    YearsActive = 1999 - 2011
                                },
                                new Players
                                {
                                    Name = "Bill Polian",
                                    Position = "President, General Manager",
                                    YearInducted = 2017,
                                    YearsActive = 1998 - 2011
                                },
                                new Players
                                {
                                    Name = "Peyton Manning",
                                    Position = "QB",
                                    YearInducted = 2017,
                                    YearsActive = 1998 - 2011
                                },
                                new Players
                                {
                                    Name = "Reggie Wayne",
                                    Position = "WR",
                                    YearInducted = 2018,
                                    YearsActive = 2001 - 2014
                                },
                                new Players
                                {
                                    Name = "Dwight Freeney".
                                    Position = "DE",
                                    YearInducted = 2019,
                                    YearsActive = 2002 - 2012
                                },
                                new Players
                                {
                                    Name = "Robert Mathis",
                                    Position = "DE",
                                    YearInducted = 2021,
                                    YearsActive = 2003 - 2016
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Called the Pride of the Jaguars by the fans in 2006, it represents the Ring of Honor for one fo the newest franchises in the NFL. It was unveiled in the 2006 NFL season against the New York Jets.",
                        Team = new Teams
                        {
                            City = "Jacksonville",
                            TeamName = "Jaguars",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Tony Boselli",
                                    Position = "OT",
                                    YearInducted = 2006,
                                    YearsActive = 1995 - 2001
                                },
                                new Players
                                {
                                    Name = "Wayne and Delores Weaver",
                                    Position = "Founding Owners",
                                    YearInducted = 2011,
                                    YearsActive = 1993 - 2011
                                },
                                new Players
                                {
                                    Name = "Fred Taylor",
                                    Position = "RB",
                                    YearInducted = 2012,
                                    YearsActive = 1998 - 2003
                                },
                                new Players
                                {
                                    Name = "Mark Brunell",
                                    Position = "QB",
                                    YearInducted = 2013,
                                    YearsActive = 1995 - 2003
                                },
                                new Players
                                {
                                    Name = "Jimmy Smith",
                                    Position = "WR",
                                    YearInducted = 2016,
                                    YearsActive = 1995 - 2005
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Establishment of the Titans/Oilers Hall of Fame coincides with the 40th anniversary of the franchise by Owner, Bud Adams. It encompasses the history of the Houston Oilers and the Tennessee Titans respectively.",
                        Team = new Teams
                        {
                            City = "Tennessee",
                            TeamName = "Titans",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Elvin Bethea",
                                    Position = "DE",
                                    YearInducted = 1999,
                                    YearsActive = 1968 - 1983
                                },
                                new Players
                                {
                                    Name = "George Blanda",
                                    Position = "QB, K",
                                    YearInducted = 1999,
                                    YearsActive = 1960 - 1966
                                },
                                new Players
                                {
                                    Name = "Earl Campbell",
                                    Position = "RB",
                                    YearInducted = 1999,
                                    YearsActive = 1978 - 1984
                                },
                                new Players
                                {
                                    Name = "Mike Holovak",
                                    Position = "General Manager",
                                    YearInducted = 1999,
                                    YearsActive = 1989 - 1993
                                },
                                new Players
                                {
                                    Name = "Ken Houston",
                                    Position = "S",
                                    YearInducted = 1999,
                                    YearsActive = 1967 - 1972
                                },
                                new Players
                                {
                                    Name = "Mike Munchak",
                                    Position = "OG",
                                    YearInducted = 1999,
                                    YearsActive = 1982 - 1993
                                },
                                new Players
                                {
                                    Name = "Jim Norton",
                                    Position = "P",
                                    YearInducted = 1999,
                                    YearsActive = 1960 - 1968
                                },
                                new Players
                                {
                                    Name = "Bruce Matthews",
                                    Position = "OL",
                                    YearInducted = 2002,
                                    YearsActive = 1983 - 2001
                                },
                                new Players
                                {
                                    Name = "Warren Moon",
                                    Position = "QB",
                                    YearInducted = 2007,
                                    YearsActive = 1984 - 1993
                                },
                                new Players
                                {
                                    Name = "Bud Adams",
                                    Position = "Founding Owner",
                                    YearInducted = 2008,
                                    YearsActive = 1959 - 2013
                                },
                                new Players
                                {
                                    Name = "Eddie George",
                                    Position = "RB",
                                    YearInducted = 2008,
                                    YearsActive = 1996 - 2003
                                },
                                new Players
                                {
                                    Name = "Steve McNair",
                                    Position = "QB",
                                    YearInducted = 2008,
                                    YearsActive = 1995 - 2005
                                },
                                new Players
                                {
                                    Name = "Frank Wycheck",
                                    Position = "TE",
                                    YearInducted = 2008,
                                    YearsActive = 1995 - 2003
                                },
                                new Players
                                {
                                    Name = "Robert Brazile",
                                    Position = "LB",
                                    YearInducted = 2018
                                    YearsActive = 1975 - 1984
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Denver",
                            TeamName = "Broncos",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Kansas City",
                            TeamName = "Chiefs",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Los Angeles",
                            TeamName = "Chargers",
                            LogoURL = "",
                            Players = new List<Players>
                            {

                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Chicago",
                            TeamName = "Bears",
                            LogoURL = "",
                            Players = new List<Players>
                            {

                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Detroit",
                            TeamName = "Lions",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Green Bay",
                            TeamName = "Packers",
                            LogoURL = "",
                            Players = new List<Players>
                            {

                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Minnesota",
                            TeamName = "Vikings",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "First introduced in Texas Stadium in Irving, Texas, the Cowboys Ring of Honor, in the words of Jerry Jones: 'stands for men who built this franchise and it had it call America's team.' ",
                        Team = new Teams
                        {
                            City = "Dallas",
                            TeamName = "Cowboys",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Bob Lilly",
                                    Position = "DT",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "Don Meredith",
                                    Posistion = "QB",
                                    YearInducted = 1976,
                                    YearsActive = 1960 - 1968
                                },
                                new Players
                                {
                                    Name = "Don Perkins",
                                    Position = "FB",
                                    YearInducted = 1976,
                                    YearsActive = 1961 - 1968
                                },
                                new Players
                                {
                                    Name = "Chuck Howley",
                                    Position = "LB",
                                    YearInducted = 1977m
                                    YearsActive = 1961 - 1973
                                },
                                new Players
                                {
                                    Name = "Mel Renfro",
                                    Position = "CB",
                                    YearInducted = 1981,
                                    YearsActive = 1964 - 1977
                                },
                                new Players
                                {
                                    Name = "Roger Staubach",
                                    Position = "QB",
                                    YearInducted = 1983,
                                    YearsActive = 1969 - 1979
                                },
                                new Players
                                {
                                    Name = "Lee Roy Jordan",
                                    Position = "LB, C",
                                    YearInducted = 1989,
                                    YearsActive = 1963 - 1976
                                },
                                new Players
                                {
                                    Name = "Tom Landry",
                                    Position = "Head Coach",
                                    YearInducted = 1993,
                                    YearsActive = 1960 - 1988
                                },
                                new Players 
                                {
                                    Name = "Tony Dorsett",
                                    Position = "RB",
                                    YearInducted = 1994,
                                    YearsActive = 1977 - 1987
                                },
                                new Players
                                {
                                    Name = "Randy White",
                                    Position = "DT, DE, LB",
                                    YearInducted = 1994,
                                    YearsActive = 1975 - 1988
                                },
                                new Players
                                {
                                    Name = "Bob Hayes",
                                    Position = "WR",
                                    YearInducted = 2001,
                                    YearsActive = 1965 - 1974
                                },
                                new Players
                                {
                                    Name = "Tex Schramm",
                                    Position = "General Manager",
                                    YearInducted = 2003,
                                    YearsActive = 1960 - 1989
                                },
                                new Players
                                {
                                    Name = "Cliff Harris",
                                    Position = "S",
                                    YearInducted = 2004,
                                    YearsActive = 1970 - 1979
                                },
                                new Players
                                {
                                    Name = "Rayfield Wright",
                                    Position = "OT",
                                    YearInducted = 2004
                                    YearsActive = 1967 - 1979
                                },
                                new Players
                                {
                                    Name = "Troy Aikman",
                                    Position = "QB",
                                    YearInducted = 2005,
                                    YearsActive = 1989 - 2000
                                },
                                new Players
                                {
                                    Name = "Michael Irvin",
                                    Position = "WR",
                                    YearInducted = 2005,
                                    YearsActive = 1988 - 1999
                                },
                                new Players
                                {
                                    Name = "Emmitt Smith",
                                    Position = "RB",
                                    YearInducted = 2005,
                                    YearsActive = 1990 - 2002
                                },
                                new Players
                                {
                                    Name = "Drew Pearson",
                                    Position = "WR",
                                    YearInducted = 2011,
                                    YearsActive = 1973 - 1983
                                },
                                new Players
                                {
                                    Name = "Charles Haley",
                                    Position = "DE",
                                    YearInducted = 2011,
                                    YearsActive = 1992 - 1996
                                },
                                new Players
                                {
                                    Name = "Larry Allen",
                                    Position = "OG, OT",
                                    YearInducted = 2011,
                                    YearsActive = 1994 - 2005
                                },
                                new Players
                                {
                                    Name = "Darren Woodson",
                                    Position = "S",
                                    YearInducted = 2015,
                                    YearsActive = 1992 - 2004
                                },
                                new Players
                                {
                                    Name = "Gil Brandt",
                                    Position = "VP Player of Personnel",
                                    YearInducted = 2018,
                                    YearsActive = 1960 - 1988
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "New York",
                            TeamName = "Giants",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Philadelphia",
                            TeamName = "Eagles",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Washington",
                            TeamName = "Football Team",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                                new Players
                                {
                                    Name = "",
                                    Position = "",
                                    YearInducted = 1975,
                                    YearsActive = 1961 - 1974
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "While they don't retire jersey numbers, the Atlanta Falcons want to honor their former players by including them in their franchise's Ring of Honor.",
                        Team = new Teams
                        {
                            City = "Atlanta",
                            TeamName = "Falcons",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "William Andrews",
                                    Position = "RB",
                                    YearInducted = 2004,
                                    YearsActive = 1979 - 1983 1986
                                },
                                new Players
                                {
                                    Name = "Steve Bartkowski",
                                    Position = "QB",
                                    YearInducted = 2004,
                                    YearsActive = 1975 - 1985
                                },
                                new Players
                                {
                                    Name = "Tommy Nobis",
                                    Position = "LB",
                                    YearInducted = 2004,
                                    YearsActive = 1966 - 1976
                                },
                                new Players
                                {
                                    Name = "Jessie Tuggle",
                                    Position = "LB",
                                    YearInducted = 2004,
                                    YearsActive = 1987 - 2000
                                },
                                new Players
                                {
                                    Name = "Jeff Van Note",
                                    Position = "C",
                                    YearInducted = 2006,
                                    YearsActive = 1969 - 1986
                                },
                                new Players
                                {
                                    Name = "Claude Humphrey",
                                    Position = "DE",
                                    YearInducted = 2008,
                                    YearsActive = 1968 - 1978
                                },
                                new Players
                                {
                                    Name = "Mike Kenn",
                                    Position = "OT",
                                    YearInducted = 2008,
                                    YearsActive = 1978 - 1994
                                },
                                new Players
                                {
                                    Name = "Deion Sanders",
                                    Position = "CB",
                                    YearInducted = 2010,
                                    YearsActive = 1989 - 1993
                                },
                                new Players
                                {
                                    Name = "Gerald Riggs",
                                    Position = "RB",
                                    YearInducted = 2013,
                                    YearsActive = 1982 - 1988
                                },
                                new Players
                                {
                                    Name = "Warrick Dunn",
                                    Position = "RB",
                                    YearInducted = 2017,
                                    YearsActive = 2002 - 2007
                                },
                                new Players
                                {
                                    Name = "Roddy White",
                                    Position = "WR",
                                    YearInducted = 2019,
                                    YearsActive = 2005 - 2015
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Hall of Honor was established in 1997 as a still young franchsie. They've inducted six people who define being a Carolina Panther.",
                        Team = new Teams
                        {
                            City = "Carolina",
                            TeamName = "Panthers",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Mike McCormack",
                                    Position = "President, General Manager",
                                    YearInducted = 1997,
                                    YearsActive = 1993 - 1997
                                },
                                new Players
                                {
                                    Name = "Sam Mills",
                                    Position = "LB, Coach",
                                    YearInducted = 1998,
                                    YearsActive = 1995 - 2004
                                },
                                new Players
                                {
                                    Name = "Steve Smith Sr.",
                                    Position = "WR",
                                    YearInducted = 2019,
                                    YearsActive = 2001 - 2013
                                },
                                new Players
                                {
                                    Name = "Jake Delhomme",
                                    Position = "QB",
                                    YearInducted = 2019,
                                    YearsActive = 2003 - 2009
                                },
                                new Players
                                {
                                    Name = "Wesley Walls",
                                    Position = "TE",
                                    YearInducted = 2019,
                                    YearsActive = 1996 - 2002
                                },
                                new Players
                                {
                                    Name = "Jordan Gross",
                                    Position = "OT",
                                    YearInducted = 2019,
                                    YearsActive = 2003 - 2013
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Beginning in 2013, the Saints began honoring their history with the creation of the Ring of Honor in Mercedes-Benz Superdome. They inducted the first three nominees during halftime against the Cowboys in 2013.",
                        Team = new Teams
                        {
                            City = "New Orleans",
                            TeamName = "Saints",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Archie Manning",
                                    Position = "QB",
                                    YearInducted = 2013,
                                    YearsActive = 1971 - 1982
                                },
                                new Players
                                {
                                    Name = "Rickey Jackson",
                                    Position = "LB",
                                    YearInducted = 2013,
                                    YearsActive = 1981 - 1993
                                },
                                new Players
                                {
                                    Name = "Willie Roaf",
                                    Position = "OT",
                                    YearInducted = 2013,
                                    YearsActive = 1993 - 2001
                                },
                                new Players
                                {
                                    Name = "Morten Andersen",
                                    Position = "K",
                                    YearInducted = 2015,
                                    YearsActive = 1982 - 1994
                                },
                                new Players
                                {
                                    Name = "Tom Benson",
                                    Position = "Owner",
                                    YearInducted = 2019,
                                    YearsActive = 1985 - 2018
                                },
                                new Players
                                {
                                    Name = "Will Smith",
                                    Position = "DE",
                                    YearInducted = 2019,
                                    YearsActive = 2004 - 2013
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "In November 2009, the team unveiled a Ring of Honor at their current stadium, Raymond James Stadium.",
                        Team = new Teams
                        {
                            City = "Tampa Bay",
                            TeamName = "Buccaneers",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Lee Roy Selmon",
                                    Position = "DE",
                                    YearInducted = 2009,
                                    YearsActive = 1976 - 1984
                                },
                                new Players
                                {
                                    Name = "John McKay",
                                    Position = "Head Coach",
                                    YearInducted = 2010
                                    YearsActive = 1976 - 1984,
                                },
                                new Players
                                {
                                    Name = "Jimmie Giles",
                                    Position = "TE",
                                    YearInducted = 2011,
                                    YearsActive = 1978 - 1986
                                },
                                new Players
                                {
                                    Name = "Paul Gruber",
                                    Position = "OT",
                                    YearInducted = 2012,
                                    YearsActive = 1988 - 1999
                                },
                                new Players
                                {
                                    Name = "Warren Sapp",
                                    Position = "DT",
                                    YearInducted = 2013,
                                    YearsActive = 1995 - 2003
                                },
                                new Players
                                {
                                    Name = "Derrick Brooks",
                                    Position = "LB",
                                    YearInducted = 2014,
                                    YearsActive = 1995 - 2008
                                },
                                new Players
                                {
                                    Name = "Mike Alstott",
                                    Position = "FB",
                                    YearInducted = 2015,
                                    YearsActive = 1996 - 2007
                                },
                                new Players
                                {
                                    Name = "Doug Williams",
                                    Position = "QB",
                                    YearInducted = 2015,
                                    YearsActive = 1978 - 1982
                                },
                                new Players
                                {
                                    Name = "John Lynch",
                                    Position = "S"
                                    YearInducted = 2016,
                                    YearsActive = 1993 - 2003
                                },
                                new Players
                                {
                                    Name = "Malcolm Glazer",
                                    Position = "Owner",
                                    YearInducted = 2017,
                                    YearsActive = 1995 - 2014
                                },
                                new Players
                                {
                                    Name = "Jon Gruden",
                                    Position = "Head Coach",
                                    YearInducted = 2017,
                                    YearsActive = 2002 - 2008
                                },
                                new Players 
                                {
                                    Name = "Tony Dungy",
                                    Position = "Head Coach",
                                    YearInducted = 2018,
                                    YearsActive = 1996 - 2001
                                },
                                new Players
                                {
                                    Name = "Ronde Barber",
                                    Position = "CB",
                                    YearInducted = 2019,
                                    YearsActive = 1997 - 2012
                                },
                                new Players
                                {
                                    Name = "Monte Kiffin",
                                    Position = "Defensive Coordinator",
                                    YearInducted = 2020,
                                    YearsActive = 1996 - 2008
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "To mark the opening of State Farm Stadium in 2006, the Cardinals began a Ring of Honor to showcase all eras of the franchise.",
                        Team = new Teams
                        {
                            City = "Arizona",
                            TeamName = "Cardinals",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Charles Bidwill",
                                    Position = "Owner",
                                    YearInducted = 2006,
                                    YearsActive = 1933 - 1947
                                },
                                new Players
                                {
                                    Name = "Jimmy Conzelman",
                                    Position = "Head Coach".
                                    YearInducted = 2006,
                                    YearsActive = 1940 - 1942 1946 - 1948
                                },
                                new Players
                                {
                                    Name = "John 'Paddy' Driscoll",
                                    Position = "QB, Head Coach",
                                    YearInducted = 2006,
                                    YearsActive = 1920 - 1925 1920 - 1922
                                },
                                new Players
                                {
                                    Name = "Marshall Goldberg",
                                    Position = "RB",
                                    YearInducted = 2006,
                                    YearsActive = 1939 - 1943 1946 - 1948
                                },
                                new Players
                                {
                                    Name = "Dick 'Night Train' Lane",
                                    Position = "CB",
                                    YearInducted = 2006,
                                    YearsActive = 1954 - 1959
                                },
                                new Players
                                {
                                    Name = "Ollie Matson",
                                    Position = "RB",
                                    YearInducted = 2006,
                                    YearsActive = 1952 1954 - 1958
                                },
                                new Players
                                {
                                    Name = "Ernie Nevers",
                                    Position = "FB, Head Coach",
                                    YearInducted = 2006,
                                    YearsActive = 1929 - 1931 1930 - 1931 1939
                                },
                                new Players
                                {
                                    Name = "Charley Trippi",
                                    Position = "RB, QB",
                                    YearInducted = 2006,
                                    YearsActive = 1947 - 1955
                                },
                                new Players
                                {
                                    Name = "Larry Wilson",
                                    Position = "S",
                                    YearInducted = 2006,
                                    YearsActive = 1960 - 1972
                                },
                                new Players
                                {
                                    Name = "Dan Dierdorf",
                                    Position = "OT",
                                    YearInducted = 2006,
                                    YearsActive = 1971 - 1983
                                },
                                new Players
                                {
                                    Name = "Pat Tillman",
                                    Position = "S",
                                    YearInducted = 2006,
                                    YearsActive = 1998 - 2001
                                },
                                new Players
                                {
                                    Name = "Roger Wehrli",
                                    Position = "CB",
                                    YearInducted = 2007,
                                    YearsActive = 1969 - 1982
                                },
                                new Players
                                {
                                    Name = "Aeneas Williams",
                                    Position = "CB",
                                    YearInducted = 2008,
                                    YearsActive = 1991 - 2000
                                },
                                new Players
                                {
                                    Name = "Kurt Warner",
                                    Position = "QB",
                                    YearInducted = 2014,
                                    YearsActive = 2005 - 2009
                                },
                                new Players
                                {
                                    Name = "Adrian Wilson",
                                    Position = "S",
                                    YearInducted = 2015,
                                    YearsActive = 2001 - 2012
                                },
                                new Players 
                                {
                                    Name = "Roy Green",
                                    Position = "WR",
                                    YearInducted = 2016,
                                    YearsActive = 1979 - 1990
                                },
                                new Players
                                {
                                    Name = "Jim Hart",
                                    Position = "QB",
                                    YearInducted = 2017,
                                    YearsActive = 1966 - 1983
                                },
                                new Players
                                {
                                    Name = "Carson Palmer",
                                    Position = "QB",
                                    YearInducted = 2019,
                                    YearsActive = 2013 - 2017
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "Los Angeles",
                            TeamName = "Rams",
                            LogoURL = "",
                            Players = new List<Players>
                            {

                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "",
                        Team = new Teams
                        {
                            City = "San Francisco",
                            TeamName = "49ers",
                            LogoURL = "",
                            Players = new List<Players>
                            {

                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Seattle Seahawks Ring of Honor was established in 1989 and has inducted 12 people thus far who exemplify being a Seattle Seahawk.",
                        Team = new Teams
                        {
                            City = "Seattle",
                            TeamName = "Seahawks",
                            LogoURL = "",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Steve Largent",
                                    Position = "WR",
                                    YearInducted = 1989,
                                    YearsActive = 1976 - 1989
                                },
                                new Players
                                {
                                    Name = "Jim Zorn",
                                    Position = "QB",
                                    YearInducted = 1991,
                                    YearsActive = 1976 - 1984
                                },
                                new Players
                                {
                                    Name = "Dave Brown",
                                    Position = "CB",
                                    YearInducted = 1992,
                                    YearsActive = 1976 - 1986
                                },
                                new Players
                                {
                                    Name = "Pete Gross",
                                    Position = "Radio Announcer",
                                    YearInducted = 1992,
                                    YearsActive = 1976 - 1992
                                },
                                new Players
                                {
                                    Name = "Curt Warner",
                                    Position = "RB",
                                    YearInducted = 1994,
                                    YearsActive = 1983 - 1989
                                },
                                new Players
                                {
                                    Name = "Jacob Green",
                                    Position = "DE",
                                    YearInducted = 1995,
                                    YearsActive = 1980 - 1991
                                },
                                new Players
                                {
                                    Name = "Kenny Easley",
                                    Position = "S",
                                    YearInducted = 2002,
                                    YearsActive = 1981 - 1987
                                },
                                new Players
                                {
                                    Name = "Dave Krieg",
                                    Position = "QB",
                                    YearInducted = 2004,
                                    YearsActive = 1980 - 1991
                                },
                                new Players
                                {
                                    Name = "Chuck Knox",
                                    Position = "Head Coach",
                                    YearInducted = 2005,
                                    YearsActive = 1983 - 1991
                                },
                                new Players
                                {
                                    Name = "Cortez Kennedy",
                                    Position = "DT",
                                    YearInducted = 2006,
                                    YearsActive = 1990 - 2000
                                },
                                new Players
                                {
                                    Name = "Walter Jones",
                                    Position = "OT",
                                    YearInducted = 2014,
                                    YearsActive = 1997 - 2009
                                },
                                new Players
                                {
                                    Name = "Paul Allen",
                                    Position = "Owner",
                                    YearInducted = 2019,
                                    YearsActive = 1996 - 2018
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
 