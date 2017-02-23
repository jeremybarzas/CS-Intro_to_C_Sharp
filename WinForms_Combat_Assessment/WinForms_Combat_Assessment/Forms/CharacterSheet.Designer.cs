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
            this.Weapon_Selector_1 = new System.Windows.Forms.ComboBox();
            this.Item_Selector_1 = new System.Windows.Forms.ComboBox();
            this.Spell_Selector_1 = new System.Windows.Forms.ComboBox();
            this.Spell_Selector_2 = new System.Windows.Forms.ComboBox();
            this.Item_Selector_2 = new System.Windows.Forms.ComboBox();
            this.Weapon_Selector_2 = new System.Windows.Forms.ComboBox();
            this.Item_Selector_3 = new System.Windows.Forms.ComboBox();
            this.Item_Selector_4 = new System.Windows.Forms.ComboBox();
            this.Weapon_Selector_Label = new System.Windows.Forms.Label();
            this.Item_Selector_Label = new System.Windows.Forms.Label();
            this.Spell_Selector_Label = new System.Windows.Forms.Label();
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
            this.Character_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character_Name_Label.Location = new System.Drawing.Point(102, 94);
            this.Character_Name_Label.Name = "Character_Name_Label";
            this.Character_Name_Label.Size = new System.Drawing.Size(120, 16);
            this.Character_Name_Label.TabIndex = 2;
            this.Character_Name_Label.Text = "Character Name";
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
            // Weapon_Selector_1
            // 
            this.Weapon_Selector_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Weapon_Selector_1.FormattingEnabled = true;
            this.Weapon_Selector_1.Location = new System.Drawing.Point(57, 160);
            this.Weapon_Selector_1.Name = "Weapon_Selector_1";
            this.Weapon_Selector_1.Size = new System.Drawing.Size(121, 21);
            this.Weapon_Selector_1.TabIndex = 5;
            // 
            // Item_Selector_1
            // 
            this.Item_Selector_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_Selector_1.FormattingEnabled = true;
            this.Item_Selector_1.Location = new System.Drawing.Point(228, 160);
            this.Item_Selector_1.Name = "Item_Selector_1";
            this.Item_Selector_1.Size = new System.Drawing.Size(121, 21);
            this.Item_Selector_1.TabIndex = 6;
            // 
            // Spell_Selector_1
            // 
            this.Spell_Selector_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spell_Selector_1.FormattingEnabled = true;
            this.Spell_Selector_1.Location = new System.Drawing.Point(396, 160);
            this.Spell_Selector_1.Name = "Spell_Selector_1";
            this.Spell_Selector_1.Size = new System.Drawing.Size(121, 21);
            this.Spell_Selector_1.TabIndex = 7;
            // 
            // Spell_Selector_2
            // 
            this.Spell_Selector_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spell_Selector_2.FormattingEnabled = true;
            this.Spell_Selector_2.Location = new System.Drawing.Point(396, 207);
            this.Spell_Selector_2.Name = "Spell_Selector_2";
            this.Spell_Selector_2.Size = new System.Drawing.Size(121, 21);
            this.Spell_Selector_2.TabIndex = 10;
            // 
            // Item_Selector_2
            // 
            this.Item_Selector_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_Selector_2.FormattingEnabled = true;
            this.Item_Selector_2.Location = new System.Drawing.Point(228, 207);
            this.Item_Selector_2.Name = "Item_Selector_2";
            this.Item_Selector_2.Size = new System.Drawing.Size(121, 21);
            this.Item_Selector_2.TabIndex = 9;
            // 
            // Weapon_Selector_2
            // 
            this.Weapon_Selector_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Weapon_Selector_2.FormattingEnabled = true;
            this.Weapon_Selector_2.Location = new System.Drawing.Point(57, 207);
            this.Weapon_Selector_2.Name = "Weapon_Selector_2";
            this.Weapon_Selector_2.Size = new System.Drawing.Size(121, 21);
            this.Weapon_Selector_2.TabIndex = 8;
            // 
            // Item_Selector_3
            // 
            this.Item_Selector_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_Selector_3.FormattingEnabled = true;
            this.Item_Selector_3.Location = new System.Drawing.Point(228, 252);
            this.Item_Selector_3.Name = "Item_Selector_3";
            this.Item_Selector_3.Size = new System.Drawing.Size(121, 21);
            this.Item_Selector_3.TabIndex = 12;
            // 
            // Item_Selector_4
            // 
            this.Item_Selector_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_Selector_4.FormattingEnabled = true;
            this.Item_Selector_4.Location = new System.Drawing.Point(228, 298);
            this.Item_Selector_4.Name = "Item_Selector_4";
            this.Item_Selector_4.Size = new System.Drawing.Size(121, 21);
            this.Item_Selector_4.TabIndex = 15;
            // 
            // Weapon_Selector_Label
            // 
            this.Weapon_Selector_Label.AutoSize = true;
            this.Weapon_Selector_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapon_Selector_Label.Location = new System.Drawing.Point(54, 141);
            this.Weapon_Selector_Label.Name = "Weapon_Selector_Label";
            this.Weapon_Selector_Label.Size = new System.Drawing.Size(128, 16);
            this.Weapon_Selector_Label.TabIndex = 18;
            this.Weapon_Selector_Label.Text = "Weapon Selector";
            // 
            // Item_Selector_Label
            // 
            this.Item_Selector_Label.AutoSize = true;
            this.Item_Selector_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Selector_Label.Location = new System.Drawing.Point(225, 141);
            this.Item_Selector_Label.Name = "Item_Selector_Label";
            this.Item_Selector_Label.Size = new System.Drawing.Size(99, 16);
            this.Item_Selector_Label.TabIndex = 19;
            this.Item_Selector_Label.Text = "Item Selector";
            // 
            // Spell_Selector_Label
            // 
            this.Spell_Selector_Label.AutoSize = true;
            this.Spell_Selector_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spell_Selector_Label.Location = new System.Drawing.Point(393, 141);
            this.Spell_Selector_Label.Name = "Spell_Selector_Label";
            this.Spell_Selector_Label.Size = new System.Drawing.Size(106, 16);
            this.Spell_Selector_Label.TabIndex = 20;
            this.Spell_Selector_Label.Text = "Spell Selector";
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Spell_Selector_Label);
            this.Controls.Add(this.Item_Selector_Label);
            this.Controls.Add(this.Weapon_Selector_Label);
            this.Controls.Add(this.Item_Selector_4);
            this.Controls.Add(this.Item_Selector_3);
            this.Controls.Add(this.Spell_Selector_2);
            this.Controls.Add(this.Item_Selector_2);
            this.Controls.Add(this.Weapon_Selector_2);
            this.Controls.Add(this.Spell_Selector_1);
            this.Controls.Add(this.Item_Selector_1);
            this.Controls.Add(this.Weapon_Selector_1);
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
        private System.Windows.Forms.ComboBox Weapon_Selector_1;
        private System.Windows.Forms.ComboBox Item_Selector_1;
        private System.Windows.Forms.ComboBox Spell_Selector_1;
        private System.Windows.Forms.ComboBox Spell_Selector_2;
        private System.Windows.Forms.ComboBox Item_Selector_2;
        private System.Windows.Forms.ComboBox Weapon_Selector_2;
        private System.Windows.Forms.ComboBox Item_Selector_3;
        private System.Windows.Forms.ComboBox Item_Selector_4;
        private System.Windows.Forms.Label Weapon_Selector_Label;
        private System.Windows.Forms.Label Item_Selector_Label;
        private System.Windows.Forms.Label Spell_Selector_Label;
    }
}