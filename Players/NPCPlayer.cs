using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj.Players
{
    public class NPCPlayer : Player
    {
        public NPCPlayer(string name, PlayerMark mark) : base(name, mark) { }

        public override Tuple<int, int> GetMove(Board board) // enkel npc spelare, väljer första lediga cellen
        {
            for (int x = 0; x < board.Size; x++)
                for (int y = 0; y < board.Size; y++)
                    if (board.IsCellEmpty(x, y)) 
                        return new Tuple<int, int>(x, y); 

            return new Tuple<int, int>(-1, -1); // EXTENSION
        }
    }
}
