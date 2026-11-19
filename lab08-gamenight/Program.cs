


// ==== Setup ====
const string PLAYERS_FILE = "players.txt";
const string POINT_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

//Look for the data files next to Program.cs
string projectFolder = Path.GetFullPath(
    Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] names = File.ReadAllLines(PLAYERS_FILE);
string[] point = File.ReadAllLines(POINT_FILE);

// ==== Part 1: The Standings ====
Console.Write("PLAYER".PadRight(11));
Console.Write("POINTS\n");




for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i].PadRight(11) + point[i]);
}
Console.WriteLine($"Leader: {LeaderIndex(0)}");
Console.WriteLine($"Season total: ");















// ==== METHODS ====
static int LeaderIndex(int pts)
{
    int topPoints = 0;
    
    foreach(int p in Convert.ToString(File.ReadAllLines(POINT_FILE)))
    {
        if (p > topPoints)
        {
            topPoints = p;
        }
    }
    return topPoints;
}



/*
static int TotalPoints(string[] points);
{
    foreach(string point in points[])
    {

    }
}

leader location method?

static string HistoryEntry(int night, string winner, int points);
*/