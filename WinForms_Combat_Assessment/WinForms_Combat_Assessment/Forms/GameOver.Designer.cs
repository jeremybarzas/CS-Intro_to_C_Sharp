namespace WinForms_Combat_Assessment
{
    partial class GameOver
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
            this.Game_Over_Label = new System.Windows.Forms.Label();
            this.Damage_Dealt_Text = new System.Windows.Forms.RichTextBox();
            this.Kills_Text = new System.Windows.Forms.RichTextBox();
            this.Status_Text = new System.Windows.Forms.RichTextBox();
            this.Player_Name_Text = new System.Windows.Forms.RichTextBox();
            this.Damage_Dealt_Label = new System.Windows.Forms.Label();
            this.Kills_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Player_Label = new System.Windows.Forms.Label();
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.Exit_Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Game_Over_Label
            // 
            this.Game_Over_Label.AutoSize = true;
            this.Game_Over_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over_Label.Location = new System.Drawing.Point(196, 9);
            this.Game_Over_Label.Name = "Game_Over_Label";
            this.Game_Over_Label.Size = new System.Drawing.Size(181, 37);
            this.Game_Over_Label.TabIndex = 1;
            this.Game_Over_Label.Text = "Game Over";
            // 
            // Damage_Dealt_Text
            // 
            this.Damage_Dealt_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Damage_Dealt_Text.Location = new System.Drawing.Point(447, 77);
            this.Damage_Dealt_Text.Name = "Damage_Dealt_Text";
            this.Damage_Dealt_Text.ReadOnly = true;
            this.Damage_Dealt_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Damage_Dealt_Text.Size = new System.Drawing.Size(112, 332);
            this.Damage_Dealt_Text.TabIndex = 19;
            this.Damage_Dealt_Text.Text = "";
            this.Damage_Dealt_Text.WordWrap = false;
            // 
            // Kills_Text
            // 
            this.Kills_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kills_Text.Location = new System.Drawing.Point(314, 77);
            this.Kills_Text.Name = "Kills_Text";
            this.Kills_Text.ReadOnly = true;
            this.Kills_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Kills_Text.Size = new System.Drawing.Size(112, 332);
            this.Kills_Text.TabIndex = 18;
            this.Kills_Text.Text = "";
            this.Kills_Text.WordWrap = false;
            // 
            // Status_Text
            // 
            this.Status_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Text.Location = new System.Drawing.Point(181, 77);
            this.Status_Text.Name = "Status_Text";
            this.Status_Text.ReadOnly = true;
            this.Status_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Status_Text.Size = new System.Drawing.Size(112, 332);
            this.Status_Text.TabIndex = 17;
            this.Status_Text.Text = "";
            this.Status_Text.WordWrap = false;
            // 
            // Player_Name_Text
            // 
            this.Player_Name_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Name_Text.Location = new System.Drawing.Point(18, 77);
            this.Player_Name_Text.Name = "Player_Name_Text";
            this.Player_Name_Text.ReadOnly = true;
            this.Player_Name_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Player_Name_Text.Size = new System.Drawing.Size(142, 332);
            this.Player_Name_Text.TabIndex = 16;
            this.Player_Name_Text.Text = "";
            this.Player_Name_Text.WordWrap = false;
            // 
            // Damage_Dealt_Label
            // 
            this.Damage_Dealt_Label.AutoSize = true;
            this.Damage_Dealt_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Damage_Dealt_Label.Location = new System.Drawing.Point(443, 54);
            this.Damage_Dealt_Label.Name = "Damage_Dealt_Label";
            this.Damage_Dealt_Label.Size = new System.Drawing.Size(124, 20);
            this.Damage_Dealt_Label.TabIndex = 15;
            this.Damage_Dealt_Label.Text = "Damage Dealt";
            // 
            // Kills_Label
            // 
            this.Kills_Label.AutoSize = true;
            this.Kills_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kills_Label.Location = new System.Drawing.Point(352, 54);
            this.Kills_Label.Name = "Kills_Label";
            this.Kills_Label.Size = new System.Drawing.Size(41, 20);
            this.Kills_Label.TabIndex = 14;
            this.Kills_Label.Text = "Kills";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.Location = new System.Drawing.Point(213, 54);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(62, 20);
            this.Status_Label.TabIndex = 13;
            this.Status_Label.Text = "Status";
            // 
            // Player_Label
            // 
            this.Player_Label.AutoSize = true;
            this.Player_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Label.Location = new System.Drawing.Point(63, 54);
            this.Player_Label.Name = "Player_Label";
            this.Player_Label.Size = new System.Drawing.Size(58, 20);
            this.Player_Label.TabIndex = 12;
            this.Player_Label.Text = "Player";
            // 
            // To_Main_Menu
            // 
            this.To_Main_Menu.Location = new System.Drawing.Point(12, 427);
            this.To_Main_Menu.Name = "To_Main_Menu";
            this.To_Main_Menu.Size = new System.Drawing.Size(75, 23);
            this.To_Main_Menu.TabIndex = 20;
            this.To_Main_Menu.Text = "Main Menu";
            this.To_Main_Menu.UseVisualStyleBackColor = true;
            this.To_Main_Menu.Click += new System.EventHandler(this.To_Main_Menu_Click);
            // 
            // Exit_Game
            // 
            this.Exit_Game.Location = new System.Drawing.Point(497, 427);
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(75, 23);
            this.Exit_Game.TabIndex = 21;
            this.Exit_Game.Text = "Exit Game";
            this.Exit_Game.UseVisualStyleBackColor = true;
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Exit_Game);
            this.Controls.Add(this.To_Main_Menu);
            this.Controls.Add(this.Damage_Dealt_Text);
            this.Controls.Add(this.Kills_Text);
            this.Controls.Add(this.Status_Text);
            this.Controls.Add(this.Player_Name_Text);
            this.Controls.Add(this.Damage_Dealt_Label);
            this.Controls.Add(this.Kills_Label);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Player_Label);
            this.Controls.Add(this.Game_Over_Label);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Game_Over_Label;
        private System.Windows.Forms.RichTextBox Damage_Dealt_Text;
        private System.Windows.Forms.RichTextBox Kills_Text;
        private System.Windows.Forms.RichTextBox Status_Text;
        private System.Windows.Forms.RichTextBox Player_Name_Text;
        private System.Windows.Forms.Label Damage_Dealt_Label;
        private System.Windows.Forms.Label Kills_Label;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Label Player_Label;
        private System.Windows.Forms.Button To_Main_Menu;
        private System.Windows.Forms.Button Exit_Game;
    }
}