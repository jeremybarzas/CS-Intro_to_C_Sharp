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
            this.components = new System.ComponentModel.Container();
            this.Combat_Phase_Label = new System.Windows.Forms.Label();
            this.Current_Player_Name_Label = new System.Windows.Forms.Label();
            this.Attack_Selector = new System.Windows.Forms.ComboBox();
            this.weaponListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameRosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Item_Selector = new System.Windows.Forms.ComboBox();
            this.itemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Spell_Selector = new System.Windows.Forms.ComboBox();
            this.spellListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.End_Turn = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Spell_Target_Selector = new System.Windows.Forms.ComboBox();
            this.gameRosterBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Item_Target_Selector = new System.Windows.Forms.ComboBox();
            this.gameRosterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Attack_Target_Selector = new System.Windows.Forms.ComboBox();
            this.gameRosterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.weaponListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource1)).BeginInit();
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
            // 
            // weaponListBindingSource
            // 
            this.weaponListBindingSource.DataMember = "WeaponList";
            this.weaponListBindingSource.DataSource = this.dataManagerBindingSource;
            // 
            // dataManagerBindingSource
            // 
            this.dataManagerBindingSource.DataSource = typeof(WinForms_Combat_Assessment.DataManager);
            // 
            // gameRosterBindingSource
            // 
            this.gameRosterBindingSource.DataMember = "GameRoster";
            this.gameRosterBindingSource.DataSource = this.dataManagerBindingSource;
            // 
            // Item_Selector
            // 
            this.Item_Selector.FormattingEnabled = true;
            this.Item_Selector.Location = new System.Drawing.Point(227, 110);
            this.Item_Selector.Name = "Item_Selector";
            this.Item_Selector.Size = new System.Drawing.Size(121, 21);
            this.Item_Selector.TabIndex = 3;
            this.Item_Selector.SelectedIndexChanged += new System.EventHandler(this.Item_Selector_SelectedIndexChanged);
            // 
            // itemListBindingSource
            // 
            this.itemListBindingSource.DataMember = "ItemList";
            this.itemListBindingSource.DataSource = this.dataManagerBindingSource;
            // 
            // Spell_Selector
            // 
            this.Spell_Selector.FormattingEnabled = true;
            this.Spell_Selector.Location = new System.Drawing.Point(396, 110);
            this.Spell_Selector.Name = "Spell_Selector";
            this.Spell_Selector.Size = new System.Drawing.Size(121, 21);
            this.Spell_Selector.TabIndex = 4;
            // 
            // spellListBindingSource
            // 
            this.spellListBindingSource.DataMember = "SpellList";
            this.spellListBindingSource.DataSource = this.dataManagerBindingSource;
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
            // Spell_Target_Selector
            // 
            this.Spell_Target_Selector.FormattingEnabled = true;
            this.Spell_Target_Selector.Location = new System.Drawing.Point(396, 179);
            this.Spell_Target_Selector.Name = "Spell_Target_Selector";
            this.Spell_Target_Selector.Size = new System.Drawing.Size(121, 21);
            this.Spell_Target_Selector.TabIndex = 10;
            // 
            // gameRosterBindingSource3
            // 
            this.gameRosterBindingSource3.DataMember = "GameRoster";
            this.gameRosterBindingSource3.DataSource = this.dataManagerBindingSource;
            // 
            // Item_Target_Selector
            // 
            this.Item_Target_Selector.FormattingEnabled = true;
            this.Item_Target_Selector.Location = new System.Drawing.Point(227, 179);
            this.Item_Target_Selector.Name = "Item_Target_Selector";
            this.Item_Target_Selector.Size = new System.Drawing.Size(121, 21);
            this.Item_Target_Selector.TabIndex = 9;
            // 
            // gameRosterBindingSource2
            // 
            this.gameRosterBindingSource2.DataMember = "GameRoster";
            this.gameRosterBindingSource2.DataSource = this.dataManagerBindingSource;
            // 
            // Attack_Target_Selector
            // 
            this.Attack_Target_Selector.FormattingEnabled = true;
            this.Attack_Target_Selector.Location = new System.Drawing.Point(59, 179);
            this.Attack_Target_Selector.Name = "Attack_Target_Selector";
            this.Attack_Target_Selector.Size = new System.Drawing.Size(121, 21);
            this.Attack_Target_Selector.TabIndex = 8;
            // 
            // gameRosterBindingSource1
            // 
            this.gameRosterBindingSource1.DataMember = "GameRoster";
            this.gameRosterBindingSource1.DataSource = this.dataManagerBindingSource;
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Spell_Target_Selector);
            this.Controls.Add(this.Item_Target_Selector);
            this.Controls.Add(this.Attack_Target_Selector);
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
            ((System.ComponentModel.ISupportInitialize)(this.weaponListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRosterBindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox Spell_Target_Selector;
        private System.Windows.Forms.ComboBox Item_Target_Selector;
        private System.Windows.Forms.ComboBox Attack_Target_Selector;
        private System.Windows.Forms.BindingSource gameRosterBindingSource;
        private System.Windows.Forms.BindingSource dataManagerBindingSource;
        private System.Windows.Forms.BindingSource itemListBindingSource;
        private System.Windows.Forms.BindingSource spellListBindingSource;
        private System.Windows.Forms.BindingSource weaponListBindingSource;
        private System.Windows.Forms.BindingSource gameRosterBindingSource3;
        private System.Windows.Forms.BindingSource gameRosterBindingSource2;
        private System.Windows.Forms.BindingSource gameRosterBindingSource1;
    }
}