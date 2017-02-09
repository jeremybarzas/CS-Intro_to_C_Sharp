﻿namespace WinForms_Combat_Assessment
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Game = new System.Windows.Forms.Button();
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.Save_Game = new System.Windows.Forms.Button();
            this.Player_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Kills_Label = new System.Windows.Forms.Label();
            this.Score_Label = new System.Windows.Forms.Label();
            this.Player_Name_Text = new System.Windows.Forms.RichTextBox();
            this.Status_Text = new System.Windows.Forms.RichTextBox();
            this.Kills_Text = new System.Windows.Forms.RichTextBox();
            this.Score_Text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoreboard";
            // 
            // Start_Game
            // 
            this.Start_Game.Location = new System.Drawing.Point(497, 427);
            this.Start_Game.Name = "Start_Game";
            this.Start_Game.Size = new System.Drawing.Size(75, 23);
            this.Start_Game.TabIndex = 1;
            this.Start_Game.Text = "Start Game";
            this.Start_Game.UseVisualStyleBackColor = true;
            this.Start_Game.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // To_Main_Menu
            // 
            this.To_Main_Menu.Location = new System.Drawing.Point(12, 427);
            this.To_Main_Menu.Name = "To_Main_Menu";
            this.To_Main_Menu.Size = new System.Drawing.Size(75, 23);
            this.To_Main_Menu.TabIndex = 2;
            this.To_Main_Menu.Text = "Main Menu";
            this.To_Main_Menu.UseVisualStyleBackColor = true;
            this.To_Main_Menu.Click += new System.EventHandler(this.To_Main_Menu_Click);
            // 
            // Save_Game
            // 
            this.Save_Game.Location = new System.Drawing.Point(257, 427);
            this.Save_Game.Name = "Save_Game";
            this.Save_Game.Size = new System.Drawing.Size(75, 23);
            this.Save_Game.TabIndex = 3;
            this.Save_Game.Text = "Save Game";
            this.Save_Game.UseVisualStyleBackColor = true;
            // 
            // Player_Label
            // 
            this.Player_Label.AutoSize = true;
            this.Player_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Label.Location = new System.Drawing.Point(69, 58);
            this.Player_Label.Name = "Player_Label";
            this.Player_Label.Size = new System.Drawing.Size(58, 20);
            this.Player_Label.TabIndex = 4;
            this.Player_Label.Text = "Player";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.Location = new System.Drawing.Point(216, 58);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(62, 20);
            this.Status_Label.TabIndex = 5;
            this.Status_Label.Text = "Status";
            // 
            // Kills_Label
            // 
            this.Kills_Label.AutoSize = true;
            this.Kills_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kills_Label.Location = new System.Drawing.Point(355, 58);
            this.Kills_Label.Name = "Kills_Label";
            this.Kills_Label.Size = new System.Drawing.Size(41, 20);
            this.Kills_Label.TabIndex = 6;
            this.Kills_Label.Text = "Kills";
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.Location = new System.Drawing.Point(475, 58);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(56, 20);
            this.Score_Label.TabIndex = 7;
            this.Score_Label.Text = "Score";
            // 
            // Player_Name_Text
            // 
            this.Player_Name_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Name_Text.Location = new System.Drawing.Point(21, 81);
            this.Player_Name_Text.Name = "Player_Name_Text";
            this.Player_Name_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Player_Name_Text.Size = new System.Drawing.Size(142, 340);
            this.Player_Name_Text.TabIndex = 8;
            this.Player_Name_Text.Text = "";
            this.Player_Name_Text.WordWrap = false;
            // 
            // Status_Text
            // 
            this.Status_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Text.Location = new System.Drawing.Point(184, 81);
            this.Status_Text.Name = "Status_Text";
            this.Status_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Status_Text.Size = new System.Drawing.Size(112, 340);
            this.Status_Text.TabIndex = 9;
            this.Status_Text.Text = "";
            this.Status_Text.WordWrap = false;
            // 
            // Kills_Text
            // 
            this.Kills_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kills_Text.Location = new System.Drawing.Point(317, 81);
            this.Kills_Text.Name = "Kills_Text";
            this.Kills_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Kills_Text.Size = new System.Drawing.Size(112, 340);
            this.Kills_Text.TabIndex = 10;
            this.Kills_Text.Text = "";
            this.Kills_Text.WordWrap = false;
            // 
            // Score_Text
            // 
            this.Score_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Text.Location = new System.Drawing.Point(450, 81);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Score_Text.Size = new System.Drawing.Size(112, 340);
            this.Score_Text.TabIndex = 11;
            this.Score_Text.Text = "";
            this.Score_Text.WordWrap = false;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.Kills_Text);
            this.Controls.Add(this.Status_Text);
            this.Controls.Add(this.Player_Name_Text);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.Kills_Label);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Player_Label);
            this.Controls.Add(this.Save_Game);
            this.Controls.Add(this.To_Main_Menu);
            this.Controls.Add(this.Start_Game);
            this.Controls.Add(this.label1);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Game;
        private System.Windows.Forms.Button To_Main_Menu;
        private System.Windows.Forms.Button Save_Game;
        private System.Windows.Forms.Label Player_Label;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Label Kills_Label;
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.RichTextBox Player_Name_Text;
        private System.Windows.Forms.RichTextBox Status_Text;
        private System.Windows.Forms.RichTextBox Kills_Text;
        private System.Windows.Forms.RichTextBox Score_Text;
    }
}