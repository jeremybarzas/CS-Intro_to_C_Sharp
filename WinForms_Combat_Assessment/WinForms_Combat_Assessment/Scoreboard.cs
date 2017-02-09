﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            foreach(Character character in GameManager.Instance.GameRoster)
            {
                Player_Name_Text.Text += " " + character.Name + "\n\n";                
                Kills_Text.Text += "    " + character.Kills + "\n\n";
                Score_Text.Text += "    " + character.Score + "\n\n";

                if (character.Alive == true)
                    Status_Text.Text += "   Alive" + "\n\n";
                else
                    Status_Text.Text += "   Dead" + "\n\n";          
            }
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Dispose();
            nextForm.Show();
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(4);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Dispose();
            nextForm.Show();
        }

        private void Scoreboard_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}