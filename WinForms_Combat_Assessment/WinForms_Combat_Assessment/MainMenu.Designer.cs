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
            this.got_to_rules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // got_to_rules
            // 
            this.got_to_rules.Location = new System.Drawing.Point(102, 112);
            this.got_to_rules.Name = "got_to_rules";
            this.got_to_rules.Size = new System.Drawing.Size(75, 23);
            this.got_to_rules.TabIndex = 0;
            this.got_to_rules.Text = "go to rules";
            this.got_to_rules.UseVisualStyleBackColor = true;
            this.got_to_rules.Click += new System.EventHandler(this.got_to_rules_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.got_to_rules);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button got_to_rules;
    }
}