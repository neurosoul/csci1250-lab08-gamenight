const string PLAYERS_FILE = "players.txt";
const string POINT_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

string[] names = File.ReadAllLines(PLAYERS_FILE);
string[] point = File.ReadAllLines(POINT_FILE);

//Look for the data files next to Program.cs
string projectFolder = Path.GetFullPath(
    Path.Combine(AppContext.BaseDirectory, "..","..",".."));
Directory.SetCurrentDirectory(projectFolder);


//Part 1: The Standings
Console.Write("PLAYER".PadRight(11));
Console.Write("POINTS\n");

string[] playerOutput = { names.ToString() }; 
string[] pointOutput = { point.ToString() };

File.WriteAllLines(PLAYERS_FILE, playerOutput);












/*
static int LeaderIndex(string[] points)
{
    int playerPoint = 0;
    int topPoints = 0;

    for (int i = 0; i < point.Length; i++)
    {
        if (playerPoint > topPoints)
        {
            topPoints = playerPoint;
        }
    }
    return 
}




static int TotalPoints(string[] points);
{
    foreach(string point in points[])
    {

    }
}

leader location method?

static string HistoryEntry(int night, string winner, int points);
*/