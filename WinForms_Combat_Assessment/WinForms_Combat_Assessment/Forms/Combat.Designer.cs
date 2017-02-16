namespace WinForms_Combat_Assessment
{
    partial class Combat
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
            this.Combat_Phase_Label = new System.Windows.Forms.Label();
            this.Current_Player_Name_Label = new System.Windows.Forms.Label();
            this.Attack_Selector = new System.Windows.Forms.ComboBox();
            this.Item_Selector = new System.Windows.Forms.ComboBox();
            this.Spell_Selector = new System.Windows.Forms.ComboBox();
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.End_Turn = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Select_Spell_Target = new System.Windows.Forms.ComboBox();
            this.Select_Item_Target = new System.Windows.Forms.ComboBox();
            this.Select_Attack_Target = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Combat_Phase_Label
            // 
            this.Combat_Phase_Label.AutoSize = true;
            this.Combat_Phase_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combat_Phase_Label.Location = new System.Drawing.Point(168, 9);
            this.Combat_Phase_Label.Name = "Combat_Phase_Label";
            this.Combat_Phase_Label.Size = new System.Drawing.Size(229, 37);
            this.Combat_Phase_Label.TabIndex = 0;
            this.Combat_Phase_Label.Text = "Combat Phase";
            // 
            // Current_Player_Name_Label
            // 
            this.Current_Player_Name_Label.AutoSize = true;
            this.Current_Player_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Player_Name_Label.Location = new System.Drawing.Point(208, 60);
            this.Current_Player_Name_Label.Name = "Current_Player_Name_Label";
            this.Current_Player_Name_Label.Size = new System.Drawing.Size(153, 16);
            this.Current_Player_Name_Label.TabIndex = 1;
            this.Current_Player_Name_Label.Text = "Current Player\'s Turn";
            // 
            // Attack_Selector
            // 
            this.Attack_Selector.FormattingEnabled = true;
            this.Attack_Selector.Location = new System.Drawing.Point(59, 110);
            this.Attack_Selector.Name = "Attack_Selector";
            this.Attack_Selector.Size = new System.Drawing.Size(121, 21);
            this.Attack_Selector.TabIndex = 2;
            this.Attack_Selector.Text = "Select Attack";
            // 
            // Item_Selector
            // 
            this.Item_Selector.FormattingEnabled = true;
            this.Item_Selector.Location = new System.Drawing.Point(227, 110);
            this.Item_Selector.Name = "Item_Selector";
            this.Item_Selector.Size = new System.Drawing.Size(121, 21);
            this.Item_Selector.TabIndex = 3;
            this.Item_Selector.Text = "Select Item";
            this.Item_Selector.SelectedIndexChanged += new System.EventHandler(this.Item_Selector_SelectedIndexChanged);
            // 
            // Spell_Selector
            // 
            this.Spell_Selector.FormattingEnabled = true;
            this.Spell_Selector.Location = new System.Drawing.Point(396, 110);
            this.Spell_Selector.Name = "Spell_Selector";
            this.Spell_Selector.Size = new System.Drawing.Size(121, 21);
            this.Spell_Selector.TabIndex = 4;
            this.Spell_Selector.Text = "Select Spell";
            // 
            // To_Main_Menu
            // 
            this.To_Main_Menu.Location = new System.Drawing.Point(12, 427);
            this.To_Main_Menu.Name = "To_Main_Menu";
            this.To_Main_Menu.Size = new System.Drawing.Size(75, 23);
            this.To_Main_Menu.TabIndex = 5;
            this.To_Main_Menu.Text = "Main Menu";
            this.To_Main_Menu.UseVisualStyleBackColor = true;
            this.To_Main_Menu.Click += new System.EventHandler(this.To_Main_Menu_Click);
            // 
            // End_Turn
            // 
            this.End_Turn.Location = new System.Drawing.Point(497, 427);
            this.End_Turn.Name = "End_Turn";
            this.End_Turn.Size = new System.Drawing.Size(75, 23);
            this.End_Turn.TabIndex = 6;
            this.End_Turn.Text = "End Turn";
            this.End_Turn.UseVisualStyleBackColor = true;
            this.End_Turn.Click += new System.EventHandler(this.End_Turn_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(252, 427);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Select_Spell_Target
            // 
            this.Select_Spell_Target.FormattingEnabled = true;
            this.Select_Spell_Target.Location = new System.Drawing.Point(396, 179);
            this.Select_Spell_Target.Name = "Select_Spell_Target";
            this.Select_Spell_Target.Size = new System.Drawing.Size(121, 21);
            this.Select_Spell_Target.TabIndex = 10;
            this.Select_Spell_Target.Text = "Select Spell Target";
            // 
            // Select_Item_Target
            // 
            this.Select_Item_Target.FormattingEnabled = true;
            this.Select_Item_Target.Location = new System.Drawing.Point(227, 179);
            this.Select_Item_Target.Name = "Select_Item_Target";
            this.Select_Item_Target.Size = new System.Drawing.Size(121, 21);
            this.Select_Item_Target.TabIndex = 9;
            this.Select_Item_Target.Text = "Select Item Target";
            // 
            // Select_Attack_Target
            // 
            this.Select_Attack_Target.FormattingEnabled = true;
            this.Select_Attack_Target.Location = new System.Drawing.Point(59, 179);
            this.Select_Attack_Target.Name = "Select_Attack_Target";
            this.Select_Attack_Target.Size = new System.Drawing.Size(121, 21);
            this.Select_Attack_Target.TabIndex = 8;
            this.Select_Attack_Target.Text = "Select Attack Target";
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Select_Spell_Target);
            this.Controls.Add(this.Select_Item_Target);
            this.Controls.Add(this.Select_Attack_Target);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.End_Turn);
            this.Controls.Add(this.To_Main_Menu);
            this.Controls.Add(this.Spell_Selector);
            this.Controls.Add(this.Item_Selector);
            this.Controls.Add(this.Attack_Selector);
            this.Controls.Add(this.Current_Player_Name_Label);
            this.Controls.Add(this.Combat_Phase_Label);
            this.Name = "Combat";
            this.Text = "CombatPhase";
            this.Load += new System.EventHandler(this.Combat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Combat_Phase_Label;
        private System.Windows.Forms.Label Current_Player_Name_Label;
        private System.Windows.Forms.ComboBox Attack_Selector;
        private System.Windows.Forms.ComboBox Item_Selector;
        private System.Windows.Forms.ComboBox Spell_Selector;
        private System.Windows.Forms.Button To_Main_Menu;
        private System.Windows.Forms.Button End_Turn;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.ComboBox Select_Spell_Target;
        private System.Windows.Forms.ComboBox Select_Item_Target;
        private System.Windows.Forms.ComboBox Select_Attack_Target;
    }
}