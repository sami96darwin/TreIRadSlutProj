using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj
{
    public class Stats
    {
        public int XWins { get; set; } = 0;
        public int OWins { get; set; } = 0;
        public int Draws { get; set; } = 0;
    }

    public class Points
    {
        private string folderPath;
        private string filePath;
        public Stats CurrentStats { get; private set; }

        public Points()
        {
            folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TicTacToeE");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            filePath = Path.Combine(folderPath, "stats.json");

            CurrentStats = Load();
        }

        public Stats Load()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<Stats>(json) ?? new Stats();
                }
                catch { return new Stats(); }
            }
            return new Stats();
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(CurrentStats);
            File.WriteAllText(filePath, json);
        }

        public void AddResult(GameResult result)
        {
            if (result == GameResult.X_Wins) CurrentStats.XWins++;
            else if (result == GameResult.O_Wins) CurrentStats.OWins++;
            else if (result == GameResult.Draw) CurrentStats.Draws++;

            Save();
        }
    }
}
