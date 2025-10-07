using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj.Players
{
    public abstract class Player
    {
        public string Name { get; set; }
        public PlayerMark Mark { get; set; }

        protected Player(string name, PlayerMark mark)
        {
            Name = name;
            Mark = mark;
        }

        // denna abstrakta metod är till för att subklasser ska implementerar för att få nästa drag.
        public abstract Tuple<int, int> GetMove(Board board);
    }
}
