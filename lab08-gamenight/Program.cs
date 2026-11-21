


// ==== Setup ====
using System.Drawing;

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

//Look for the data files next to Program.cs
string projectFolder = Path.GetFullPath(
    Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] names = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);


// ==== Part 1: The Standings ====
Console.Write("PLAYER".PadRight(11));
Console.Write("POINTS\n");

int indexResult = LeaderIndex(points);


for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i].PadRight(11) + points[i]);
}
Console.WriteLine($"Leader: {names[indexResult]} with {points[indexResult]}");
Console.WriteLine($"Season total: {TotalPoints(points)}");


// ==== Part 2: Game Night ====







// ==== METHODS ====
static int LeaderIndex(string[] points)
{
    int bestPoints = 0;
    int bestPosition = 0;

    for (int i = 0; i < points.Length; i++)
    {
        if (Convert.ToInt32(points[i]) > bestPoints)
        {
            bestPoints = Convert.ToInt32(points[i]);
            bestPosition = i;
        }

    }
    return bestPosition;

}

static int TotalPoints(string[] points)
{
    int pointSum = 0;

    foreach(string p in points)
    {
        pointSum += Convert.ToInt32(p);    
    }
    return pointSum;
}

//leader location method?

//static string HistoryEntry(int night, string winner, int points);