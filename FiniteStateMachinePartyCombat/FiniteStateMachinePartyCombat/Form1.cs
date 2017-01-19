using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiniteStateMachinePartyCombat
{
    public partial class Form1 : Form
    {
        public TurnManager TurnManager;
       
        public Form1()
        {
            InitializeComponent();
            InitCombat();          
        }

        private void InitCombat()
        {
            Player p1 = new Player("Orc0");
            Player p2 = new Player("Orc1");
            Player p3 = new Player("Orc2");

            Player p4 = new Player("Human0");
            Player p5 = new Player("Human1");
            Player p6 = new Player("Human2");

            Party Horde = new Party("Horde", p1, p2, p3);
            Party Alliance = new Party("Alliance", p4, p5, p6);
          
            TurnManager = new TurnManager(Horde, Alliance);

            // Party 1 text
            textBox1.Text = TurnManager.Parties[0].Name;
            // P1 Player 1 text
            textBox2.Text = TurnManager.Parties[0].Roster[0].Name;
            // P1 Player 2 text
            textBox3.Text = TurnManager.Parties[0].Roster[1].Name;
            // P1 Player 3 text
            textBox4.Text = TurnManager.Parties[0].Roster[2].Name;

            // Party 2 text
            textBox8.Text = TurnManager.Parties[1].Name;
            // P2 Player 1 text
            textBox7.Text = TurnManager.Parties[1].Roster[0].Name;
            // P2 Player 2 text
            textBox6.Text = TurnManager.Parties[1].Roster[1].Name;
            // P2 Player 3 text
            textBox5.Text = TurnManager.Parties[1].Roster[2].Name;

            // Turn counter text
            textBox9.Text = "Turn: " + TurnManager.TurnCount + "    Current Party: " + TurnManager.CurrentParty.Name + "    Current Player: " + TurnManager.CurrentParty.CurrentPlayer.Name;
            // Current turn info
            textBox10.Text = "Current Party ID: " + TurnManager.CurrentPartyId + "    Current Player ID: " + TurnManager.CurrentParty.CurrentPlayerId;
            // Current player's turn
            textBox11.Text = "It is " + TurnManager.CurrentParty.CurrentPlayer.Name + "'s turn to perform an action.";
        }

        // Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            textBox11.Text = TurnManager.CurrentParty.CurrentPlayer.Name + " has chosen to attack.";

            TurnManager.CurrentParty.CurrentPlayer.Attack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox11.Text = TurnManager.CurrentParty.CurrentPlayer.Name + " has chosen to defend.";

            TurnManager.CurrentParty.CurrentPlayer.Defend();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TurnManager.CurrentParty.CurrentPlayer.EndTurn();

            TurnManager.TurnCount++;

            textBox9.Text = "Turn: " + TurnManager.TurnCount + "    Current Party: " + TurnManager.CurrentParty.Name + "    Current Player: " + TurnManager.CurrentParty.CurrentPlayer.Name;
            textBox10.Text = "Current Party ID: " + TurnManager.CurrentPartyId + "    Current Player ID: " + TurnManager.CurrentParty.CurrentPlayerId;
            textBox11.Text = "It is " + TurnManager.CurrentParty.CurrentPlayer.Name + "'s turn to perform an action.";
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            DataManagement<TurnManager>.Serialize("GameState", TurnManager);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurnManager lastGame = DataManagement<TurnManager>.Deserialize("GameState");
            
            Player player1 = new Player(lastGame.Parties[0].Roster[0].Name);
            Player player2 = new Player(lastGame.Parties[0].Roster[1].Name);
            Player player3 = new Player(lastGame.Parties[0].Roster[2].Name);
            Player player4 = new Player(lastGame.Parties[1].Roster[0].Name);
            Player player5 = new Player(lastGame.Parties[1].Roster[1].Name);
            Player player6 = new Player(lastGame.Parties[1].Roster[2].Name);

            Party party1 = new Party(lastGame.Parties[0].Name);
            Party party2 = new Party(lastGame.Parties[1].Name);

            TurnManager.Parties.Clear();

            party1.AddPlayer(player1);
            party1.AddPlayer(player2);
            party1.AddPlayer(player3);
            party2.AddPlayer(player4);
            party2.AddPlayer(player5);
            party2.AddPlayer(player6);

            TurnManager.AddParty(party1);
            TurnManager.AddParty(party2);

            TurnManager.CurrentPartyId = lastGame.CurrentPartyId;
            TurnManager.CurrentParty = TurnManager.Parties[TurnManager.CurrentPartyId];

            TurnManager.CurrentParty.CurrentPlayerId = lastGame.CurrentParty.CurrentPlayerId;
            TurnManager.CurrentParty.CurrentPlayer = TurnManager.CurrentParty.Roster[TurnManager.CurrentParty.CurrentPlayerId];           

            TurnManager.TurnCount = lastGame.TurnCount;
            
            // Text Update
            textBox1.Text = TurnManager.Parties[0].Name;
            textBox2.Text = TurnManager.Parties[0].Roster[0].Name;
            textBox3.Text = TurnManager.Parties[0].Roster[1].Name;
            textBox4.Text = TurnManager.Parties[0].Roster[2].Name;
            
            textBox8.Text = TurnManager.Parties[1].Name;
            textBox7.Text = TurnManager.Parties[1].Roster[0].Name;
            textBox6.Text = TurnManager.Parties[1].Roster[1].Name;
            textBox5.Text = TurnManager.Parties[1].Roster[2].Name;

            textBox9.Text = "Turn: " + TurnManager.TurnCount + "    Current Party: " + TurnManager.CurrentParty.Name + "    Current Player: " + TurnManager.CurrentParty.CurrentPlayer.Name;
            textBox10.Text = "Current Party ID: " + TurnManager.CurrentPartyId + "    Current Player ID: " + TurnManager.CurrentParty.CurrentPlayerId;
            textBox11.Text = "It is " + TurnManager.CurrentParty.CurrentPlayer.Name + "'s turn to perform an action.";
        }

        // Text Boxes 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}