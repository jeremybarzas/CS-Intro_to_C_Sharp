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
        private TurnManager turnManager;
       
        public Form1()
        {
            var parties = new List<Party>();

            // Party 1 setup
            parties.Add(new Party("Horde"));

            parties[0].Roster.Add(new Player("Orc"));
            parties[0].Roster.Add(new Player("Troll"));
            parties[0].Roster.Add(new Player("Undead"));

            // Party 2 setup
            parties.Add(new Party("Alliance"));

            parties[1].Roster.Add(new Player("Human"));
            parties[1].Roster.Add(new Player("Nightelf"));
            parties[1].Roster.Add(new Player("Dwarf"));

            turnManager = new TurnManager(parties);

            InitializeComponent();
            
            // Party 1 text
            textBox1.Text = turnManager.Parties[0].Name;

            // P1 Player 1 text
            textBox2.Text = turnManager.Parties[0].Roster[0].Name;
            // P1 Player 2 text
            textBox3.Text = turnManager.Parties[0].Roster[1].Name;
            // P1 Player 3 text
            textBox4.Text = turnManager.Parties[0].Roster[2].Name;

            // Party 2 text
            textBox8.Text = turnManager.Parties[1].Name;

            // P2 Player 1 text
            textBox5.Text = turnManager.Parties[1].Roster[0].Name;
            // P2 Player 2 text
            textBox6.Text = turnManager.Parties[1].Roster[1].Name;
            // P2 Player 3 text
            textBox7.Text = turnManager.Parties[1].Roster[2].Name;

            // Current player's turn
            textBox11.Text = turnManager.CurPlayerID + "It is " + turnManager.CurPlayer.Name + "'s turn to perform an action.";
        }

        // Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            textBox11.Text = turnManager.CurPlayer.Name + " has chosen to attack.";

            turnManager.CurPlayer.Attack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox11.Text = turnManager.CurPlayer.Name + " has chosen to defend.";

            turnManager.CurPlayer.Defend();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            turnManager.CurPlayer.EndTurn();
            
            turnManager.NextTurn();

            textBox11.Text = turnManager.CurPlayerID + "It is " + turnManager.CurPlayer.Name + "'s turn to perform an action.";
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
    }
}