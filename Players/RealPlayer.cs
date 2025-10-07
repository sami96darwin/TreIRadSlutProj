using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj.Players
{
    public class RealPlayer : Player 
    {
        public RealPlayer(string name, PlayerMark mark) : base(name, mark) { }

        public override Tuple<int, int> GetMove(Board board)
        {
            return new Tuple<int, int>(-1, -1);
        }
    }
}
