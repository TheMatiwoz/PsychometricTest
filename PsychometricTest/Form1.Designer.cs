namespace PsychometricTest
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTworcachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.test1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "TEST 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.test2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(729, 80);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "TEST 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.test3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 265);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 80);
            this.button4.TabIndex = 3;
            this.button4.Text = "WYNIKI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.results_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProjekcieToolStripMenuItem,
            this.oTworcachToolStripMenuItem,
            this.wyjdzToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // oProjekcieToolStripMenuItem
            // 
            this.oProjekcieToolStripMenuItem.Name = "oProjekcieToolStripMenuItem";
            this.oProjekcieToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.oProjekcieToolStripMenuItem.Text = "O projekcie";
            this.oProjekcieToolStripMenuItem.Click += new System.EventHandler(this.oProjekcieToolStripMenuItem_Click);
            // 
            // oTworcachToolStripMenuItem
            // 
            this.oTworcachToolStripMenuItem.Name = "oTworcachToolStripMenuItem";
            this.oTworcachToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.oTworcachToolStripMenuItem.Text = "O tworcach";
            this.oTworcachToolStripMenuItem.Click += new System.EventHandler(this.oTworcachToolStripMenuItem_Click);
            // 
            // wyjdzToolStripMenuItem
            // 
            this.wyjdzToolStripMenuItem.Name = "wyjdzToolStripMenuItem";
            this.wyjdzToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.wyjdzToolStripMenuItem.Text = "Wyjdz";
            this.wyjdzToolStripMenuItem.Click += new System.EventHandler(this.wyjdzToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 459);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProjekcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTworcachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdzToolStripMenuItem;
    }
}

