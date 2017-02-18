﻿using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class GameRules : Form
    {
        public GameRules()
        {
            InitializeComponent();                        
        }

        private void GameRules_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 100; i++)
                comboBox1.Items.Add(i);
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 0);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppManager.Instance.DataManager.PlayerCount = (int)comboBox1.SelectedItem;          
        }
    }
}