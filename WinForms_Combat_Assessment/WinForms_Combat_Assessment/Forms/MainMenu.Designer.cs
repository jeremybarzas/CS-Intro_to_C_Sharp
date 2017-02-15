namespace WinForms_Combat_Assessment
{
    partial class MainMenu
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
            this.New_Game = new System.Windows.Forms.Button();
            this.Load_Game = new System.Windows.Forms.Button();
            this.Exit_Game = new System.Windows.Forms.Button();
            this.Form_Name = new System.Windows.Forms.Label();
            this.Game_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // New_Game
            // 
            this.New_Game.Location = new System.Drawing.Point(247, 248);
            this.New_Game.Name = "New_Game";
            this.New_Game.Size = new System.Drawing.Size(75, 23);
            this.New_Game.TabIndex = 1;
            this.New_Game.Text = "New Game";
            this.New_Game.UseVisualStyleBackColor = true;
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // Load_Game
            // 
            this.Load_Game.Location = new System.Drawing.Point(247, 289);
            this.Load_Game.Name = "Load_Game";
            this.Load_Game.Size = new System.Drawing.Size(75, 23);
            this.Load_Game.TabIndex = 2;
            this.Load_Game.Text = "Load Game";
            this.Load_Game.UseVisualStyleBackColor = true;
            this.Load_Game.Click += new System.EventHandler(this.Load_Game_Click);
            // 
            // Exit_Game
            // 
            this.Exit_Game.Location = new System.Drawing.Point(247, 332);
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(75, 23);
            this.Exit_Game.TabIndex = 3;
            this.Exit_Game.Text = "Exit Game";
            this.Exit_Game.UseVisualStyleBackColor = true;
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // Form_Name
            // 
            this.Form_Name.AutoSize = true;
            this.Form_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Name.Location = new System.Drawing.Point(202, 122);
            this.Form_Name.Name = "Form_Name";
            this.Form_Name.Size = new System.Drawing.Size(174, 37);
            this.Form_Name.TabIndex = 4;
            this.Form_Name.Text = "Main Menu";
            this.Form_Name.Click += new System.EventHandler(this.Form_Name_Click);
            // 
            // Game_Title
            // 
            this.Game_Title.AutoSize = true;
            this.Game_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Title.Location = new System.Drawing.Point(141, 31);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(311, 55);
            this.Game_Title.TabIndex = 5;
            this.Game_Title.Text = "TBFFARPGA";
            this.Game_Title.Click += new System.EventHandler(this.Game_Title_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Game_Title);
            this.Controls.Add(this.Form_Name);
            this.Controls.Add(this.Exit_Game);
            this.Controls.Add(this.Load_Game);
            this.Controls.Add(this.New_Game);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New_Game;
        private System.Windows.Forms.Button Load_Game;
        private System.Windows.Forms.Button Exit_Game;
        private System.Windows.Forms.Label Form_Name;
        private System.Windows.Forms.Label Game_Title;
    }
}