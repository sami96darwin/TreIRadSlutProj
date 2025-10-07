using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj
{
    public class Board
    {
        public int Size { get; } = 3;
        public PlayerMark[,] Cells { get; private set; }

        public Board()
        {
            Cells = new PlayerMark[Size, Size];
            Reset();
        }

        public void Reset()
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Cells[x, y] = PlayerMark.Empty;
                }
            }
        }

        public bool IsCellEmpty(int x, int y)
        {
            return Cells[x, y] == PlayerMark.Empty;
        }

        public void SetCell(int x, int y, PlayerMark mark)
        {
            if (Cells[x, y] == PlayerMark.Empty)
                Cells[x, y] = mark;
        }

        public GameResult CheckWinner()
        {
            // dem horistonella raderna
            for (int y = 0; y < Size; y++)
            {
                if (Cells[0, y] != PlayerMark.Empty &&
                    Cells[0, y] == Cells[1, y] &&
                    Cells[1, y] == Cells[2, y])
                {
                    return Cells[0, y] == PlayerMark.X ? GameResult.X_Wins : GameResult.O_Wins;
                }
            }

            // hanterar vertikala kolumner
            for (int x = 0; x < Size; x++)
            {
                if (Cells[x, 0] != PlayerMark.Empty &&
                    Cells[x, 0] == Cells[x, 1] &&
                    Cells[x, 1] == Cells[x, 2])
                {
                    return Cells[x, 0] == PlayerMark.X ? GameResult.X_Wins : GameResult.O_Wins;
                }
            }

            // diagonala kolumner
            if (Cells[0, 0] != PlayerMark.Empty &&
                Cells[0, 0] == Cells[1, 1] &&
                Cells[1, 1] == Cells[2, 2])
            {
                return Cells[0, 0] == PlayerMark.X ? GameResult.X_Wins : GameResult.O_Wins;
            }

            if (Cells[2, 0] != PlayerMark.Empty &&
                Cells[2, 0] == Cells[1, 1] &&
                Cells[1, 1] == Cells[0, 2])
            {
                return Cells[2, 0] == PlayerMark.X ? GameResult.X_Wins : GameResult.O_Wins;
            }

            // kontrollerar om de blivit oavgjort
            bool full = true;
            for (int x = 0; x < Size; x++)
                for (int y = 0; y < Size; y++)
                    if (Cells[x, y] == PlayerMark.Empty)
                        full = false;

            if (full) return GameResult.Draw;

            return GameResult.InProgress;
        }
    }
}
