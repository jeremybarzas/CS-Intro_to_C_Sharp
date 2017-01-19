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
        private TurnManager TurnManager;
       
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

            // Current player's turn
            textBox11.Text = "It is " + TurnManager.CurrentPlayer.Name + "'s turn to perform an action.";
        }

        // Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            textBox11.Text = TurnManager.CurrentPlayer.Name + " has chosen to attack.";

            TurnManager.CurrentPlayer.Attack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox11.Text = TurnManager.CurrentPlayer.Name + " has chosen to defend.";

            TurnManager.CurrentPlayer.Defend();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TurnManager.CurrentPlayer.EndTurn();
            
            textBox11.Text = "It is " + TurnManager.CurrentPlayer.Name + "'s turn to perform an action.";
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // temporary variable to hold current player state.
            TurnManager currentPlayer = TurnManager;

            // series
            DataManagement<TurnManager>.Serialize("Player", currentPlayer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurnManager lastPlayer = DataManagement<TurnManager>.Deserialize("Player");

            TurnManager = lastPlayer;

            textBox11.Text = "It is " + TurnManager.CurrentParty.CurrentPlayer.Name + "'s turn to perform an action.";
        }
    }
}