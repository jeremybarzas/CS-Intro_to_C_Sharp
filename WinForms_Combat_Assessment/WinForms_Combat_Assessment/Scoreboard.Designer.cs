namespace WinForms_Combat_Assessment
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
            this.Scoreboard_Text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoreboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // Scoreboard_Text
            // 
            this.Scoreboard_Text.Location = new System.Drawing.Point(46, 49);
            this.Scoreboard_Text.Name = "Scoreboard_Text";
            this.Scoreboard_Text.Size = new System.Drawing.Size(488, 361);
            this.Scoreboard_Text.TabIndex = 4;
            this.Scoreboard_Text.Text = "";
            this.Scoreboard_Text.TextChanged += new System.EventHandler(this.Scoreboard_Text_TextChanged);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Scoreboard_Text);
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
        private System.Windows.Forms.RichTextBox Scoreboard_Text;
    }
}