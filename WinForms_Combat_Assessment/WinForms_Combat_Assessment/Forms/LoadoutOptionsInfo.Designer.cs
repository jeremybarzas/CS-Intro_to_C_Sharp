namespace WinForms_Combat_Assessment
{
    partial class LoadoutOptionsInfo
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
            this.Loadout_Options_Info_Label = new System.Windows.Forms.Label();
            this.Loadout_Options_Info_Text = new System.Windows.Forms.RichTextBox();
            this.Back_To_Previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loadout_Options_Info_Label
            // 
            this.Loadout_Options_Info_Label.AutoSize = true;
            this.Loadout_Options_Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadout_Options_Info_Label.Location = new System.Drawing.Point(124, 9);
            this.Loadout_Options_Info_Label.Name = "Loadout_Options_Info_Label";
            this.Loadout_Options_Info_Label.Size = new System.Drawing.Size(316, 37);
            this.Loadout_Options_Info_Label.TabIndex = 0;
            this.Loadout_Options_Info_Label.Text = "Loadout Options Info";
            // 
            // Loadout_Options_Info_Text
            // 
            this.Loadout_Options_Info_Text.Location = new System.Drawing.Point(55, 58);
            this.Loadout_Options_Info_Text.Name = "Loadout_Options_Info_Text";
            this.Loadout_Options_Info_Text.ReadOnly = true;
            this.Loadout_Options_Info_Text.Size = new System.Drawing.Size(470, 352);
            this.Loadout_Options_Info_Text.TabIndex = 1;
            this.Loadout_Options_Info_Text.Text = "";
            // 
            // Back_To_Previous
            // 
            this.Back_To_Previous.Location = new System.Drawing.Point(250, 427);
            this.Back_To_Previous.Name = "Back_To_Previous";
            this.Back_To_Previous.Size = new System.Drawing.Size(75, 23);
            this.Back_To_Previous.TabIndex = 2;
            this.Back_To_Previous.Text = "Back";
            this.Back_To_Previous.UseVisualStyleBackColor = true;
            this.Back_To_Previous.Click += new System.EventHandler(this.Back_To_Previous_Click);
            // 
            // LoadoutOptionsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Back_To_Previous);
            this.Controls.Add(this.Loadout_Options_Info_Text);
            this.Controls.Add(this.Loadout_Options_Info_Label);
            this.Name = "LoadoutOptionsInfo";
            this.Text = "LoadoutOptionsInfo";
            this.Load += new System.EventHandler(this.LoadoutOptionsInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loadout_Options_Info_Label;
        private System.Windows.Forms.RichTextBox Loadout_Options_Info_Text;
        private System.Windows.Forms.Button Back_To_Previous;
    }
}