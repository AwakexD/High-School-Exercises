namespace TeamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Team> teams = new List<Team>();

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "Stop")
                    {
                        break;
                    }

                    string[] teamInfo = input.Split();
                    teams.Add(new Team(teamInfo[0], teamInfo[1]));

                    string[] teamPlayers = Console.ReadLine().Split();
                    Dictionary<string, decimal> players = teamPlayers
                                                        .Where((value, index) => index % 2 == 0 && index + 1 < teamPlayers.Length)
                                                        .ToDictionary(x => x, x => decimal.Parse(teamPlayers[Array.IndexOf(teamPlayers, x) + 1]));

                    foreach (KeyValuePair<string, decimal> p in players)
                    {
                        teams.Last().AddPlayer(new Player(p.Key, p.Value));
                    }


                }

                foreach (Team t in teams)
                {
                    Console.WriteLine(t);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}