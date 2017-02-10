namespace WinForms_Combat_Assessment
{
    partial class DiceRoll
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
            this.Dice_Roll_Label = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.To_Main_Menu = new System.Windows.Forms.Button();
            this.Roll = new System.Windows.Forms.Button();
            this.Turn_Order_Box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Dice_Roll_Label
            // 
            this.Dice_Roll_Label.AutoSize = true;
            this.Dice_Roll_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice_Roll_Label.Location = new System.Drawing.Point(229, 9);
            this.Dice_Roll_Label.Name = "Dice_Roll_Label";
            this.Dice_Roll_Label.Size = new System.Drawing.Size(143, 37);
            this.Dice_Roll_Label.TabIndex = 0;
            this.Dice_Roll_Label.Text = "Dice Roll";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(497, 427);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
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
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(255, 427);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(75, 23);
            this.Roll.TabIndex = 3;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // Turn_Order_Box
            // 
            this.Turn_Order_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn_Order_Box.Location = new System.Drawing.Point(199, 49);
            this.Turn_Order_Box.Name = "Turn_Order_Box";
            this.Turn_Order_Box.ReadOnly = true;
            this.Turn_Order_Box.Size = new System.Drawing.Size(187, 372);
            this.Turn_Order_Box.TabIndex = 4;
            this.Turn_Order_Box.Text = "";
            this.Turn_Order_Box.WordWrap = false;
            // 
            // DiceRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.Turn_Order_Box);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.To_Main_Menu);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Dice_Roll_Label);
            this.Name = "DiceRoll";
            this.Text = "DiceRoll";
            this.Load += new System.EventHandler(this.DiceRoll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dice_Roll_Label;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button To_Main_Menu;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.RichTextBox Turn_Order_Box;
    }
}