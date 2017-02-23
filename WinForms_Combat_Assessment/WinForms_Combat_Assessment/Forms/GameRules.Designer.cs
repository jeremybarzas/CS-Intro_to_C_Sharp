namespace WinForms_Combat_Assessment
{
    partial class GameRules
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
            this.Number_of_Players_Selector = new System.Windows.Forms.ComboBox();
            this.Next = new System.Windows.Forms.Button();
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.Game_Rules_Text = new System.Windows.Forms.RichTextBox();
            this.Number_of_Player_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Rules";
            // 
            // Number_of_Players_Selector
            // 
            this.Number_of_Players_Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Number_of_Players_Selector.FormattingEnabled = true;
            this.Number_of_Players_Selector.Location = new System.Drawing.Point(260, 67);
            this.Number_of_Players_Selector.MaxDropDownItems = 10;
            this.Number_of_Players_Selector.Name = "Number_of_Players_Selector";
            this.Number_of_Players_Selector.Size = new System.Drawing.Size(45, 21);
            this.Number_of_Players_Selector.TabIndex = 1;
            this.Number_of_Players_Selector.SelectedIndexChanged += new System.EventHandler(this.Number_of_Players_Selector_SelectedIndexChanged);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(497, 427);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // To_Main_Menu
            // 
            this.To_Main_Menu.Location = new System.Drawing.Point(12, 427);
            this.To_Main_Menu.Name = "To_Main_Menu";
            this.To_Main_Menu.Size = new System.Drawing.Size(75, 23);
            this.To_Main_Menu.TabIndex = 3;
            this.To_Main_Menu.Text = "Main Menu";
            this.To_Main_Menu.UseVisualStyleBackColor = true;
            this.To_Main_Menu.Click += new System.EventHandler(this.To_Main_Menu_Click);
            // 
            // Game_Rules_Text
            // 
            this.Game_Rules_Text.Location = new System.Drawing.Point(56, 112);
            this.Game_Rules_Text.Name = "Game_Rules_Text";
            this.Game_Rules_Text.ReadOnly = true;
            this.Game_Rules_Text.Size = new System.Drawing.Size(450, 291);
            this.Game_Rules_Text.TabIndex = 4;
            this.Game_Rules_Text.Text = "";
            // 
            // Number_of_Player_Label
            // 
            this.Number_of_Player_Label.AutoSize = true;
            this.Number_of_Player_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_Player_Label.Location = new System.Drawing.Point(118, 68);
            this.Number_of_Player_Label.Name = "Number_of_Player_Label";
            this.Number_of_Player_Label.Size = new System.Drawing.Size(136, 16);
            this.Number_of_Player_Label.TabIndex = 5;
            this.Number_of_Player_Label.Text = "Number of Players";
            // 
            // GameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Number_of_Player_Label);
            this.Controls.Add(this.Game_Rules_Text);
            this.Controls.Add(this.To_Main_Menu);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Number_of_Players_Selector);
            this.Controls.Add(this.label1);
            this.Name = "GameRules";
            this.Text = "GameRules";
            this.Load += new System.EventHandler(this.GameRules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Number_of_Players_Selector;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button To_Main_Menu;
        private System.Windows.Forms.RichTextBox Game_Rules_Text;
        private System.Windows.Forms.Label Number_of_Player_Label;
    }
}