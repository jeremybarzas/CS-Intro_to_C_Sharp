namespace WinForms_Combat_Assessment
{
    partial class CharacterSheet
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
            this.Character_Name = new System.Windows.Forms.TextBox();
            this.Character_Name_Label = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Sheet";
            // 
            // Character_Name
            // 
            this.Character_Name.Location = new System.Drawing.Point(228, 93);
            this.Character_Name.Name = "Character_Name";
            this.Character_Name.Size = new System.Drawing.Size(165, 20);
            this.Character_Name.TabIndex = 1;            
            // 
            // Character_Name_Label
            // 
            this.Character_Name_Label.AutoSize = true;
            this.Character_Name_Label.Location = new System.Drawing.Point(138, 96);
            this.Character_Name_Label.Name = "Character_Name_Label";
            this.Character_Name_Label.Size = new System.Drawing.Size(84, 13);
            this.Character_Name_Label.TabIndex = 2;
            this.Character_Name_Label.Text = "Character Name";
            this.Character_Name_Label.Click += new System.EventHandler(this.Character_Name_Label_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(497, 427);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // To_Main_Menu
            // 
            this.To_Main_Menu.Location = new System.Drawing.Point(12, 427);
            this.To_Main_Menu.Name = "To_Main_Menu";
            this.To_Main_Menu.Size = new System.Drawing.Size(75, 23);
            this.To_Main_Menu.TabIndex = 4;
            this.To_Main_Menu.Text = "Main Menu";
            this.To_Main_Menu.UseVisualStyleBackColor = true;
            this.To_Main_Menu.Click += new System.EventHandler(this.To_Main_Menu_Click);
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.To_Main_Menu);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Character_Name_Label);
            this.Controls.Add(this.Character_Name);
            this.Controls.Add(this.label1);
            this.Name = "CharacterSheet";
            this.Text = "CharacterSheet";
            this.Load += new System.EventHandler(this.CharacterSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Character_Name;
        private System.Windows.Forms.Label Character_Name_Label;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button To_Main_Menu;
    }
}