using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {

    public static async Task SeedData(DataContext context)
        {
            if (!context.RingHonor.Any())
            {
                var ringHonor = new List<RingHonor>
                {
                    new RingHonor
                    {
                        History = "Created in 2000, the Baltimore Ravens Ring of Honor is to honor former players and personnel who made outstanding contributions to the Baltimore Ravens and the Baltimore Colts organizations.",
                        Team = new Teams 
                        {
                            TeamName = "Baltimore Ravens",
                            LogoURL = "https://static.www.nfl.com/t_q-best/league/api/clubs/logos/BAL",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Earnest Byner",
                                    Position = "RB" + ", " + "Coach",
                                    Notes = "The Tie Between Two Cities",
                                    YearInducted = 2001,
                                    YearsActive = "1996 - 2003",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Johnny Unitas",
                                    Position = "QB",
                                    YearInducted = 2002,
                                    YearsActive = "1956 - 1972",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Lenny Moore",
                                    Position = "HB",
                                    YearInducted = 2002,
                                    YearsActive = "1956 - 1967",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Art Donovan",
                                    Position = "DT",
                                    YearInducted = 2002,
                                    YearsActive = "1953 - 1961",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Jim Parker",
                                    Position = "OL",
                                    YearInducted = 2002,
                                    YearsActive = "1957 = 1967",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Raymond Berry",
                                    Position = "WR",
                                    YearInducted = 2002,
                                    YearsActive = "1955 - 1967",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Ted Hendricks",
                                    Position = "LB",
                                    YearInducted = 2002,
                                    YearsActive = "1969 - 1973",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players 
                                {
                                    Name = "John Mackey",
                                    Position = "TE",
                                    YearInducted = 2002,
                                    YearsActive = "1963 - 1971",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Gino Marchetti",
                                    Position = "DE",
                                    YearInducted = 2002,
                                    YearsActive = "1953 = 1966",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Art Modell",
                                    Position = "Founding Owner",
                                    Notes = "Returned the NFL to Baltimore",
                                    YearInducted = 2004,
                                    YearsActive = "1996 - 2003",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Michael McCrary",
                                    Position = "DE",
                                    YearInducted = 2004,
                                    YearsActive = "1997 - 2002",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Peter Boulware",
                                    Position = "LB",
                                    YearInducted = 2006,
                                    YearsActive = "1997 - 2005",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Jonathan Ogden",
                                    Position = "LT",
                                    YearInducted = 2008,
                                    YearsActive = "1996 - 2007",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Matt Stover",
                                    Position = "K",
                                    YearInducted = 2011,
                                    YearsActive = "1996 - 2008",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Jamal Lewis",
                                    Position = "RB",
                                    YearInducted = 2012,
                                    YearsActive = "2000 - 2006",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Ray Lewis",
                                    Position = "LB",
                                    YearInducted = 2013,
                                    YearsActive = "1996 - 2012",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Todd Heap",
                                    Position = "TE",
                                    YearInducted = 2014,
                                    YearsActive = "2001 - 2010",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Ed Reed",
                                    Position = "FS",
                                    YearInducted = 2015,
                                    YearsActive = "2002 - 2012",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Brian Billick",
                                    Position = "Head Coach",
                                    YearInducted = 2019,
                                    YearsActive = "1999 - 2007",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Haloti Ngata",
                                    Position = "DT",
                                    YearInducted = 2021,
                                    YearsActive = "2006 - 2014",
                                    PlayerTeam = "Baltimore Ravens"
                                },
                                new Players
                                {
                                    Name = "Marshal Yanda",
                                    Position = "OG",
                                    YearInducted = 2021,
                                    YearsActive = "2007 - 2019",
                                    PlayerTeam = "Baltimore Ravens"
                                }
                            }
                        }
                    },
                    new RingHonor 
                    {
                        History = "The Cincinnati Bengals introduced a Ring of Honor for their historical team in April of 2021. They announced two inductees, but will let their fans choose two others between a list of 17 other great players to complete its first Ring of Honor class.",
                        Team = new Teams
                        {
                            TeamName = "Cincinnati Bengals",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/CIN.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Paul Brown",
                                    Position = "Team Founder" + ", " + "Head Coach" + ", " + "General Manager",
                                    YearInducted = 2021,
                                    YearsActive = "1968 - 1991",
                                    PlayerTeam = "Cincinnati Bengals"
                                },
                                new Players
                                {
                                    Name = "Anthony Munoz",
                                    Position = "OT",
                                    YearInducted = 2021,
                                    YearsActive = "1980 - 1992",
                                    PlayerTeam = "Cincinnati Bengals"
                                },
                                new Players
                                {
                                    Name = "Ken Anderson",
                                    Position = "QB",
                                    YearInducted = 2021,
                                    YearsActive = "1971 - 1986",
                                    PlayerTeam = "Cincinnati Bengals"
                                },
                                new Players
                                {
                                    Name = "Ken Riley",
                                    Position = "CB",
                                    YearInducted = 2021,
                                    YearsActive = "1969 - 1983",
                                    PlayerTeam = "Cincinnati Bengals"
                                }
                            }
                        }
                    },
                    new RingHonor 
                    {
                        History = "Established in 2010, the Cleveland Browns Ring of Honor commemorates the past greats of the Cleveland Browns franchise. The Inaugural class featured the 16 players who were already inducted into the Pro Football Hall of Fame.",
                        Team = new Teams
                        {
                            TeamName = "Cleveland Browns",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/CLE.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Jim Brown",
                                    Position = "FB",
                                    YearInducted = 2010,
                                    YearsActive = "1957 - 1965",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Paul Brown",
                                    Position = "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1962",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Joe DeLamielleure",
                                    Position = "OG",
                                    YearInducted = 2010,
                                    YearsActive = "1980 - 1984",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Len Ford",
                                    Position = "DE",
                                    YearInducted = 2010,
                                    YearsActive = "1950 - 1957",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Frank Gatski",
                                    Position = "C",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1956",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Otto Graham",
                                    Position = "QB",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1955",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Lou Groza",
                                    Position = "OT" + ", " + "K",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1959" + ", " + "1961 - 1967",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Gene Hickerson",
                                    Position = "OG",
                                    YearInducted = 2010,
                                    YearsActive = "1958 - 1960" + ", " + "1962 - 1973",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Leroy Kelly",
                                    Position = "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1964 - 1973",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Dante Lavelli",
                                    Position = "WR",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1956",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Mike McCormack",
                                    Position = "OT",
                                    YearInducted = 2010,
                                    YearsActive = "1954 - 1962",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Bobby Mitchell",
                                    Position = "WR" + ", " + "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1958 - 1961",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Marion Motley",
                                    Position = "FB",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1953",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Ozzie Newsome",
                                    Position = "TE",
                                    YearInducted = 2010,
                                    YearsActive = "1978 - 1990",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players 
                                {
                                    Name = "Paul Warfield",
                                    Position = "WR",
                                    YearInducted = 2010,
                                    YearsActive = "1964 - 1969" + ", " + "1976 - 1977",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Bill Willis",
                                    Position = "OT" + ", " + "OG",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1953",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Joe Thomas",
                                    Position = "OT",
                                    YearInducted = 2018,
                                    YearsActive = "2007 - 2017",
                                    PlayerTeam = "Cleveland Browns"
                                },
                                new Players
                                {
                                    Name = "Clay Matthews",
                                    Position = "LB",
                                    YearInducted = 2019,
                                    YearsActive = "1978 - 1993",
                                    PlayerTeam = "Cleveland Browns"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Begun in 2017 with an inaugural inductee class of 27, the Pittsburgh Steelers Hall of Honor commemorates the franchise's history.",
                        Team = new Teams
                        {
                            TeamName = "Pittsburgh Steelers",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/PIT.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Jerome Bettis",
                                    Position = "RB",
                                    YearInducted = 2017,
                                    YearsActive = "1996 - 2005",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Mel Blount",
                                    Position = "CB",
                                    YearInducted = 2017,
                                    YearsActive = "1970 - 1983",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Terry Bradshaw",
                                    Position = "QB",
                                    YearInducted = 2017,
                                    YearsActive = "1970 - 1983",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Jack Butler",
                                    Position = "CB",
                                    YearInducted = 2017,
                                    YearsActive = "1951 - 1959",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                    {
                                    Name = "Dermontti Dawson",
                                    Position = "C",
                                    YearInducted = 2017,
                                    YearsActive = "1988 - 2000",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Bill Dudley",
                                    Position = "RB",
                                    YearInducted = 2017,
                                    YearsActive = "1942" + ", " + "1945 - 1946",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Joe Greene",
                                    Position = "DT",
                                    YearInducted = 2017,
                                    YearsActive = "1969 - 1981",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Kevin Greene",
                                    Position = "LB",
                                    YearInducted = 2017,
                                    YearsActive = "1993 - 1995",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "L.C Greenwood",
                                    Position = "DE",
                                    YearInducted = 2017,
                                    YearsActive = "1969 - 1981",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Jack Ham",
                                    Position = "LB",
                                    YearInducted = 2017,
                                    YearsActive = "1971 - 1982",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Franco Harris",
                                    Position = "RB",
                                    YearInducted = 2017,
                                    YearsActive = "1972 - 1983",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Dick Hoak",
                                    Position = "RB" + ", " + "Coach",
                                    YearInducted = 2017,
                                    YearsActive = "1961 - 1970" + ", " + "1972 - 2006",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "John Henry Johnson",
                                    Position = "FB",
                                    YearInducted = 2017,
                                    YearsActive = "1960 - 1965",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Walt Kiesling",
                                    Position = "OG" + ", " + "Head Coach",
                                    YearInducted = 2017,
                                    YearsActive = "1937 - 1939" + ", " + "1939 - 1944" + ", " + "1954 - 1956",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Jack Lambert",
                                    Position = "LB",
                                    YearInducted = 2017,
                                    YearsActive = "1974 - 1984",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Bobby Layne",
                                    Position = "QB",
                                    YearInducted = 2017,
                                    YearsActive = "1958 - 1962",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Johnny '' McNally",
                                    Position = "FB" + ", " + "Head Coach",
                                    Notes = "Hired to be a Player and the Head Coach in 1937",
                                    YearInducted = 2017,
                                    YearsActive = "1934" + ", " + "1937 - 1939",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Chuck Noll",
                                    Position = "Head Coach",
                                    YearInducted = 2017,
                                    YearsActive = "1969 - 1991",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Art Rooney Sr.",
                                    Position = "Founding Owner" + ", " + "President" + ", " + "Chairman of the Board",
                                    YearInducted = 2017,
                                    YearsActive = "1933 - 1988",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Dan Rooney Sr.",
                                    Position = "President" + ", " + "Chairman",
                                    YearInducted = 2017,
                                    YearsActive = "1955 - 2017",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Andy Russell",
                                    Position = "LB",
                                    YearInducted = 2017,
                                    YearsActive = "1963" + ", " + "1966 - 1976",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Donnie Shell",
                                    Position = "S",
                                    YearInducted = 2017,
                                    YearsActive = "1974 - 1987",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "John Stallworth",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = "1974 - 1987",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Ernie Stautner",
                                    Position = "DT",
                                    YearInducted = 2017,
                                    YearsActive = "1950 - 1963",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Lynn Swann",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = "1974 - 1982",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Mike Webster",
                                    Position = "C",
                                    YearInducted = 2017,
                                    YearsActive = "1974 - 1988",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Rod Woodson",
                                    Position = "CB",
                                    YearInducted = 2017,
                                    YearsActive = "1987 - 1996",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Rocky Bleier",
                                    Position = "RB",
                                    YearInducted = 2018,
                                    YearsActive = "1968" + ", " + "1970 - 1980",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Buddy Dial",
                                    Position = "WR",
                                    YearInducted = 2018,
                                    YearsActive = "1959 - 1963",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Alan Faneca",
                                    Position = "OG",
                                    YearInducted = 2018,
                                    YearsActive = "1998 - 2007",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Bill Nunn",
                                    Position = "Scout" + ", " + "Senior Scout" + ", " + "Assistant Director Player Personnel",
                                    YearInducted = 2018,
                                    YearsActive = "1968 - 2014",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Art Rooney Jr.",
                                    Position = "Personnel Director" + ", " + "Vice President",
                                    YearInducted = 2018,
                                    YearsActive = "1965 - 1986" + ", " + "1987 - Present",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Larry Brown",
                                    Position = "TE" + ", " + "OT",
                                    Notes = "Switched to OT in 1977",
                                    YearInducted = 2019,
                                    YearsActive = "1971 - 1976" + ", " + "1977 - 1984",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Bill Cowher",
                                    Position = "Head Coach",
                                    YearInducted = 2019,
                                    YearsActive = "1992 - 2006",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Elbi Nickel",
                                    Position = "TE",
                                    YearInducted = 2019,
                                    YearsActive = "1947 - 1957",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Hines Ward",
                                    Position = "WR",
                                    YearInducted = 2019,
                                    YearsActive = "1998 - 2001",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "James Farrior",
                                    Position = "LB",
                                    YearInducted = 2020,
                                    YearsActive = "2002 - 2011",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Greg Lloyd",
                                    Position = "LB",
                                    YearInducted = 2020,
                                    YearsActive = "1988 - 1997",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Troy Polamalu",
                                    Position = "S",
                                    YearInducted = 2020,
                                    YearsActive = "2003 - 2014",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Mike Wagner",
                                    Position = "S",
                                    YearInducted = 2020,
                                    YearsActive = "1971 - 1980",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Dwight White",
                                    Position = "DE",
                                    YearInducted = 2020,
                                    YearsActive = "1971 - 1980",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Tunch Ilkin",
                                    Position = "OT",
                                    YearInducted = 2021,
                                    YearsActive = "1980 - 1992",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Jon Kolb",
                                    Position = "OT",
                                    YearInducted = 2021,
                                    YearsActive = "1969 - 1981",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Carnell Lake",
                                    Position = "S" + ", " + "CB",
                                    YearInducted = 2021,
                                    YearsActive = "1989 - 1998",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                                new Players
                                {
                                    Name = "Louis Lipps",
                                    Position = "WR",
                                    YearInducted = 2021,
                                    YearsActive = "1984 - 1991",
                                    PlayerTeam = "Pittsburgh Steelers"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Buffalo Bills Wall of Fame was created in 1980 to honor former players, administrators, and coaches who had a significant role in the franchise. The requirements to get inducted into the Wall of Fame are: the individual must have played with the team for three years and must be retired. The selection committee is comprised of club personnel and media members.",
                        Team = new Teams
                        {
                            TeamName = "Buffalo Bills",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/BUF.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "OJ Simpson",
                                    Position = "RB",
                                    YearInducted = 1980,
                                    YearsActive = "1969 - 1977",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Jack Kemp",
                                    Position = "QB",
                                    YearInducted = 1984,
                                    YearsActive = "1962 - 1969",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Pat McGroder",
                                    Position = "Contributor" + ", " + "General Manager",
                                    Notes = "Was instrumental in bringing the Bills to Buffalo during the beginning years of the AFL.",
                                    YearInducted = 1985,
                                    YearsActive = "1961 - 1974",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Tom Sestak",
                                    Position = "DT",
                                    YearInducted = 1987,
                                    YearsActive = "1962 - 1968",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Billy Shaw",
                                    Position = "OG",
                                    YearInducted = 1988,
                                    YearsActive = "1961 - 1969",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Ralph C. Wilson Jr.",
                                    Position = "Founding Owner",
                                    YearInducted = 1989,
                                    YearsActive = "1959 - 2014",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "The 12th Man",
                                    Position = "Fans",
                                    YearInducted = 1992,
                                    YearsActive = "1960 - Present",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Elbert Dubenion",
                                    Position = "WR",
                                    YearInducted = 1993,
                                    YearsActive = "1960 - 1968",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Mike Stratton",
                                    Position = "LB",
                                    YearInducted = 1994,
                                    YearsActive = "1962 - 1972",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Joe Ferguson",
                                    Position = "QB",
                                    YearInducted = 1995,
                                    YearsActive = "1973 - 1984",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Marv Levy",
                                    Position = "Head Coach" + ", " + "General Manager",
                                    YearInducted = 1996,
                                    YearsActive = "1986 - 1997" + ", " + "2006 - 2007",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Joe DeLamielleure",
                                    Position = "OG",
                                    YearInducted = 1997,
                                    YearsActive = "1973 - 1979" + ", " +  "1985",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Robert James",
                                    Position = "CB",
                                    YearInducted = 1998,
                                    YearsActive = "1969 - 1974",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Edward Abramoski",
                                    Position = "Trainer",
                                    YearInducted = 1999,
                                    YearsActive = "1960 - 1996",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Bob Kalsu",
                                    Position = "OG",
                                    Notes = "Killed in Action during the Vietnam War in 1970 after he joined the US Army after the 1986 AFL Season.",
                                    YearInducted = 2000,
                                    YearsActive = "1968",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "George Saimes",
                                    Position = "S",
                                    YearInducted = 2000,
                                    YearsActive = "1963 - 1969",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Jim Kelly",
                                    Position = "QB",
                                    YearInducted = 2001,
                                    YearsActive = "1986 - 1996",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Fred Smerlas",
                                    Position = "DT",
                                    YearInducted = 2001,
                                    YearsActive = "1979 - 1989",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Kent Hull",
                                    Position = "C",
                                    YearInducted = 2002,
                                    YearsActive = "1986 - 1996",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Darryl Talley",
                                    Position = "LB",
                                    YearInducted = 2003,
                                    YearsActive = "1983 - 1994",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Jim Ritcher",
                                    Position = "OG" + ", " + "C",
                                    YearInducted = 2004,
                                    YearsActive = "1980 - 1993",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Thurman Thomas",
                                    Position = "RB",
                                    YearInducted = 2005,
                                    YearsActive = "1988 - 1999",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Andre Reed",
                                    Position = "WR",
                                    YearInducted = 2006,
                                    YearsActive = "1985 - 1999",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Steve Tasker",
                                    Position = "WR" + ", " + "Special Teams",
                                    YearInducted = 2007,
                                    YearsActive = "1986 - 1997",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Bruce Smith",
                                    Position = "DE",
                                    YearInducted = 2008,
                                    YearsActive = "1985 - 1999",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Booker Edgerson",
                                    Position = "DB",
                                    YearInducted = 2010,
                                    YearsActive = "1962 - 1969",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Phil Hansen",
                                    Position = "DE",
                                    YearInducted = 2011,
                                    YearsActive = "1991 - 2001",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Bill Polian",
                                    Position = "General Manager",
                                    YearInducted = 2012,
                                    YearsActive = "1984 - 1992",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Van Miller",
                                    Position = "Broadcaster",
                                    YearInducted = 2014,
                                    YearsActive = "1960 - 1971" + ", " + "1977 - 2003",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Lou Saban",
                                    Position = "Head Coach",
                                    YearInducted = 2015,
                                    YearsActive = "1962 - 1965" + ", " + "1972 - 1976",
                                    PlayerTeam = "Buffalo Bills"
                                },
                                new Players
                                {
                                    Name = "Cookie Gilchrist",
                                    Position = "RB",
                                    YearInducted = 2017,
                                    YearsActive = "1962 - 1964",
                                    PlayerTeam = "Buffalo Bills"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {   
                        History = "The Miami Dolphins Honor Roll was created in 1990 with the induction of five people from the franchise's history. The Honor Roll helps demonstrate the great players and adminstrators from the history of the Dolphins who helped make significant contributions to the team.",
                        Team = new Teams
                        {
                            TeamName = "Miami Dolphins",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/MIA.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Joe Robbie",
                                    Position = "Founding Owner",
                                    YearInducted = 1990,
                                    YearsActive = "1966 - 1989",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Larry Conka",
                                    Position = "FB",
                                    YearInducted = 1990,
                                    YearsActive = "1968 - 1974" + ", " + "1979",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Bob Griese",
                                    Position = "QB",
                                    YearInducted = 1990,
                                    YearsActive = "1967 - 1980",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Jim Langer",
                                    Position = "C",
                                    YearInducted = 1990,
                                    YearsActive = "1970 - 1979",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Paul Warfield",
                                    Position = "WR",
                                    YearInducted = 1990,
                                    YearsActive = "1970 - 1974",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Nick Buoniconti",
                                    Position = "LB",
                                    YearInducted = 1991,
                                    YearsActive = "1969 - 1974" + ", " + "1976",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Larry Little",
                                    Position = "OG",
                                    YearInducted = 1993,
                                    YearsActive = "1969 - 1980",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Dwight Stephenson",
                                    Position = "C",
                                    YearInducted = 1994,
                                    YearsActive = "1980 - 1987",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Bob Kuechenberg",
                                    Position = "OG",
                                    YearInducted = 1995,
                                    YearsActive = "1970 - 1995",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Don Shula",
                                    Position = "Head Coach",
                                    YearInducted = 1996,
                                    YearsActive = "1970 - 1995",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Nat Moore",
                                    Position = "WR",
                                    YearInducted = 1999,
                                    YearsActive = "1974 - 1986",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Dan Marino",
                                    Position = "QB",
                                    YearInducted = 2000,
                                    YearsActive = "1983 - 1999",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Mark Clayton",
                                    Position = "WR",
                                    YearInducted = 2003,
                                    YearsActive = "1983 - 1992",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Mark Duper",
                                    Position = "WR",
                                    YearInducted = 2003,
                                    YearsActive = "1982 - 1992",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Dick Anderson",
                                    Position = "S",
                                    YearInducted = 2006,
                                    YearsActive = "1968 - 1977",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Richmond Webb",
                                    Position = "OT",
                                    YearInducted = 2006,
                                    YearsActive = "1990 - 2000",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Bob Baumhower",
                                    Position = "DT",
                                    YearInducted = 2008,
                                    YearsActive = "1977 - 1986",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Doug Betters",
                                    Position = "DE",
                                    YearInducted = 2008,
                                    YearsActive = "1978 - 1987",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Jake Scott",
                                    Position = "S",
                                    YearInducted = 2010,
                                    YearsActive = "1970 - 1975",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Bill Stanfill",
                                    Position = "DE",
                                    YearInducted = 2010,
                                    YearsActive = "1969 - 1976",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Jim Mandich",
                                    Position = "TE" + ", " + "Radio Broadcaster",
                                    YearInducted = 2011,
                                    YearsActive = "1970 - 1977" + ", " + "1992 - 2004" + ", " + "2007 - 2010",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Jason Taylor",
                                    Position = "LB",
                                    YearInducted = 2012,
                                    YearsActive = "1997 - 2007" + ", " + "2009" + ", " + "2011",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Zach Thomas",
                                    Position = "LB",
                                    YearInducted = 2012,
                                    YearsActive = "1996 - 2007",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Bill Arnsparger",
                                    Position = "Defensive Coordinator",
                                    YearInducted = 2012,
                                    YearsActive = "1970 - 1973" + ", " + "1976 - 1983",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Super Bowl VII & VIII Team, 1972 Perfect Season Team 17-0",
                                    Notes = "The 1972 Team was inducted into the Honor Roll in 1992, but was updated in 2012 to include the Super Bowl VIII Team.",
                                    YearInducted = 2012,
                                    YearsActive = "1972 - 1973",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "John Offerdahl",
                                    Position = "LB",
                                    YearInducted = 2013,
                                    YearsActive = "1986 - 1993",
                                    PlayerTeam = "Miami Dolphins"
                                },
                                new Players
                                {
                                    Name = "Manny Fernandez",
                                    Position = "DT",
                                    YearInducted = 2014,
                                    YearsActive = "1968 - 1975",
                                    PlayerTeam = "Miami Dolphins"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Begun in 1991, the Patriots Team Hall of Fame features franchise greats who impacted the franchise greatly. In order to be eligible, players and coaches must be retired for at least four years.",
                        Team = new Teams
                        {
                            TeamName = "New England Patriots",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/NE.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "John Hannah",
                                    Position = "OG",
                                    YearInducted = 1991,
                                    YearsActive = "1973 - 1985",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Nick Buoniconti",
                                    Position = "LB",
                                    YearInducted = 1992,
                                    YearsActive = "1962 - 1968",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Gino Cappelletti",
                                    Position = "WR" + ", " + "K",
                                    YearInducted = 1992,
                                    YearsActive = "1960 - 1970",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Bob Dee",
                                    Position = "DL",
                                    YearInducted = 1993,
                                    YearsActive = "1960 - 1967",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Jim Lee Hunt",
                                    Position = "DT",
                                    YearInducted = 1993,
                                    YearsActive = "1960 - 1971",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Steve Nelson",
                                    Position = "LB",
                                    YearInducted = 1993,
                                    YearsActive = "1974 - 1987",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Vito 'Babe' Parilli",
                                    Position = "QB",
                                    YearInducted = 1993,
                                    YearsActive = "1961 - 1967",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Mike Haynes",
                                    Position = "CB",
                                    YearInducted = 1994,
                                    YearsActive = "1976 - 1982",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Steve Grogan",
                                    Position = "QB",
                                    YearInducted = 1995,
                                    YearsActive = "1975 - 1990",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Andre Tippett",
                                    Position = "LB",
                                    YearInducted = 1999,
                                    YearsActive = "1982 - 1993",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Bruce Armstrong",
                                    Position = "OT",
                                    YearInducted = 2001,
                                    YearsActive = "1987 - 2000",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Stanley Morgan",
                                    Position = "WR",
                                    YearInducted = 2007,
                                    YearsActive = "1977 - 1989",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Ben Coates",
                                    Position = "TE",
                                    YearInducted = 2008,
                                    YearsActive = "1991 - 1999",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Jim Nance",
                                    Position = "FB",
                                    YearInducted = 2009,
                                    YearsActive = "1965 - 1971",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Billy Sullivan",
                                    Position = "Founding Owner",
                                    YearInducted = 2009,
                                    YearsActive = "1960 - 1988",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Sam Cunningham",
                                    Position = "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1973 - 1982",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Drew Bledsoe",
                                    Position = "QB",
                                    YearInducted = 2011,
                                    YearsActive = "1993 - 2001",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Jon Morris",
                                    Position = "C",
                                    YearInducted = 2011,
                                    YearsActive = "1964 - 1974",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Troy Brown",
                                    Position = "WR" + ", " + "CB" + ", " + "Punt Returner",
                                    YearInducted = 2012,
                                    YearsActive = "1993 - 2007",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Tedy Bruschi",
                                    Position = "LB",
                                    YearInducted = 2013,
                                    YearsActive = "1996 - 2008",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Gil Santos",
                                    Position = "Broadcaster",
                                    YearInducted = 2013,
                                    YearsActive = "1972 - 1979" + ", " + "1991 - 2012",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Ty Law",
                                    Position = "CB",
                                    YearInducted = 2014,
                                    YearsActive = "1995 - 2004",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Willie McGinest",
                                    Position = "DE" + ", " + "LB",
                                    YearInducted = 2015,
                                    YearsActive = "1994 - 2005",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Houston Antwine",
                                    Position = "DL",
                                    YearInducted = 2015,
                                    YearsActive = "1961 - 1971",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Kevin Faulk",
                                    Position = "RB",
                                    YearInducted = 2016,
                                    YearsActive = "1999 - 2011",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Raymond Clayborn",
                                    Position = "CB",
                                    YearInducted = 2017,
                                    YearsActive = "1977 - 1989",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Matt Light",
                                    Position = "OT",
                                    YearInducted = 2018,
                                    YearsActive = "2001 - 2011",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Rodney Harrison",
                                    Position = "S",
                                    YearInducted = 2019,
                                    YearsActive = "2003 - 2008",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Leon Gray",
                                    Position = "OT",
                                    YearInducted = 2019,
                                    YearsActive = "1973 - 1978",
                                    PlayerTeam = "New England Patriots"
                                },
                                new Players
                                {
                                    Name = "Richard Seymour",
                                    Position = "DL",
                                    YearInducted = 2020,
                                    YearsActive = "2001 - 2008",
                                    PlayerTeam = "New England Patriots"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Jets Ring of Honor was established in July 2010 to commemorate and honor former players. Players are nominated by an internal committee before being inducted into the Ring of Honor.",
                        Team = new Teams
                        {
                            TeamName = "New York Jets",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/NYJ.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Joe Namath",
                                    Position = "QB",
                                    YearInducted = 2010,
                                    YearsActive = "1965 - 1976",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Curtis Martin",
                                    Position = "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1998 - 2006",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Joe Klecko",
                                    Position = "DL",
                                    YearInducted = 2010,
                                    YearsActive = "1977 - 1987",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Don Maynard",
                                    Position = "WR",
                                    YearInducted = 2010,
                                    YearsActive = "1960 - 1972",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Winston Hill",
                                    Position = "OT",
                                    YearInducted = 2010,
                                    YearsActive = "1963 - 1976",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Weeb Ewbank",
                                    Position = "Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1963 - 1973",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Larry Grantham",
                                    Position = "LB",
                                    YearInducted = 2011,
                                    YearsActive = "1960 - 1972",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Freeman McNeil",
                                    Position = "RB",
                                    YearInducted = 2011,
                                    YearsActive = "1981 - 1992",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Gerry Philbin",
                                    Position = "DL",
                                    YearInducted = 2011,
                                    YearsActive = "1964 - 1972",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Al Toon",
                                    Position = "WR",
                                    YearInducted = 2011,
                                    YearsActive = "1985 - 1992",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Wesley Walker",
                                    Position = "WR",
                                    YearInducted = 2012,
                                    YearsActive = "1977 - 1989",
                                    PlayerTeam = "New York Jets"
                                },
                                 new Players
                                {
                                    Name = "Mark Gastineau",
                                    Position = "DE",
                                    YearInducted = 2012,
                                    YearsActive = "1979 - 1988",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Marty Lyons",
                                    Position = "DT",
                                    YearInducted = 2013,
                                    YearsActive = "1979 - 1989",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Wayne Chrebet",
                                    Position = "WR",
                                    YearInducted = 2014,
                                    YearsActive = "1995 - 2005",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Leon Hess",
                                    Position = "Owner",
                                    YearInducted = 2014,
                                    YearsActive = "1968 - 1999",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Emerson Boozer",
                                    Position = "RB",
                                    YearInducted = 2015,
                                    YearsActive = "1966 - 1975",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Matt Snell",
                                    Position = "RB",
                                    YearInducted = 2015,
                                    YearsActive = "1964 - 1972",
                                    PlayerTeam = "New York Jets"
                                },
                                new Players
                                {
                                    Name = "Kevin Mawae",
                                    Position = "C",
                                    YearInducted = 2017,
                                    YearsActive = "1998 - 2005",
                                    PlayerTeam = "New York Jets"
                                },   
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "As the newest NFL Franchise, the Houston Texans began their Ring of Honor in 2017.",
                        Team = new Teams
                        {
                            TeamName = "Houston Texans",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/HOU.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Andre Johnson",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = "2003 - 2014",
                                    PlayerTeam = "Houston Texans"
                                },
                                new Players
                                {
                                    Name = "Bob McNair",
                                    Position = "Founding Owner",
                                    YearInducted = 2019,
                                    YearsActive = "2002 - 2018",
                                    PlayerTeam = "Houston Texans"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Established in 1996 and inducted longtime owner, Robert Irsay, as its first inductee before his passing the year following.",
                        Team = new Teams
                        {
                            TeamName = "Indianapolis Colts",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/IND.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Robert Irsay",
                                    Position = "Owner",
                                    YearInducted = 1996,
                                    YearsActive = "1972 - 1997",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Bill Brooks",
                                    Position = "WR",
                                    YearInducted = 1998,
                                    YearsActive = "1986 - 1992",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Ted Marchibroda",
                                    Position = "Head Coach",
                                    YearInducted = 2000,
                                    YearsActive = "1975 - 1979" + ", " + "1992 - 1995",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Chris Hinton",
                                    Position = "OT" + ", " + "OG",
                                    YearInducted = 2001,
                                    YearsActive = "1983 - 1989",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Jim Harbaugh",
                                    Position = "QB",
                                    YearInducted = 2005,
                                    YearsActive = "1994 - 1997",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Tony Dungy",
                                    Position = "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "2002 - 2008",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Marvin Harrison",
                                    Position = "WR",
                                    YearInducted = 2011,
                                    YearsActive = "1996 - 2008",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Edgerrin James",
                                    Position = "RB",
                                    YearInducted = 2012,
                                    YearsActive = "1999 - 2005",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Eric Dickerson",
                                    Position = "RB",
                                    YearInducted = 2013,
                                    YearsActive = "1987 - 1991",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Marshall Faulk",
                                    Position = "RB",
                                    YearInducted = 2013,
                                    YearsActive = "1994 - 1998",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Jeff Saturday",
                                    Position = "C",
                                    YearInducted = 2015,
                                    YearsActive = "1999 - 2011",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Bill Polian",
                                    Position = "President" + ", " + "General Manager",
                                    YearInducted = 2017,
                                    YearsActive = "1998 - 2011",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Peyton Manning",
                                    Position = "QB",
                                    YearInducted = 2017,
                                    YearsActive = "1998 - 2011",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Reggie Wayne",
                                    Position = "WR",
                                    YearInducted = 2018,
                                    YearsActive = "2001 - 2014",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Dwight Freeney",
                                    Position = "DE",
                                    YearInducted = 2019,
                                    YearsActive = "2002 - 2012",
                                    PlayerTeam = "Indianapolis Colts"
                                },
                                new Players
                                {
                                    Name = "Robert Mathis",
                                    Position = "DE",
                                    YearInducted = 2021,
                                    YearsActive = "2003 - 2016",
                                    PlayerTeam = "Indianapolis Colts"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Called the Pride of the Jaguars by the fans in 2006, it represents the Ring of Honor for one fo the newest franchises in the NFL. It was unveiled in the 2006 NFL season against the New York Jets.",
                        Team = new Teams
                        {
                            TeamName = "Jacksonville Jaguars",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/JAX.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Tony Boselli",
                                    Position = "OT",
                                    YearInducted = 2006,
                                    YearsActive = "1995 - 2001",
                                    PlayerTeam = "Jacksonville Jaguars"
                                },
                                new Players
                                {
                                    Name = "Wayne and Delores Weaver",
                                    Position = "Founding Owners",
                                    YearInducted = 2011,
                                    YearsActive = "1993 - 2011",
                                    PlayerTeam = "Jacksonville Jaguars"
                                },
                                new Players
                                {
                                    Name = "Fred Taylor",
                                    Position = "RB",
                                    YearInducted = 2012,
                                    YearsActive = "1998 - 2003",
                                    PlayerTeam = "Jacksonville Jaguars"
                                },
                                new Players
                                {
                                    Name = "Mark Brunell",
                                    Position = "QB",
                                    YearInducted = 2013,
                                    YearsActive = "1995 - 2003",
                                    PlayerTeam = "Jacksonville Jaguars"
                                },
                                new Players
                                {
                                    Name = "Jimmy Smith",
                                    Position = "WR",
                                    YearInducted = 2016,
                                    YearsActive = "1995 - 2005",
                                    PlayerTeam = "Jacksonville Jaguars"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Establishment of the Titans/Oilers Hall of Fame coincides with the 40th anniversary of the franchise by Owner, Bud Adams. It encompasses the history of the Houston Oilers and the Tennessee Titans respectively.",
                        Team = new Teams
                        {
                            TeamName = "Tennessee Titans",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/TEN.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Elvin Bethea",
                                    Position = "DE",
                                    YearInducted = 1999,
                                    YearsActive = "1968 - 1983",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "George Blanda",
                                    Position = "QB" + ", " + "K",
                                    YearInducted = 1999,
                                    YearsActive = "1960 - 1966",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Earl Campbell",
                                    Position = "RB",
                                    YearInducted = 1999,
                                    YearsActive = "1978 - 1984",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Mike Holovak",
                                    Position = "General Manager",
                                    YearInducted = 1999,
                                    YearsActive = "1989 - 1993",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Ken Houston",
                                    Position = "S",
                                    YearInducted = 1999,
                                    YearsActive = "1967 - 1972",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Mike Munchak",
                                    Position = "OG",
                                    YearInducted = 1999,
                                    YearsActive = "1982 - 1993",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Jim Norton",
                                    Position = "P",
                                    YearInducted = 1999,
                                    YearsActive = "1960 - 1968",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Bruce Matthews",
                                    Position = "OL",
                                    YearInducted = 2002,
                                    YearsActive = "1983 - 2001",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Warren Moon",
                                    Position = "QB",
                                    YearInducted = 2007,
                                    YearsActive = "1984 - 1993",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Bud Adams",
                                    Position = "Founding Owner",
                                    YearInducted = 2008,
                                    YearsActive = "1959 - 2013",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Eddie George",
                                    Position = "RB",
                                    YearInducted = 2008,
                                    YearsActive = "1996 - 2003",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Steve McNair",
                                    Position = "QB",
                                    YearInducted = 2008,
                                    YearsActive = "1995 - 2005",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Frank Wycheck",
                                    Position = "TE",
                                    YearInducted = 2008,
                                    YearsActive = "1995 - 2003",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Robert Brazile",
                                    Position = "LB",
                                    YearInducted = 2018,
                                    YearsActive = "1975 - 1984",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Bum Phillips",
                                    Position = "Defensive Coordinator" + ", " + "Head Coach",
                                    YearInducted = 2021,
                                    YearsActive = "1974 - 1980",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Jeff Fisher",
                                    Position = "Defensive Coordinator" + ", " + "Head Coach",
                                    YearInducted = 2021,
                                    YearsActive = "1994 - 2010",
                                    PlayerTeam = "Tennessee Titans"
                                },
                                new Players
                                {
                                    Name = "Floyd Reese",
                                    Position = "Linebackers Coach" + ", " + "Assistant General Manager" + "General Manager",
                                    YearInducted = 2021,
                                    YearsActive = "1986 - 2006",
                                    PlayerTeam = "Tennessee Titans"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Began in 1984, the Broncos have a Ring of Fame to honor their former players, executives, and coaches who have made a great impact on the team.",
                        Team = new Teams
                        {
                            TeamName = "Denver Broncos",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/DEN.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Goose Gonsoulin",
                                    Position = "S",
                                    YearInducted = 1984,
                                    YearsActive = "1960 - 1966",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Rich Jackson",
                                    Position = "DE",
                                    YearInducted = 1984,
                                    YearsActive = "1967 - 1972",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Floyd Little",
                                    Position = "RB",
                                    YearInducted = 1984,
                                    YearsActive = "1967 - 1975",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Lionel Taylor",
                                    Position = "WR",
                                    YearInducted = 1984,
                                    YearsActive = "1960 - 1966",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Gerald Phipps",
                                    Position = "Owner",
                                    YearInducted = 1985,
                                    YearsActive = "1961 - 1981",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Charley Johnson",
                                    Position = "QB",
                                    YearInducted = 1986,
                                    YearsActive = "1972 - 1975",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Paul Smith",
                                    Position = "DE",
                                    YearInducted = 1986,
                                    YearsActive = "1968 - 1978",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Franck Tripucka",
                                    Position = "QB",
                                    YearInducted = 1986,
                                    YearsActive = "1960 - 1963",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Billy Thompson",
                                    Position = "CB" + ", " + "S",
                                    YearInducted = 1987,
                                    YearsActive = "1969 - 1981",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Craig Morton",
                                    Position = "QB",
                                    YearInducted = 1988,
                                    YearsActive = "1977 - 1982",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Haven Moses",
                                    Position = "WR",
                                    YearInducted = 1988,
                                    YearsActive = "1972 - 1981",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Jim Turner",
                                    Position = "K",
                                    YearInducted = 1988,
                                    YearsActive = "1971 - 1979",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Randy Gradishar",
                                    Position = "LB",
                                    YearInducted = 1989,
                                    YearsActive = "1974 - 1983",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Tom Jackson",
                                    Position = "LB",
                                    YearInducted = 1992,
                                    YearsActive = "1973 - 1986",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Louis Wright",
                                    Position = "CB",
                                    YearInducted = 1993,
                                    YearsActive = "1975 - 1986",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "John Elway",
                                    Position = "QB" + ", " + "General Manager",
                                    YearInducted = 1999,
                                    YearsActive = "1983 - 1998" + ", " + "2011 - 2020",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Karl Mecklenburg",
                                    Position = "LB",
                                    YearInducted = 2001,
                                    YearsActive = "1983 - 1995",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Dennis Smith",
                                    Position = "SS",
                                    YearInducted = 2001,
                                    YearsActive = "1981 - 1994",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Gary Zimmerman",
                                    Position = "OT",
                                    YearInducted = 2003,
                                    YearsActive = "1993 - 1997",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Steve Atwater",
                                    Position = "SS",
                                    YearInducted = 2005,
                                    YearsActive = "1989 - 1998",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Terrell Davis",
                                    Position = "RB",
                                    YearInducted = 2007,
                                    YearsActive = "1995 - 2001",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Shannon Sharpe",
                                    Position = "TE",
                                    YearInducted = 2009,
                                    YearsActive = "1990 - 1999" + ", " + "2002 - 2003",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Rod Smith",
                                    Position = "WR",
                                    YearInducted = 2012,
                                    YearsActive = "1994 - 2006",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Tom Nalen",
                                    Position = "C",
                                    YearInducted = 2012,
                                    YearsActive = "1994 - 2007",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Gene Mingo",
                                    Position = "RB" + ", " + "K" + ", " + "Return Specialist",
                                    YearInducted = 2014,
                                    YearsActive = "1960 - 1964",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Dan Reeves",
                                    Position = "Head Coach",
                                    YearInducted = 2014,
                                    YearsActive = "1981 - 1992",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Rick Upchurch",
                                    Position = "WR" + ", " + "Return Specialist",
                                    YearInducted = 2014,
                                    YearsActive = "1975 - 1983",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Pat Bowlen",
                                    Position = "Owner",
                                    YearInducted = 2015,
                                    YearsActive = "1984 - 2013",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Jason Elam",
                                    Position = "K",
                                    YearInducted = 2016,
                                    YearsActive = "1993 - 2007",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Simon Fletcher",
                                    Position = "LB" + ", " + "DE",
                                    YearInducted = 2016,
                                    YearsActive = "1985 - 1995",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "John Lynch",
                                    Position = "SS",
                                    YearInducted = 2016,
                                    YearsActive = "2004 - 2007",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Red Miller",
                                    Position = "Head Coach",
                                    YearInducted = 2017,
                                    YearsActive = "1977 - 1980",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Champ Bailey",
                                    Position = "CB",
                                    YearInducted = 2019,
                                    YearsActive = "2004 - 2013",
                                    PlayerTeam = "Denver Broncos"
                                },
                                new Players
                                {
                                    Name = "Peyton Manning",
                                    Position = "QB",
                                    YearInducted = 2021,
                                    YearsActive = "2012 - 2015",
                                    PlayerTeam = "Denver Broncos"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "A Team Hall of Fame that was established in 1970. Each year except 1983 and 2020, has included one inductee. Requirements for induction are that a player, coach, or contributor must have been with the team for four years and been retired for four years. Three exceptions to that are Mack Lee Hill, Joe Delaney, and Derrick Thomas. ",
                        Team = new Teams
                        {
                            TeamName = "Kansas City Chiefs",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/KC.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Lamar Hunt",
                                    Position = "Founding Owner",
                                    YearInducted = 1970,
                                    YearsActive = "1960 - 2006",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Mack Lee Hill",
                                    Position = "RB",
                                    Notes = "He passed away suddenly after a knee surgery after a game against the Buffalo Bills.",
                                    YearInducted = 1971,
                                    YearsActive = "1961 - 1974",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jerry Mays",
                                    Position = "DT",
                                    YearInducted = 1972,
                                    YearsActive = "1961 - 1970",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Fred Arbanas",
                                    Position = "TE",
                                    YearInducted = 1973,
                                    YearsActive = "1962 - 1970",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Johnny Robinson",
                                    Position = "S",
                                    YearInducted = 1974,
                                    YearsActive = "1960 - 1971",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Chris Burford",
                                    Position = "WR",
                                    YearInducted = 1975,
                                    YearsActive = "1960 - 1967",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "E.J Holub",
                                    Position = "C" + ", " + "LB",
                                    YearInducted = 1976,
                                    YearsActive = "1961 - 1970",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jim Tyrer",
                                    Position = "OT",
                                    YearInducted = 1977,
                                    YearsActive = "1961 - 1973",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Mike Garrett",
                                    Position = "RB",
                                    YearInducted = 1978,
                                    YearsActive = "1966 - 1970",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Len Dawson",
                                    Position = "QB",
                                    YearInducted = 1979,
                                    YearsActive = "1963 - 1975",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Bobby Bell",
                                    Position = "LB",
                                    YearInducted = 1980,
                                    YearsActive = "1963 - 1974",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Buck Buchanan",
                                    Position = "DT",
                                    YearInducted = 1981,
                                    YearsActive = "1963 - 1975",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Otis Taylor",
                                    Position = "WR",
                                    YearInducted = 1982,
                                    YearsActive = "1965 - 1975",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Ed Budde",
                                    Position = "OG",
                                    YearInducted = 1984,
                                    YearsActive = "1963 - 1976",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Willie Lanier",
                                    Position = "LB",
                                    YearInducted = 1985,
                                    YearsActive = "1967 - 1977",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Emmitt Thomas",
                                    Position = "CB",
                                    YearInducted = 1986,
                                    YearsActive = "1966 - 1978",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Hank Stram",
                                    Position = "Head Coach",
                                    YearInducted = 1987,
                                    YearsActive = "1960 - 1974",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jerrel Wilson",
                                    Position = "P",
                                    YearInducted = 1988,
                                    YearsActive = "1963 - 1977",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Ed Podolak",
                                    Position = "RB",
                                    YearInducted = 1989,
                                    YearsActive = "1969 - 1977",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jim Lynch",
                                    Position = "LB",
                                    YearInducted = 1990,
                                    YearsActive = "1967 - 1977",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Abner Haynes",
                                    Position = "RB",
                                    YearInducted = 1991,
                                    YearsActive = "1960 - 1964",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jan Stenerud",
                                    Position = "K",
                                    YearInducted = 1992,
                                    YearsActive = "1967 - 1979",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Sherrill Headrick",
                                    Position = "LB",
                                    YearInducted = 1993,
                                    YearsActive = "1960 - 1967",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jack Rudnay",
                                    Position = "C",
                                    YearInducted = 1994,
                                    YearsActive = "1969 - 1982",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Curtis McClinton",
                                    Position = "RB",
                                    YearInducted = 1995,
                                    YearsActive = "1962 - 1969",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Deron Cherry",
                                    Position = "S",
                                    YearInducted = 1996,
                                    YearsActive = "1981 - 1991",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Dave Hill",
                                    Position = "OT",
                                    YearInducted = 1997,
                                    YearsActive = "1963 - 1974",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Art Still",
                                    Position = "DE",
                                    YearInducted = 1998,
                                    YearsActive = "1978 - 1987",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Lloyd Burruss",
                                    Position = "S",
                                    YearInducted = 1999,
                                    YearsActive = "1981 - 1991",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Christian Okoye",
                                    Position = "RB",
                                    YearInducted = 2000,
                                    YearsActive = "1987 - 1991",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Derrick Thomas",
                                    Position = "LB",
                                    Notes = "After the 1999 Season, Thomas was in a car accident that left him paralyzed. He passed away a few days after.",
                                    YearInducted = 2001,
                                    YearsActive = "1989 - 1999",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "John Alt",
                                    Position = "OT",
                                    YearInducted = 2002,
                                    YearsActive = "1984 - 1996",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Gary Spani",
                                    Position = "LB",
                                    YearInducted = 2003,
                                    YearsActive = "1978 - 1986",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Joe Delaney",
                                    Position = "RB",
                                    Notes = "Passed away in 1983, after his second year with the Chiefs.",
                                    YearInducted = 2004,
                                    YearsActive = "1981 - 1982",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Jack Steadman",
                                    Position = "President" + ", " + "General Manager",
                                    YearInducted = 2005,
                                    YearsActive = "1960 - 1989",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Neil Smith",
                                    Position = "DE",
                                    YearInducted = 2006,
                                    YearsActive = "1988 - 1996",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Albert Lewis",
                                    Position = "CB",
                                    YearInducted = 2007,
                                    YearsActive = "1983 - 1993",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Curley Culp",
                                    Position = "DT",
                                    YearInducted = 2008,
                                    YearsActive = "1968 - 1974",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Nick Lowery",
                                    Position = "K",
                                    YearInducted = 2009,
                                    YearsActive = "1980 - 1993",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Marty Schottenheimer",
                                    Position = "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1989 - 1998",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Kevin Ross",
                                    Position = "CB",
                                    YearInducted = 2011,
                                    YearsActive = "1984 - 1993" + ", " + "1997",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Will Shields",
                                    Position = "OG",
                                    YearInducted = 2012,
                                    YearsActive = "1993 - 2006",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Gary Barbaro",
                                    Position = "S",
                                    YearInducted = 2013,
                                    YearsActive = "1976 - 1982",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Priest Holmes",
                                    Position = "RB",
                                    YearInducted = 2014,
                                    YearsActive = "2001 - 2007",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Gary Green",
                                    Position = "CB",
                                    YearInducted = 2015,
                                    YearsActive = "1977 - 1983",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Tony Richardson",
                                    Position = "FB",
                                    YearInducted = 2016,
                                    YearsActive = "1995 - 2005",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Carlos Carson",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = "1980 - 1989",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Tony Gonzalez",
                                    Position = "TE",
                                    YearInducted = 2018,
                                    YearsActive = "1997 - 2008",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                                new Players
                                {
                                    Name = "Brian Waters",
                                    Position = "OG",
                                    YearInducted = 2019,
                                    YearsActive = "2000 - 2010",
                                    PlayerTeam = "Kansas City Chiefs"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Raiders currently do not have a Ring of Honor or team Hall of Fame to commemorate their players, coaches, or executives.",
                        Team = new Teams
                        {
                            TeamName = "Las Vegas Raiders",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/LV.svg",
                            Players = new List<Players>
                            {
                                null
                            }
                        }
                    },
                    new RingHonor
                    {

                        History = "Began in 1976, the Chargers Hall of Fame acts as their Ring of Honor. All four inductees in this year were inducted posthumously. In 2012, the team allowed the fans to induct that year's inductee, choosing Punter, Darren Bennett. After moving to Los Angeles in 2017, the Chargers inducted Bobby Beathard to the Team Hall of Fame in 2018.",
                        Team = new Teams
                        {
                            TeamName = "Los Angeles Chargers",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/LAC.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Emil Karas",
                                    Position = "LB",
                                    YearInducted = 1976,
                                    YearsActive = "1960 - 1966",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Frank Buncom",
                                    Position = "LB",
                                    YearInducted = 1976,
                                    YearsActive = "1962 - 1968",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Bob Laraba",
                                    Position = "LB",
                                    Notes = "Killed in 1961 after his second season.",
                                    YearInducted = 1976,
                                    YearsActive = "1960 - 1961",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Jacque MacKinnon",
                                    Position = "TE",
                                    YearInducted = 1976,
                                    YearsActive = "1961 - 1969",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Lance Alworth",
                                    Position = "WR",
                                    YearInducted = 1977,
                                    YearsActive = "1962 - 1970",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Ron Mix",
                                    Position = "OT",
                                    YearInducted = 1978,
                                    YearsActive = "1960- 1969",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Paul Lowe",
                                    Position = "RB",
                                    YearInducted = 1979,
                                    YearsActive = "1960 - 1968",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Barron Hilton",
                                    Position = "Majority Founding Owner",
                                    YearInducted = 1980,
                                    YearsActive = "1960 - 1966",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Keith Lincoln",
                                    Position = "RB",
                                    YearInducted = 1980,
                                    YearsActive = "1961 - 1968",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Ernie Ladd",
                                    Position = "DT",
                                    YearInducted = 1981,
                                    YearsActive = "1961 - 1965",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Walt Sweeney",
                                    Position = "G",
                                    YearInducted = 1981,
                                    YearsActive = "1963 - 1973",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "John Hadl",
                                    Position = "QB",
                                    YearInducted = 1983,
                                    YearsActive = "1962 - 1972",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Chuck Allen",
                                    Position = "LB",
                                    YearInducted = 1984,
                                    YearsActive = "1961 - 1969",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Gary Giarrison",
                                    Position = "WR",
                                    YearInducted = 1985,
                                    YearsActive = "1966 - 1976",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Sid Gillman",
                                    Position = "Head Coach",
                                    YearInducted = 1985,
                                    YearsActive = "1961 - 1969" + ", " + "1971",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Earl Faison",
                                    Position = "DE",
                                    YearInducted = 1986,
                                    YearsActive = "1961 - 1966",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Dan Fouts",
                                    Position = "QB",
                                    YearInducted = 1993,
                                    YearsActive = "1973 - 1987",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Charlie Joiner",
                                    Position = "WR",
                                    YearInducted = 1993,
                                    YearsActive = "1976 - 1986",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Don Coryell",
                                    Position = "Head Coach",
                                    YearInducted = 1994,
                                    YearsActive = "1978 - 1986",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Speedy Duncan",
                                    Position = "CB",
                                    YearInducted = 1995,
                                    YearsActive = "1968 - 1982",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Russ Washington",
                                    Position = "OT",
                                    YearInducted = 1995,
                                    YearsActive = "1968 - 1982",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Kellen Winslow",
                                    Position = "TE",
                                    YearInducted = 1995,
                                    YearsActive = "1979 - 1987",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "George Pernicano",
                                    Position = "Minority Owner",
                                    YearInducted = 1996,
                                    YearsActive = "1961 - Present",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Rolf Benirschke",
                                    Position = "K",
                                    YearInducted = 1997,
                                    YearsActive = "1978 - 1987",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Gill Byrd",
                                    Position = "CB",
                                    YearInducted = 1998,
                                    YearsActive = "1983 - 1992",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Gary 'Big Hands' Johnson",
                                    Position = "DT",
                                    YearInducted = 1999,
                                    YearsActive = "1975 - 1984",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Doug Wilkerson",
                                    Position = "OG",
                                    YearInducted = 2000,
                                    YearsActive = "1971 - 1984",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Wes Chandler",
                                    Position = "WR",
                                    YearInducted = 2001,
                                    YearsActive = "1981 - 1987",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Stan Humphries",
                                    Position = "QB",
                                    YearInducted = 2002,
                                    YearsActive = "1992 - 1997",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Bobby Ross",
                                    Position = "Head Coach",
                                    YearInducted = 2002,
                                    YearsActive = "1992 - 1996",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Louie Kelcher",
                                    Position = "DT",
                                    YearInducted = 2003,
                                    YearsActive = "1975 - 1983",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Don Macek",
                                    Position = "C",
                                    YearInducted = 2004,
                                    YearsActive = "1976 - 1989",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Ed White",
                                    Position = "OG",
                                    YearInducted = 2004,
                                    YearsActive = "1978 - 1985",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Fred Dean",
                                    Position = "DE",
                                    YearInducted = 2008,
                                    YearsActive = "1975 - 1981",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Junior Seau",
                                    Position = "LB",
                                    YearInducted = 2011,
                                    YearsActive = "1990 - 2002",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Darren Bennett",
                                    Position = "P",
                                    YearInducted = 2012,
                                    YearsActive = "1995 - 2003",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "The 1963 AFL Championship Team",
                                    YearInducted = 2013,
                                    YearsActive = "1963",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Leslie O'Neal",
                                    Position = "DE",
                                    YearInducted = 2014,
                                    YearsActive = "1986 - 1995",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "LaDainian Tomlinson",
                                    Position = "RB",
                                    YearInducted = 2015,
                                    YearsActive = "2001 - 2009",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                                new Players
                                {
                                    Name = "Bobby Beathard",
                                    Position = "General Manager",
                                    YearInducted = 2018,
                                    YearsActive = "1990 - 2000",
                                    PlayerTeam = "Los Angeles Chargers"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Chicago Bears currently do not have a Ring of Honor or team Hall of Fame to commemorate players, coaches, or executives.",
                        Team = new Teams
                        {
                            TeamName = "Chicago Bears",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/CHI.svg",
                            Players = new List<Players>
                            {
                                null
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Pride of the Lions begun in 2009 with an introductory class of 12 players. Only three players in the Pride of the Lions are not in the Hall of Fame.",
                        Team = new Teams
                        {
                            TeamName = "Detroit Lions",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/DET.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Lem Barney",
                                    Position = "CB",
                                    YearInducted = 2009,
                                    YearsActive = "1967 - 1977",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Roger Brown",
                                    Position = "DT",
                                    YearInducted = 2018,
                                    YearsActive = "1960 - 1966",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Jack Christiansen",
                                    Position = "DB",
                                    YearInducted = 2009,
                                    YearsActive = "1951 - 1958",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Dutch Clark",
                                    Position = "QB",
                                    YearInducted = 2009,
                                    YearsActive = "1934 - 1938",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Lou Creekmur",
                                    Position = "OT" + ", " + "OG",
                                    YearInducted = 2009,
                                    YearsActive = "1950 - 1959",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Jason Hanson",
                                    Position = "K",
                                    YearInducted = 2013,
                                    YearsActive = "1992 - 2012",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Alex Karras",
                                    Position = "DT",
                                    YearInducted = 2018,
                                    YearsActive = "1958 - 1970",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Dick 'Night Train' Lane",
                                    Position = "CB",
                                    YearInducted = 2009,
                                    YearsActive = "1960 - 1965",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Yale Lary",
                                    Position = "CB" + ", " + "P",
                                    YearInducted = 2009,
                                    YearsActive = "1952 - 1953" + ", " + "1956 - 1964",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Bobby Layne",
                                    Position = "QB",
                                    YearInducted = 2009,
                                    YearsActive = "1961 - 1974",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Dick LeBeau",
                                    Position = "CB",
                                    YearInducted = 2010,
                                    YearsActive = "1959 - 1972",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Herman Moore",
                                    Position = "WR",
                                    YearInducted = 2018,
                                    YearsActive = "1991 - 2001",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Barry Sanders",
                                    Position = "RB",
                                    YearInducted = 2018,
                                    YearsActive = "1989 - 1998",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Charlie Sanders",
                                    Position = "TE",
                                    YearInducted = 2009,
                                    YearsActive = "1968 - 1977",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Joe Schmidt",
                                    Position = "LB",
                                    YearInducted = 2009,
                                    YearsActive = "1953 - 1965",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Dick Stanfel",
                                    Position = "OG",
                                    YearInducted = 2009,
                                    YearsActive = "1952 - 1955",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Doak Walker",
                                    Position = "RB",
                                    YearInducted = 2009,
                                    YearsActive = "1950 - 1955",
                                    PlayerTeam = "Detroit Lions"
                                },
                                new Players
                                {
                                    Name = "Alex Wojciechowicz",
                                    Position = "C" + ", " +  "LB",
                                    YearInducted = 2009,
                                    YearsActive = "1938 - 1946",
                                    PlayerTeam = "Detroit Lions"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "For the Lambeau Field Ring of Honor that is dedicated to former Packers greats, the only requirements for to be inducted into it seemingly, is to be a Hall of Famer and contributed to the Packers organization in meaningful ways. The Packers do have a team Hall of Fame that includes over 150 former franchise greats.",
                        Team = new Teams
                        {
                            TeamName = "Green Bay Packers",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/GB.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Herb Adderley",
                                    Position = "CB",
                                    YearsActive = "1961 - 1969",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Tony Canadeo",
                                    Position = "RB",
                                    YearsActive = "1941 - 1944" + ", " + "1946 - 1952",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Willie Davis",
                                    Position = "DE",
                                    YearsActive = "1960 - 1969",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Brett Favre",
                                    Position = "QB",
                                    YearsActive = "1992 - 2007",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Forrest Gregg",
                                    Position = "OT",
                                    YearsActive = "1956" + ", " + "1958 - 1970",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Arnie Herber",
                                    Position = "QB",
                                    YearsActive = "1930 - 1940",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Clarke Hinkle",
                                    Position = "FB",
                                    YearsActive = "1932 - 1941",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Paul Hornung",
                                    Position = "RB",
                                    YearsActive = "1956 - 1962" + ", " + "1964 - 1966",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Cal Hubbard",
                                    Position = "OT",
                                    YearsActive = "1929 - 1933" + ", " + "1935",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Don Hutson",
                                    Position = "TE" + ", " + "DE",
                                    YearsActive = "1935 - 1945",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Henry Jordan",
                                    Position = "DT",
                                    YearsActive = "1959 - 1969",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Jerry Kramer",
                                    Position = "OG",
                                    YearsActive = "1958 - 1968",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Earl 'Curly' Lambeau",
                                    Position = "RB" + ", " + "Head Coach",
                                    YearsActive = "1919 - 1929" + ", " + "1930 - 1949",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "James Lofton",
                                    Position = "WR",
                                    YearsActive = "1978 - 1986",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Vince Lombardi",
                                    Position = "Head Coach",
                                    YearsActive = "1959 - 1967",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Johnny 'Blood' McNally",
                                    Position = "RB",
                                    YearsActive = "1929 - 1933" + ", " + "1935 - 1936",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Mike Michalske",
                                    Position = "OG",
                                    YearsActive = "1929 - 1935" + ", " + "1937",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Ray Nitschke",
                                    Position = "LB",
                                    YearsActive = "1958 - 1972",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Jim Ringo",
                                    Position = "C",
                                    YearsActive = "1953 - 1963",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Dave Robinson",
                                    Position = "LB",
                                    YearsActive = "1963 - 1972",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Bart Starr",
                                    Position = "QB",
                                    YearsActive = "1956 - 1971",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Jim Taylor",
                                    Position = "FB",
                                    YearsActive = "1958 - 1966",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Reggie White",
                                    Position = "DE",
                                    YearsActive = "1993 - 1998",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Ron Wolf",
                                    Position = "General Manager",
                                    YearsActive = "1991 - 2001",
                                    PlayerTeam = "Green Bay Packers"
                                },
                                new Players
                                {
                                    Name = "Willie Wood",
                                    Position = "S",
                                    YearsActive = "1960 - 1971",
                                    PlayerTeam = "Green Bay Packers"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Started in 1998, the Minnesota Vikings Ring of Honor was begun with six players, coaches, and executives.",
                        Team = new Teams
                        {
                            TeamName = "Minnesota Vikings",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/MIN.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Fran Tarkenton",
                                    Position = "QB",
                                    YearInducted = 1998,
                                    YearsActive = "1961 - 1966" + ", " + "1972 - 1978",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Alan Page",
                                    Position = "DT",
                                    YearInducted = 1998,
                                    YearsActive = "1967 - 1978",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Jim Finks",
                                    Position = "General Manager",
                                    YearInducted = 1998,
                                    YearsActive = "1964 - 1973",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Bud Grant",
                                    Position = "Head Coach",
                                    YearInducted = 1998,
                                    YearsActive = "1967 - 1983" + ", " + "1985",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Paul Krause",
                                    Position = "S",
                                    YearInducted = 1998,
                                    YearsActive = "1968 - 1979",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Fred Zamberletti",
                                    Position = "Medical Adviser",
                                    YearInducted = 1998,
                                    YearsActive = "1961 - 2011",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Jim Marshall",
                                    Position = "DE",
                                    YearInducted = 1999,
                                    YearsActive = "1961 - 1979",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Ron Yary",
                                    Position = "OT",
                                    YearInducted = 2001,
                                    YearsActive = "1968 - 1981",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Korey Stringer",
                                    Position = "OT",
                                    YearInducted = 2001,
                                    YearsActive = "1995 - 2000",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Mick Tingelhoff",
                                    Position = "C",
                                    YearInducted = 2001,
                                    YearsActive = "1962 - 1978",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Carl Eller",
                                    Position = "DE",
                                    YearInducted = 2002,
                                    YearsActive = "1964 - 1978",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Cris Carter",
                                    Position = "WR",
                                    YearInducted = 2003,
                                    YearsActive = "1990 - 2001",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Bill Brown",
                                    Position = "RB",
                                    YearInducted = 2004,
                                    YearsActive = "1962 - 1974",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Jerry Burns",
                                    Position = "Head Coach",
                                    YearInducted = 2005,
                                    YearsActive = "1986 - 1991",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Randall McDaniel",
                                    Position = "OG",
                                    YearInducted = 2006,
                                    YearsActive = "1988 - 1999",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Chuck Foreman",
                                    Position = "RB",
                                    YearInducted = 2007,
                                    YearsActive = "1973 - 1979",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "John Randle",
                                    Position = "DT",
                                    YearInducted = 2008,
                                    YearsActive = "1961 - 1974",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Scott Studwell",
                                    Position = "LB",
                                    YearInducted = 2009,
                                    YearsActive = "1977 - 1990",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Chris Doleman",
                                    Position = "DE",
                                    YearInducted = 2011,
                                    YearsActive = "1985 - 1993" + ", " + "1999",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Matt Blair",
                                    Position = "LB",
                                    YearInducted = 2012,
                                    YearsActive = "1974 - 1985",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Joey Browner",
                                    Position = "S",
                                    YearInducted = 2013,
                                    YearsActive = "1983 - 1991",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Randy Moss",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = "1998 - 2004" + ", " + "2010",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Ahmad Rashad",
                                    Position = "WR",
                                    YearInducted = 2017,
                                    YearsActive = "1976 - 1982",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Dennis Green",
                                    Position = "Head Coach",
                                    YearInducted = 2018,
                                    YearsActive = "1992 - 2001",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Steve Jordan",
                                    Position = "TE",
                                    YearInducted = 2019,
                                    YearsActive = "1982 - 1994",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                                new Players
                                {
                                    Name = "Kevin Williams",
                                    Position = "DT",
                                    YearInducted = 2021,
                                    YearsActive = "2003 - 2013",
                                    PlayerTeam = "Minnesota Vikings"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "First introduced in Texas Stadium in Irving, Texas, the Cowboys Ring of Honor, in the words of Jerry Jones: 'stands for men who built this franchise and it had it call America's team.' ",
                        Team = new Teams
                        {
                            TeamName = "Dallas Cowboys",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/DAL.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Bob Lilly",
                                    Position = "DT",
                                    YearInducted = 1975,
                                    YearsActive = "1961 - 1974",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Don Meredith",
                                    Position = "QB",
                                    YearInducted = 1976,
                                    YearsActive = "1960 - 1968",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Don Perkins",
                                    Position = "FB",
                                    YearInducted = 1976,
                                    YearsActive = "1961 - 1968",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Chuck Howley",
                                    Position = "LB",
                                    YearInducted = 1977,
                                    YearsActive = "1961 - 1973",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Mel Renfro",
                                    Position = "CB",
                                    YearInducted = 1981,
                                    YearsActive = "1964 - 1977",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Roger Staubach",
                                    Position = "QB",
                                    YearInducted = 1983,
                                    YearsActive = "1969 - 1979",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Lee Roy Jordan",
                                    Position = "LB" + ", " + "C",
                                    YearInducted = 1989,
                                    YearsActive = "1963 - 1976",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Tom Landry",
                                    Position = "Head Coach",
                                    YearInducted = 1993,
                                    YearsActive = "1960 - 1988",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players 
                                {
                                    Name = "Tony Dorsett",
                                    Position = "RB",
                                    YearInducted = 1994,
                                    YearsActive = "1977 - 1987",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Randy White",
                                    Position = "DT" + ", " + "DE" + ", " + "LB",
                                    YearInducted = 1994,
                                    YearsActive = "1975 - 1988",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Bob Hayes",
                                    Position = "WR",
                                    YearInducted = 2001,
                                    YearsActive = "1965 - 1974",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Tex Schramm",
                                    Position = "General Manager",
                                    YearInducted = 2003,
                                    YearsActive = "1960 - 1989",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Cliff Harris",
                                    Position = "S",
                                    YearInducted = 2004,
                                    YearsActive = "1970 - 1979",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Rayfield Wright",
                                    Position = "OT",
                                    YearInducted = 2004,
                                    YearsActive = "1967 - 1979",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Troy Aikman",
                                    Position = "QB",
                                    YearInducted = 2005,
                                    YearsActive = "1989 - 2000",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Michael Irvin",
                                    Position = "WR",
                                    YearInducted = 2005,
                                    YearsActive = "1988 - 1999",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Emmitt Smith",
                                    Position = "RB",
                                    YearInducted = 2005,
                                    YearsActive = "1990 - 2002",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Drew Pearson",
                                    Position = "WR",
                                    YearInducted = 2011,
                                    YearsActive = "1973 - 1983",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Charles Haley",
                                    Position = "DE",
                                    YearInducted = 2011,
                                    YearsActive = "1992 - 1996",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Larry Allen",
                                    Position = "OG" + ", " + "OT",
                                    YearInducted = 2011,
                                    YearsActive = "1994 - 2005",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Darren Woodson",
                                    Position = "S",
                                    YearInducted = 2015,
                                    YearsActive = "1992 - 2004",
                                    PlayerTeam = "Dallas Cowboys"
                                },
                                new Players
                                {
                                    Name = "Gil Brandt",
                                    Position = "VP Player of Personnel",
                                    YearInducted = 2018,
                                    YearsActive = "1960 - 1988",
                                    PlayerTeam = "Dallas Cowboys"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Giants Ring of Honor was unveiled in 2010 during a game against the Chicago Bears. Their inaugural induction class featured 30 players, coaches, and executives who made a great impact on the franchise.",
                        Team = new Teams
                        {
                            TeamName = "New York Giants",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/NYG.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Jessie Armstead",
                                    Position = "LB",
                                    YearInducted = 2010,
                                    YearsActive = "1993 - 2001",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Tiki Barber",
                                    Position = "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1997 - 2006",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Al Blozis",
                                    Position = "OT",
                                    Notes = "Died in World War II",
                                    YearInducted = 2010,
                                    YearsActive = "1942 - 1944",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Rosey Brown",
                                    Position = "OT",
                                    YearInducted = 2010,
                                    YearsActive = "1953 - 1965",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Harry Carson",
                                    Position = "LB",
                                    YearInducted = 2010,
                                    YearsActive = "1976 - 1988",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Charlie Conerly",
                                    Position = "QB",
                                    YearInducted = 2010,
                                    YearsActive = "1948 - 1961",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Frank Gifford",
                                    Position = "RB" + ", " + "WR",
                                    YearInducted = 2010,
                                    YearsActive = "1952 - 1964",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Pete Gogolak",
                                    Position = "K",
                                    YearInducted = 2010,
                                    YearsActive = "1966 - 1974",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Mel Hein",
                                    Position = "C" + ", " + "LB",
                                    YearInducted = 2010,
                                    YearsActive = "1931 - 1945",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Jim Lee Howell",
                                    Position = "TE" + ", " + "DE" + ", " + "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1937 - 1942" + ", " + "1946 - 1947" + ", " + "1954 - 1960",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Sam Huff",
                                    Position = "LB",
                                    YearInducted = 2010,
                                    YearsActive = "1956 - 1963",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Tuffy Leemans",
                                    Position = "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1936 - 1943",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Dick Lynch",
                                    Position = "DB",
                                    YearInducted = 2010,
                                    YearsActive = "1958 - 1966",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Jack Mara",
                                    Position = "Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1925 - 1965",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Tim Mara",
                                    Position = "Founding Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1925 - 1959",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Wellington Mara",
                                    Position = "Ball Boy" + ", " + "Executive" + ", " + "Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1925 - 2005",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "George Martin",
                                    Position = "DE",
                                    YearInducted = 2010,
                                    YearsActive = "1975 - 1988",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Joe Morrison",
                                    Position = "WR" + ", " + "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1959 - 1972",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Steve Owen",
                                    Position = "OT" + ", " + "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1926 - 1953",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Bill Parcells",
                                    Position = "Linebacker Coach" + ", " + "Defensive Coordinator" + ", " + "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1979" + ", " + "1981 - 1990",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Andy Robustelli",
                                    Position = "DE",
                                    YearInducted = 2010,
                                    YearsActive = "1956 - 1964",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Phil Simms",
                                    Position = "QB",
                                    YearInducted = 2010,
                                    YearsActive = "1979 - 1993",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Michael Strahan",
                                    Position = "DE",
                                    YearInducted = 2010,
                                    YearsActive = "1993 - 2007",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Ken Strong",
                                    Position = "RB",
                                    YearInducted = 2010,
                                    YearsActive = "1933 - 1935" + ", " + "1939" + ", " + "1944 - 1947",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Lawrence Taylor",
                                    Position = "",
                                    YearInducted = 2010,
                                    YearsActive = "1981 - 1993",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Bob Tisch",
                                    Position = "Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1991 - 2005",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Y.A. Tittle",
                                    Position = "QB",
                                    YearInducted = 2010,
                                    YearsActive = "1961 - 1964",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Amani Tooner",
                                    Position = "WR",
                                    YearInducted = 2010,
                                    YearsActive = "1996 - 2008",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Emlen Tunnell",
                                    Position = "DB" + ", " + "Scout" + ", " + "Assistant Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1948 - 1958" + ", " + "1963 - 1973",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "George Young",
                                    Position = "Executive",
                                    YearInducted = 2010,
                                    YearsActive = "1979 - 1997",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Carl Banks",
                                    Position = "LB",
                                    YearInducted = 2011,
                                    YearsActive = "1984 - 1992",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Mark Bavaro",
                                    Position = "TE",
                                    YearInducted = 2011,
                                    YearsActive = "1985 - 1990",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Dave Jennings",
                                    Position = "P",
                                    YearInducted = 2011,
                                    YearsActive = "1974 - 1984",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Brad Van Pelt",
                                    Position = "LB",
                                    YearInducted = 2011,
                                    YearsActive = "1973 - 1983",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Alex Webster",
                                    Position = "FB" + ", " + "Head Coach",
                                    YearInducted = 2011,
                                    YearsActive = "1955 - 1964, 1969 - 1973",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "John Johnson",
                                    Position = "Atheltic Trainer",
                                    YearInducted = 2015,
                                    YearsActive = "1948 - 2008",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Jack Lummus",
                                    Position = "TE" + ", " + "DE",
                                    Notes = "Died in the Battle of Iwo Jima during World War II.",
                                    YearInducted = 2015,
                                    YearsActive = "1941",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Chris Snee",
                                    Position = "OG",
                                    YearInducted = 2015,
                                    YearsActive = "2004 - 2013",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Osi Umenyiora",
                                    Position = "DE",
                                    YearInducted = 2015,
                                    YearsActive = "2003 - 2012",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Ernie Acorsi",
                                    Position = "Executive",
                                    YearInducted = 2016,
                                    YearsActive = "1994 - 2007",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Tom Coughlin",
                                    Position = "WR Coach" + ", " + "Head Coach",
                                    YearInducted = 2016,
                                    YearsActive = "1988 - 1990, 2004 - 2015",
                                    PlayerTeam = "New York Giants"
                                },
                                new Players
                                {
                                    Name = "Justin Tuck",
                                    Position = "DE",
                                    YearInducted = 2016,
                                    YearsActive = "2005- 2013",
                                    PlayerTeam = "New York Giants"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Began in 1987 as the Eagles Honor Roll, the Eagles Hall of Fame honors players, executives, and coaches. Their inaugural induction class in 1987 was included with every player who was inducted into the Pro Football Hall of Fame as an Eagle. Players must be retired for three years to be considered to be included in the Eagles Hall of Fame.",
                        Team = new Teams
                        {
                            TeamName = "Philadelphia Eagles",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/PHI.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Chuck Bednarik",
                                    Position = "C" + ", " + "LB",
                                    YearInducted = 1987,
                                    YearsActive = "1949 - 1962",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Bert Bell",
                                    Position = "Founding Owner",
                                    YearInducted = 1987,
                                    YearsActive = "1933 - 1940",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Harold Carmichael",
                                    Position = "WR",
                                    YearInducted = 1987,
                                    YearsActive = "1971 - 1983",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Bill Hewitt",
                                    Position = "TE" + ", " + "DE",
                                    YearInducted = 1987,
                                    YearsActive = "1936 - 1939" + ", " + "1943",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Sonny Jurgensen",
                                    Position = "QB",
                                    YearInducted = 1987,
                                    YearsActive = "1957 - 1963",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Ollie Matson",
                                    Position = "RB",
                                    YearInducted = 1987,
                                    YearsActive = "1964 - 1966",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Wilbert Montgomery",
                                    Position = "RB",
                                    YearInducted = 1987,
                                    YearsActive = "1977 - 1984",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Earle 'Greasy' Neale",
                                    Position = "Head Coach",
                                    YearInducted = 1987,
                                    YearsActive = "1941 - 1950",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Pete Pihos",
                                    Position = "TE" + ", " + "DE",
                                    YearInducted = 1987,
                                    YearsActive = "1947 - 1955",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Jim Ringo",
                                    Position = "C",
                                    YearInducted = 1987,
                                    YearsActive = "1964 - 1977",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Norm Van Brocklin",
                                    Position = "QB",
                                    YearInducted = 1987,
                                    YearsActive = "1958 - 1960",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Steve Van Buren",
                                    Position = "RB",
                                    YearInducted = 1987,
                                    YearsActive = "1944 - 1951",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Alex Wojciechowicz",
                                    Position = "C" + ", " + "DT",
                                    YearInducted = 1987,
                                    YearsActive = "1946 - 1950",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Bill Bergey",
                                    Position = "LB",
                                    YearInducted = 1988,
                                    YearsActive = "1974 - 1980",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Tommy McDonald",
                                    Position = "WR",
                                    YearInducted = 1988,
                                    YearsActive = "1957 - 1963",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Tom Brookshier",
                                    Position = "CB",
                                    YearInducted = 1989,
                                    YearsActive = "1953 - 1961",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Pete Retzlaff",
                                    Position = "TE",
                                    YearInducted = 1989,
                                    YearsActive = "1956 - 1966",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Tommy Brown",
                                    Position = "RB",
                                    YearInducted = 1990,
                                    YearsActive = "1960 - 1967",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Jerry Sisemore",
                                    Position = "OT",
                                    YearInducted = 1991,
                                    YearsActive = "1973 - 1987",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Stan Walters",
                                    Position = "OT",
                                    YearInducted = 1991,
                                    YearsActive = "1975 - 1983",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Ron Jaworski",
                                    Position = "QB",
                                    YearInducted = 1992,
                                    YearsActive = "1977 - 1986",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Bill Bradley",
                                    Position = "S" + ", " + "P",
                                    YearInducted = 1993,
                                    YearsActive = "1969 - 1976",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Dick Vermeil",
                                    Position = "Head Coach",
                                    YearInducted = 1994,
                                    YearsActive = "1976 - 1982",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Jim Gallagher",
                                    Position = "Team Executive",
                                    YearInducted = 1995,
                                    YearsActive = "1949 - 1995",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Mike Quick",
                                    Position = "WR",
                                    YearInducted = 1995,
                                    YearsActive = "1982 - 1990",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Jerome Brown",
                                    Position = "DT",
                                    YearInducted = 1996,
                                    YearsActive = "1987 - 1991",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Otho Davis",
                                    Position = "Head Trainer",
                                    YearInducted = 1999,
                                    YearsActive = "1973 - 1995",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "1948 NFL Championship Team",
                                    YearInducted = 1999,
                                    YearsActive = "1948",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "1949 NFL Championship Team",
                                    YearInducted = 1999,
                                    YearsActive = "1949",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Bob Brown",
                                    Position = "OT",
                                    YearInducted = 2004,
                                    YearsActive = "1964 - 1968",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Reggie White",
                                    Position = "DE",
                                    YearInducted = 2005,
                                    YearsActive = "1985 - 1992",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Al Wistert",
                                    Position = "OT",
                                    YearInducted = 2009,
                                    YearsActive = "1943 - 1951",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Randall Cunningham",
                                    Position = "QB" + ", " + "P",
                                    Notes = "Punted 20 times in his career.",
                                    YearInducted = 2009,
                                    YearsActive = "1985 - 1974",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Eric Allen",
                                    Position = "CB",
                                    YearInducted = 2011,
                                    YearsActive = "1988 - 1994",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Jim Johnson",
                                    Position = "Defensive Coordinator",
                                    YearInducted = 2011,
                                    YearsActive = "1999 - 2008",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Leo Carlin",
                                    Position = "Ticket Managger",
                                    YearInducted = 2012,
                                    YearsActive = "1960 - 1982" + ", " + "1985 - 2015",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Brian Dawkins",
                                    Position = "S",
                                    YearInducted = 2012,
                                    YearsActive = "1996 - 2008",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Troy Vincent",
                                    Position = "CB",
                                    YearInducted = 2012,
                                    YearsActive = "1996 - 2003",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Donovan McNabb",
                                    Position = "QB",
                                    YearInducted = 2013,
                                    YearsActive = "1999 - 2009",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Brian Westbrook",
                                    Position = "RB",
                                    YearInducted = 2015,
                                    YearsActive = "2002 - 2009",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Maxie Baughan",
                                    Position = "LB",
                                    YearInducted = 2015,
                                    YearsActive = "1960 - 1965",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Jeremiah Trotter",
                                    Position = "LB",
                                    YearInducted = 2016,
                                    YearsActive = "1998 - 2001" + ", " + "2004 - 2006" + ", " + "2009",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Merrill Reese",
                                    Position = "Radio Play by Play",
                                    YearInducted = 2016,
                                    YearsActive = "1977 - Present",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "David Akers",
                                    Position = "K",
                                    YearInducted = 2017,
                                    YearsActive = "1999 - 2010",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Seth Joyner",
                                    Position = "LB",
                                    YearInducted = 2018,
                                    YearsActive = "1986 - 1993",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Clyde Simmons",
                                    Position = "DE",
                                    YearInducted = 2018,
                                    YearsActive = "1986 - 1993",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                                new Players
                                {
                                    Name = "Bobby Walston",
                                    Position = "WR" + ", " + "TE" + ", " + " K",
                                    YearInducted = 2019,
                                    YearsActive = "1951 - 1962",
                                    PlayerTeam = "Philadelphia Eagles"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Beginning with the creation of FedEx Field, the Washington Football Team begun having a Ring of Fame for their team history to honor players, executives and coaches who made a large impact on the team's history.",
                        Team = new Teams
                        {
                            TeamName = "Washington Football Team",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/WAS.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "George Allen",
                                    Position = "Head Coach",
                                    YearsActive = "1971 - 1977",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Cliff Battles",
                                    Position = "RB",
                                    YearsActive = "1932 - 1937",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Sammy Baugh",
                                    Position = "QB",
                                    YearsActive = "1937 - 1952",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Bobby Beathard",
                                    Position = "General Manager",
                                    YearsActive = "1978 - 1988",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Jeff Bostic",
                                    Position = "C",
                                    YearsActive = "1980 - 1993",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Gene Brito",
                                    Position = "DE",
                                    YearsActive = "1951 - 1953" + ", " + "1955 - 1958",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Larry Brown",
                                    Position = "RB",
                                    YearsActive = "1969 - 1976",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Dave Butz",
                                    Position = "DT",
                                    YearsActive = "1975 - 1988",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Gary Clark",
                                    Position = "WR",
                                    YearsActive = "1985 - 1992",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Monte Coleman",
                                    Position = "LB",
                                    YearsActive = "1979 - 1994",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Jack Kent Cooke",
                                    Position = "Owner",
                                    YearsActive = "1961 - 1997",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Wayne Curry",
                                    Position = "Prince George's County Executive",
                                    Notes = "Was pivotal in helping move Washington to Landover, Maryland.",
                                    YearsActive = "1994 - 2002",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Bill Dudley",
                                    Position = "RB",
                                    YearsActive = "1950 - 1951" + ", " + "1953",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Pat Fischer",
                                    Position = "CB",
                                    YearsActive = "1968 - 1977",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "London Fletcher",
                                    Position = "LB",
                                    YearsActive = "2007 - 2013",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Joe Gibbs",
                                    Position = "Head Coach",
                                    YearsActive = "1981 - 1992" + ", " + "2004 - 2007",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Darrell Green",
                                    Position = "CB",
                                    YearsActive = "1983 - 2002",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Russ Grimm",
                                    Position = "OG",
                                    YearsActive = "1981 - 1991",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Chris Hanburger",
                                    Position = "LB",
                                    YearsActive = "1965 - 1978",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Ken Harvey",
                                    Position = "LB",
                                    YearsActive = "1994 - 1998",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Len Hauss",
                                    Position = "C",
                                    YearsActive = "1964 - 1977",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Phil Hochberg",
                                    Position = "PA Announcer",
                                    YearsActive = "1963 - 2000",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Ken Houston",
                                    Position = "S",
                                    YearsActive = "1973 - 1980",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Sam Huff",
                                    Position = "LB",
                                    YearsActive = "1964 - 1967" + ", " + "1969",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Joe Jacoby",
                                    Position = "OT" + ", " + "OG",
                                    YearsActive = "1961 - 1974",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Dick James",
                                    Position = "RB",
                                    YearsActive = "1956 - 1963",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Sonny Jurgensen",
                                    Position = "QB",
                                    YearsActive = "1964 - 1974",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Charlie Justice",
                                    Position = "RB",
                                    YearsActive = "1950" + ", " + "1952 - 1954",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Billy Kilmer",
                                    Position = "QB",
                                    YearsActive = "1971 - 1978",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Eddie LeBaron",
                                    Position = "QB",
                                    YearsActive = "1952 - 1953" + ", " + "1955 - 1959",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Vince Lombardi",
                                    Position = "Head Coach",
                                    YearsActive = "1969",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Dexter Manley",
                                    Position = "DE",
                                    YearsActive = "1981 - 1989",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Charles Mann",
                                    Position = "DE",
                                    YearsActive = "1983 - 1993",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Wayne Millner",
                                    Position = "TE" + ", " + "DE",
                                    YearsActive = "1936 - 1941" + ", " + "1945",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Bobby Mitchell",
                                    Position = "WR",
                                    YearsActive = "1962 - 1968",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Brian Mitchell",
                                    Position = "RB" + ", " + "Return Specialist",
                                    YearsActive = "1990 - 1999",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Art Monk",
                                    Position = "WR",
                                    YearsActive = "1980 - 1993",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Mark Moseley",
                                    Position = "K",
                                    YearsActive = "1974 - 1986",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Brig Owens",
                                    Position = "DB",
                                    YearsActive = "1966 - 1977",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Richie Petitbon",
                                    Position = "S" + ", " + "Defensive Coordinator" + ", " + "Head Coach",
                                    YearsActive = "1971 - 1972" + ", " + "1981 - 1992" + ", " + "1993",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Vince Promuto",
                                    Position = "OG",
                                    YearsActive = "1960 - 1970",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "John Riggins",
                                    Position = "RB",
                                    YearsActive = "1976 - 1979" + ", " + "1981 - 1985",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Mark Rypien",
                                    Position = "QB",
                                    YearsActive = "1986 - 1993",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Chris Samuels",
                                    Position = "OT",
                                    YearsActive = "2000 - 2009",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Jerry Smith",
                                    Position = "TE",
                                    YearsActive = "1965 - 1977",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Charley Taylor",
                                    Position = "WR",
                                    YearsActive = "1964 - 1977",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Sean Taylor",
                                    Position = "S",
                                    YearsActive = "2004 - 2007",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Joe Theismann",
                                    Position = "QB",
                                    YearsActive = "1974 - 1985",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Lamar 'Bubba' Tyler",
                                    Position = "Athletic Trainer",
                                    YearsActive = "1971 - 2002" + ", " + "2004 - 2008",
                                    PlayerTeam = "Washington Football Team"
                                },
                                new Players
                                {
                                    Name = "Doug Williams",
                                    Position = "QB",
                                    YearsActive = "1986 - 1989",
                                    PlayerTeam = "Washington Football Team"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "While they don't retire jersey numbers, the Atlanta Falcons want to honor their former players by including them in their franchise's Ring of Honor.",
                        Team = new Teams
                        {
                            TeamName = "Atlanta Falcons",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/ATL.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "William Andrews",
                                    Position = "RB",
                                    YearInducted = 2004,
                                    YearsActive = "1979 - 1983" + ", " + "1986",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Steve Bartkowski",
                                    Position = "QB",
                                    YearInducted = 2004,
                                    YearsActive = "1975 - 1985",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Tommy Nobis",
                                    Position = "LB",
                                    YearInducted = 2004,
                                    YearsActive = "1966 - 1976",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Jessie Tuggle",
                                    Position = "LB",
                                    YearInducted = 2004,
                                    YearsActive = "1987 - 2000",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Jeff Van Note",
                                    Position = "C",
                                    YearInducted = 2006,
                                    YearsActive = "1969 - 1986",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Claude Humphrey",
                                    Position = "DE",
                                    YearInducted = 2008,
                                    YearsActive = "1968 - 1978",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Mike Kenn",
                                    Position = "OT",
                                    YearInducted = 2008,
                                    YearsActive = "1978 - 1994",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Deion Sanders",
                                    Position = "CB",
                                    YearInducted = 2010,
                                    YearsActive = "1989 - 1993",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Gerald Riggs",
                                    Position = "RB",
                                    YearInducted = 2013,
                                    YearsActive = "1982 - 1988",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Warrick Dunn",
                                    Position = "RB",
                                    YearInducted = 2017,
                                    YearsActive = "2002 - 2007",
                                    PlayerTeam = "Atlanta Falcons"
                                },
                                new Players
                                {
                                    Name = "Roddy White",
                                    Position = "WR",
                                    YearInducted = 2019,
                                    YearsActive = "2005 - 2015",
                                    PlayerTeam = "Atlanta Falcons"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Hall of Honor was established in 1997 as a still young franchsie. They've inducted six people who define being a Carolina Panther.",
                        Team = new Teams
                        {
                            TeamName = "Carolina Panthers",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/CAR.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Mike McCormack",
                                    Position = "President" + ", " + "General Manager",
                                    YearInducted = 1997,
                                    YearsActive = "1993 - 1997",
                                    PlayerTeam = "Carolina Panthers"
                                },
                                new Players
                                {
                                    Name = "Sam Mills",
                                    Position = "LB" + ", " + "Coach",
                                    YearInducted = 1998,
                                    YearsActive = "1995 - 2004",
                                    PlayerTeam = "Carolina Panthers"
                                },
                                new Players
                                {
                                    Name = "Steve Smith Sr.",
                                    Position = "WR",
                                    YearInducted = 2019,
                                    YearsActive = "2001 - 2013",
                                    PlayerTeam = "Carolina Panthers"
                                },
                                new Players
                                {
                                    Name = "Jake Delhomme",
                                    Position = "QB",
                                    YearInducted = 2019,
                                    YearsActive = "2003 - 2009",
                                    PlayerTeam = "Carolina Panthers"
                                },
                                new Players
                                {
                                    Name = "Wesley Walls",
                                    Position = "TE",
                                    YearInducted = 2019,
                                    YearsActive = "1996 - 2002",
                                    PlayerTeam = "Carolina Panthers"
                                },
                                new Players
                                {
                                    Name = "Jordan Gross",
                                    Position = "OT",
                                    YearInducted = 2019,
                                    YearsActive = "2003 - 2013",
                                    PlayerTeam = "Carolina Panthers"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "Beginning in 2013, the Saints began honoring their history with the creation of the Ring of Honor in Mercedes-Benz Superdome. They inducted the first three nominees during halftime against the Cowboys in 2013.",
                        Team = new Teams
                        {
                            TeamName = "New Orleans Saints",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/NO.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Archie Manning",
                                    Position = "QB",
                                    YearInducted = 2013,
                                    YearsActive = "1971 - 1982",
                                    PlayerTeam = "New Orleans Saints"
                                },
                                new Players
                                {
                                    Name = "Rickey Jackson",
                                    Position = "LB",
                                    YearInducted = 2013,
                                    YearsActive = "1981 - 1993",
                                    PlayerTeam = "New Orleans Saints"
                                },
                                new Players
                                {
                                    Name = "Willie Roaf",
                                    Position = "OT",
                                    YearInducted = 2013,
                                    YearsActive = "1993 - 2001",
                                    PlayerTeam = "New Orleans Saints"
                                },
                                new Players
                                {
                                    Name = "Morten Andersen",
                                    Position = "K",
                                    YearInducted = 2015,
                                    YearsActive = "1982 - 1994",
                                    PlayerTeam = "New Orleans Saints"
                                },
                                new Players
                                {
                                    Name = "Tom Benson",
                                    Position = "Owner",
                                    YearInducted = 2019,
                                    YearsActive = "1985 - 2018",
                                    PlayerTeam = "New Orleans Saints"
                                },
                                new Players
                                {
                                    Name = "Will Smith",
                                    Position = "DE",
                                    YearInducted = 2019,
                                    YearsActive = "2004 - 2013",
                                    PlayerTeam = "New Orleans Saints"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "In November 2009, the team unveiled a Ring of Honor at their current stadium, Raymond James Stadium.",
                        Team = new Teams
                        {
                            TeamName = "Tampa Bay Buccaneers",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/TB.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Lee Roy Selmon",
                                    Position = "DE",
                                    YearInducted = 2009,
                                    YearsActive = "1976 - 1984",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "John McKay",
                                    Position = "Head Coach",
                                    YearInducted = 2010,
                                    YearsActive = "1976 - 1984",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Jimmie Giles",
                                    Position = "TE",
                                    YearInducted = 2011,
                                    YearsActive = "1978 - 1986",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Paul Gruber",
                                    Position = "OT",
                                    YearInducted = 2012,
                                    YearsActive = "1988 - 1999",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Warren Sapp",
                                    Position = "DT",
                                    YearInducted = 2013,
                                    YearsActive = "1995 - 2003",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Derrick Brooks",
                                    Position = "LB",
                                    YearInducted = 2014,
                                    YearsActive = "1995 - 2008",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Mike Alstott",
                                    Position = "FB",
                                    YearInducted = 2015,
                                    YearsActive = "1996 - 2007",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Doug Williams",
                                    Position = "QB",
                                    YearInducted = 2015,
                                    YearsActive = "1978 - 1982",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "John Lynch",
                                    Position = "S",
                                    YearInducted = 2016,
                                    YearsActive = "1993 - 2003",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Malcolm Glazer",
                                    Position = "Owner",
                                    YearInducted = 2017,
                                    YearsActive = "1995 - 2014",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Jon Gruden",
                                    Position = "Head Coach",
                                    YearInducted = 2017,
                                    YearsActive = "2002 - 2008",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players 
                                {
                                    Name = "Tony Dungy",
                                    Position = "Head Coach",
                                    YearInducted = 2018,
                                    YearsActive = "1996 - 2001",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Ronde Barber",
                                    Position = "CB",
                                    YearInducted = 2019,
                                    YearsActive = "1997 - 2012",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                },
                                new Players
                                {
                                    Name = "Monte Kiffin",
                                    Position = "Defensive Coordinator",
                                    YearInducted = 2020,
                                    YearsActive = "1996 - 2008",
                                    PlayerTeam = "Tampa Bay Buccaneers"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "To mark the opening of State Farm Stadium in 2006, the Cardinals began a Ring of Honor to showcase all eras of the franchise.",
                        Team = new Teams
                        {
                            TeamName = "Arizona Cardinals",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/ARI.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Charles Bidwill",
                                    Position = "Owner",
                                    YearInducted = 2006,
                                    YearsActive = "1933 - 1947",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Jimmy Conzelman",
                                    Position = "Head Coach",
                                    YearInducted = 2006,
                                    YearsActive = "1940 - 1942" + ", " + "1946 - 1948",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "John 'Paddy' Driscoll",
                                    Position = "QB" + ", " + "Head Coach",
                                    YearInducted = 2006,
                                    YearsActive = "1920 - 1925" + ", " + "1920 - 1922",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Marshall Goldberg",
                                    Position = "RB",
                                    YearInducted = 2006,
                                    YearsActive = "1939 - 1943" + ", " + "1946 - 1948",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Dick 'Night Train' Lane",
                                    Position = "CB",
                                    YearInducted = 2006,
                                    YearsActive = "1954 - 1959",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Ollie Matson",
                                    Position = "RB",
                                    YearInducted = 2006,
                                    YearsActive = "1952" + ", " + "1954 - 1958",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Ernie Nevers",
                                    Position = "FB" + ", " + "Head Coach",
                                    YearInducted = 2006,
                                    YearsActive = "1929 - 1931" + ", " + "1930 - 1931" + ", " + "1939",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Charley Trippi",
                                    Position = "RB" + ", " + "QB",
                                    YearInducted = 2006,
                                    YearsActive = "1947 - 1955",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Larry Wilson",
                                    Position = "S",
                                    YearInducted = 2006,
                                    YearsActive = "1960 - 1972",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Dan Dierdorf",
                                    Position = "OT",
                                    YearInducted = 2006,
                                    YearsActive = "1971 - 1983",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Pat Tillman",
                                    Position = "S",
                                    YearInducted = 2006,
                                    YearsActive = "1998 - 2001",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Roger Wehrli",
                                    Position = "CB",
                                    YearInducted = 2007,
                                    YearsActive = "1969 - 1982",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Aeneas Williams",
                                    Position = "CB",
                                    YearInducted = 2008,
                                    PlayerTeam = "Arizona Cardinals",
                                    YearsActive = "1991 - 2000"
                                },
                                new Players
                                {
                                    Name = "Kurt Warner",
                                    Position = "QB",
                                    YearInducted = 2014,
                                    YearsActive = "2005 - 2009",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Adrian Wilson",
                                    Position = "S",
                                    YearInducted = 2015,
                                    YearsActive = "2001 - 2012",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players 
                                {
                                    Name = "Roy Green",
                                    Position = "WR",
                                    YearInducted = 2016,
                                    YearsActive = "1979 - 1990",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Jim Hart",
                                    Position = "QB",
                                    YearInducted = 2017,
                                    YearsActive = "1966 - 1983",
                                    PlayerTeam = "Arizona Cardinals"
                                },
                                new Players
                                {
                                    Name = "Carson Palmer",
                                    Position = "QB",
                                    YearInducted = 2019,
                                    YearsActive = "2013 - 2017",
                                    PlayerTeam = "Arizona Cardinals"
                                }
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "While St. Louis did have a Ring of Fame for football in its city, the Los Angeles Rams do not specifically have a Ring of Honor or Team Hall of Fame.",
                        Team = new Teams
                        {
                            TeamName = "Los Angeles Rams",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/LA.svg",
                            Players = new List<Players>
                            {
                                null
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "After fan desires, the 49ers created a Ring of Honor in Levi Stadium in 2017 honoring their franchise.",
                        Team = new Teams
                        {
                            TeamName = "San Francisco 49ers",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/SF.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Steve Young",
                                    Position = "QB",
                                    YearInducted = 2009,
                                    YearsActive = "1987 - 1999",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "John Brodie",
                                    Position = "QB",
                                    YearInducted = 2009,
                                    YearsActive = "1957 - 1973",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Y.A. Tittle",
                                    Position = "QB",
                                    YearInducted = 2009,
                                    YearsActive = "1951 - 1960",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Joe Montana",
                                    Position = "QB",
                                    YearInducted = 2009,
                                    YearsActive = "1979 - 1992",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Joe Perry",
                                    Position = "RB",
                                    YearInducted = 2009,
                                    YearsActive = "1948 - 1960" + ", " + "1963",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "John Henry Johnson",
                                    Position = "RB",
                                    YearInducted = 2009,
                                    YearsActive = "1954 - 1956",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Jimmy Johnson",
                                    Position = "CB" + ", " + "WR",
                                    YearInducted = 2009,
                                    YearsActive = "1961 - 1976",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Hugh McElhenny",
                                    Position = "RB",
                                    YearInducted = 2009,
                                    YearsActive = "1952 - 1960",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Ronnie Lott",
                                    Position = "S" + ", " + "CB",
                                    YearInducted = 2009,
                                    YearsActive = "1981 - 1990",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Dave Wilcox",
                                    Position = "LB",
                                    YearInducted = 2009,
                                    YearsActive = "1964 - 1974",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Charlie Krueger",
                                    Position = "DL",
                                    YearInducted = 2009,
                                    YearsActive = "1959 - 1973",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Leo Nomellini",
                                    Position = "DT" + ", " + "OT",
                                    YearInducted = 2009,
                                    YearsActive = "1950 - 1963",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Fred Dean",
                                    Position = "DE",
                                    YearInducted = 2009,
                                    YearsActive = "1981 - 1985",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Bob St. Clair",
                                    Position = "OT",
                                    YearInducted = 2009,
                                    YearsActive = "1953 - 1963",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Dwight Clark",
                                    Position = "WR",
                                    YearInducted = 2009,
                                    YearsActive = "1979 - 1987",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Edward BeBartolo Jr.",
                                    Position = "Owner",
                                    YearInducted = 2009,
                                    YearsActive = "1978 - 2000",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Bill Walsh",
                                    Position = "Head Coach",
                                    YearInducted = 2009,
                                    YearsActive = "1979 - 1988",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Jerry Rice",
                                    Position = "WR",
                                    YearInducted = 2010,
                                    YearsActive = "1985 - 2000",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Tony Morabito",
                                    Position = "Founding Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1957",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Vic Morabito",
                                    Position = "Owner",
                                    YearInducted = 2010,
                                    YearsActive = "1946 - 1964",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "RC Owens",
                                    Position = "WR",
                                    YearInducted = 2011,
                                    YearsActive = "1957 - 1961",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Roger Craig",
                                    Position = "RB",
                                    YearInducted = 2011,
                                    YearsActive = "1983 - 1990",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Gordon Soltau",
                                    Position = "WR",
                                    YearInducted = 2012,
                                    YearsActive = "1949 - 1958",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "John McVay",
                                    Position = "Executive",
                                    YearInducted = 2013,
                                    YearsActive = "1980 - 1995" + ", " + "1998 - 1999",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "George Seifert",
                                    Position = "DB Coach" + ", " + "Defensive Coordinator" + ", " + "Head Coach",
                                    YearInducted = 2014,
                                    YearsActive = "1980 - 1982" + ", " + "1983 - 1988" + ", " + "1989 - 1996",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Charles Haley",
                                    Position = "DE" + ", " + "LB",
                                    YearInducted = 2015,
                                    YearsActive = "1986 - 1991" + ", " + "1998 - 1999",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Tom Rathman",
                                    Position = "RB" + ", " + "RB Coach",
                                    YearInducted = 2017,
                                    YearsActive = "1986 - 1991" + ", " + "1997 - 2002" + ", " + "2009 - 2016",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Terrell Owens",
                                    Position = "WR",
                                    YearInducted = 2018,
                                    YearsActive = "1996 - 2003",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                                new Players
                                {
                                    Name = "Bryant Young",
                                    Position = "DT",
                                    YearInducted = 2020,
                                    YearsActive = "1994 - 2007",
                                    PlayerTeam = "San Francisco 49ers"
                                },
                            }
                        }
                    },
                    new RingHonor
                    {
                        History = "The Seattle Seahawks Ring of Honor was established in 1989 and has inducted 12 people thus far who exemplify being a Seattle Seahawk.",
                        Team = new Teams
                        {
                            TeamName = "Seattle Seahawks",
                            LogoURL = "https://static.nfl.com/static/content/public/static/wildcat/assets/img/logos/teams/SEA.svg",
                            Players = new List<Players>
                            {
                                new Players
                                {
                                    Name = "Steve Largent",
                                    Position = "WR",
                                    YearInducted = 1989,
                                    YearsActive = "1976 - 1989",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Jim Zorn",
                                    Position = "QB",
                                    YearInducted = 1991,
                                    YearsActive = "1976 - 1984",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Dave Brown",
                                    Position = "CB",
                                    YearInducted = 1992,
                                    YearsActive = "1976 - 1986",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Pete Gross",
                                    Position = "Radio Announcer",
                                    YearInducted = 1992,
                                    YearsActive = "1976 - 1992",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Curt Warner",
                                    Position = "RB",
                                    YearInducted = 1994,
                                    YearsActive = "1983 - 1989",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Jacob Green",
                                    Position = "DE",
                                    YearInducted = 1995,
                                    YearsActive = "1980 - 1991",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Kenny Easley",
                                    Position = "S",
                                    YearInducted = 2002,
                                    YearsActive = "1981 - 1987",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Dave Krieg",
                                    Position = "QB",
                                    YearInducted = 2004,
                                    YearsActive = "1980 - 1991",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Chuck Knox",
                                    Position = "Head Coach",
                                    YearInducted = 2005,
                                    YearsActive = "1983 - 1991",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Cortez Kennedy",
                                    Position = "DT",
                                    YearInducted = 2006,
                                    YearsActive = "1990 - 2000",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Walter Jones",
                                    Position = "OT",
                                    YearInducted = 2014,
                                    YearsActive = "1997 - 2009",
                                    PlayerTeam = "Seattle Seahawks"
                                },
                                new Players
                                {
                                    Name = "Paul Allen",
                                    Position = "Owner",
                                    YearInducted = 2019,
                                    YearsActive = "1996 - 2018",
                                    PlayerTeam = "Seattle Seahawks"
                                }
                            }
                        }
                    }
                };
            await context.RingHonor.AddRangeAsync(ringHonor);
            await context.SaveChangesAsync();
            }
        }
    }
}