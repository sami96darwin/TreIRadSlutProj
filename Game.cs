using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreIRadSlutProj.Players;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj
{
    public class Game
    {
        public Board Board { get; private set; }
        public PlayerMark CurrentTurn { get; private set; }
        public GameResult CurrentResult { get; private set; }

        // lägger till players
        public Player PlayerX { get; private set; }
        public Player PlayerO { get; private set; }

        public Game()
        {
            Board = new Board();
            CurrentTurn = PlayerMark.X;
            CurrentResult = GameResult.InProgress;

            // default är två riktiga players
            PlayerX = new RealPlayer("Player X", PlayerMark.X);
            PlayerO = new RealPlayer("Player O", PlayerMark.O);
        }

        public void SetPlayers(Player pX, Player pO)
        {
            PlayerX = pX;
            PlayerO = pO;
        }

        
        public void StartNewGame()
        {
            Board.Reset();
            CurrentTurn = PlayerMark.X;
            CurrentResult = GameResult.InProgress;
        }

        public bool MakeMove(int x, int y)
        {
            if (CurrentResult != GameResult.InProgress) return false;
            if (!Board.IsCellEmpty(x, y)) return false;

            Board.SetCell(x, y, CurrentTurn);
            CurrentResult = Board.CheckWinner();

            if (CurrentResult == GameResult.InProgress)
                CurrentTurn = (CurrentTurn == PlayerMark.X) ? PlayerMark.O : PlayerMark.X;

            return true;
        }

        // kollar om den nuvarande spelaren är en NPC och returnerar dess drag
        public Tuple<int, int> GetAIMoveIfAny()
        {
            Player current = (CurrentTurn == PlayerMark.X) ? PlayerX : PlayerO;
            if (current is NPCPlayer npc)
            {
                return npc.GetMove(Board);
            }
            return new Tuple<int, int>(-1, -1);
        }
    }
}
