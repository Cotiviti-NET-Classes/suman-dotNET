
using System;
using System.Linq;

namespace Assignments;

class RealTimeExample
{

    public static void Main(string[] args)
    {

        // Read the file as one string.
        string[] data = File.ReadAllLines("D:\\Assignment5-data.csv");

        List<Player> players = new();

        //for (int i = 1; i < data.Length; i++)
        foreach (var item in data)
        {

            var c = item.Split(',');
            players.Add(new Player
            {
                Id = c[0],
                Name = c[1],
                Sex = c[2],
                Age = c[3],
                Height = c[4],
                Weight = c[5],
                Team = c[6],
                NOC = c[7],
                Games = c[8],
                Year = c[9],
                Season = c[10],
                City = c[11],
                Sport = c[12],
                Event = c[13],
                Medal = c[14],
            });
        }

        // 1.List all the players participated from Nepal.
        var nepaliPlayers = players.Where(x => x.Team.ToUpper() == "NEPAL").Select(x => x.Name).Distinct();
        foreach (var name in nepaliPlayers)
            Console.WriteLine($"Players from Nepal are :- {name}");

        // 2. List all chinese players who have won the GOLD.
        var playerWinningGold = players.Where(x => x.Medal.ToUpper() == "GOLD" && x.NOC.ToUpper() == "CHN").Select(x => x.Name).Distinct();
        foreach (var name in playerWinningGold)
        {
            Console.WriteLine($"Chinese player winning Gold :- {name}");
        }

        // List all players from USA and group them by sport they were in. Also order the result by sport
        var usPlayer = players.Where(x => x.NOC.ToUpper() == "USA").OrderBy(x => x.Sport);
        foreach (var name in usPlayer)
        {
            Console.WriteLine($"Players from USA :- {name.Name} - {name.Sport}");
        }

        // List all the countries with their medal tally so far. Also, order the list by number of golds won.
        //var countries = players.
        //foreach (var country in countries)
        //{
        //    Console.WriteLine($"All Countries :- {country.Name}");
        //}
    }
}

class Player
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Sex { get; set; }
    public string? Age { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }
    public string? Team { get; set; }
    public string? NOC { get; set; }
    public string? Games { get; set; }
    public string? Year { get; set; }
    public string? Season { get; set; }
    public string? City { get; set; }
    public string? Sport { get; set; }
    public string? Event { get; set; }
    public string? Medal { get; set; }
}