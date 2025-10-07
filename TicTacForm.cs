using TreIRadSlutProj.Players;
using static TreIRadSlutProj.Models;

namespace TreIRadSlutProj
{
    public partial class TicTacForm : Form
    {
        private Game engine;
        private Points pointKeeper;
        private Button[,] buttons;

        public TicTacForm()
        {
            InitializeComponent();

            engine = new Game();
            pointKeeper = new Points();

            // sätter spelare, en riktig och en NPC (kommentera ut eller ta bort om du vill ha två riktiga spelare)
            engine.SetPlayers(new RealPlayer("You", PlayerMark.X), new NPCPlayer("Computer", PlayerMark.O));

            // använder designer-knapparna (button1..button9) — mappar dom till arrayen
            buttons = new Button[3, 3];

            // mappning: (x,y) där x = kolumn (0->2), y = rad (0->2)
            // anpassar layouten,följer standarden i  designern
            buttons[0, 0] = button1; // kolumn 0, rad 0
            buttons[0, 1] = button2; // kolumn 0, rad 1
            buttons[0, 2] = button3; // kolumn 0, rad 2
            buttons[1, 0] = button4; // kolumn 1, rad 0
            buttons[1, 1] = button5; // kolumn 1, rad 1
            buttons[1, 2] = button6; // kolumn 1, rad 2
            buttons[2, 0] = button7; // kolumn 2, rad 0
            buttons[2, 1] = button8; // kolumn 2, rad 1
            buttons[2, 2] = button9; // kolumn 2, rad 2

            // lägger in tag & click handlers för alla knappar
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    var btn = buttons[x, y];
                    btn.Tag = new Tuple<int, int>(x, y);
                    btn.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
                    btn.Text = ""; 
                    btn.Enabled = true;
                    btn.Click += OnCellClicked;
                }
            }

            // uppdatera Status och Statistik labelserna 
            Status.Text = "Turn: X"; 
            Status.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);

            Statistik.Text = $"X wins: {pointKeeper.CurrentStats.XWins}  O wins: {pointKeeper.CurrentStats.OWins}  Draws: {pointKeeper.CurrentStats.Draws}";

            // kopplar New Game-knappen

            ButtonNew.Click += OnNewGameClicked;

            engine.StartNewGame();
        }

        private void OnCellClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var (x, y) = (Tuple<int, int>)btn.Tag;
            if (!engine.MakeMove(x, y)) return;

            btn.Text = engine.Board.Cells[x, y] == PlayerMark.X ? "X" : "O";

            if (engine.CurrentResult != GameResult.InProgress)
            {
                if (engine.CurrentResult == GameResult.X_Wins) MessageBox.Show("X Wins!");
                else if (engine.CurrentResult == GameResult.O_Wins) MessageBox.Show("O Wins!");
                else MessageBox.Show("Draw!");

                pointKeeper.AddResult(engine.CurrentResult);
                UpdateStatsLabel();
                DisableBoard();
                return;
            }

            Status.Text = "Turn: " + (engine.CurrentTurn == PlayerMark.X ? "X" : "O");

            // detta är till för att låta NPC:n göra sitt drag, kommentera ut hela dnna delen om du vill att två riktiga spelare ska spela
            // för 2 riktia spelare kommentera ut härifrån 
            if (engine.CurrentResult == GameResult.InProgress)
            {
                var aiMove = engine.GetAIMoveIfAny();
                if (aiMove.Item1 >= 0)
                {
                    engine.MakeMove(aiMove.Item1, aiMove.Item2);

                    buttons[aiMove.Item1, aiMove.Item2].Text = engine.Board.Cells[aiMove.Item1, aiMove.Item2] == PlayerMark.X ? "X" : "O";
                    // hanterar slutet av spelet efter NPC-draget
                }
            }

            Status.Text = "Turn: " + (engine.CurrentTurn == PlayerMark.X ? "X" : "O");
            // hit för 2 riktiga spelare
        }

        private void OnNewGameClicked(object sender, EventArgs e)
        {
            engine.StartNewGame();
            Status.Text = "Turn: X";

            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    buttons[x, y].Text = "";
                    buttons[x, y].Enabled = true;
                }
        }

        private void UpdateStatsLabel()
        {
            Statistik.Text = $"X wins: {pointKeeper.CurrentStats.XWins}  O wins: {pointKeeper.CurrentStats.OWins}  Draws: {pointKeeper.CurrentStats.Draws}";
        }

        private void DisableBoard()
        {
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    buttons[x, y].Enabled = false;
        }
    }
}
