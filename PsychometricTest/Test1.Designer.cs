namespace PsychometricTest
{
    partial class Test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test1));
            this.gaz = new System.Windows.Forms.Button();
            this.hamulec = new System.Windows.Forms.Button();
            this.test1DescriptionLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new PsychometricTest.RoundButton();
            this.pictureBox2 = new PsychometricTest.RoundButton();
            this.pictureBox1 = new PsychometricTest.RoundButton();
            this.SuspendLayout();
            // 
            // gaz
            // 
            this.gaz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gaz.Location = new System.Drawing.Point(44, 398);
            this.gaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gaz.Name = "gaz";
            this.gaz.Size = new System.Drawing.Size(240, 160);
            this.gaz.TabIndex = 3;
            this.gaz.Text = "GAZ";
            this.gaz.UseVisualStyleBackColor = false;
            this.gaz.Click += new System.EventHandler(this.gas_Click);
            // 
            // hamulec
            // 
            this.hamulec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hamulec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hamulec.Location = new System.Drawing.Point(372, 398);
            this.hamulec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hamulec.Name = "hamulec";
            this.hamulec.Size = new System.Drawing.Size(240, 160);
            this.hamulec.TabIndex = 4;
            this.hamulec.Text = "HAMULEC";
            this.hamulec.UseVisualStyleBackColor = false;
            this.hamulec.Click += new System.EventHandler(this.brake_Click);
            // 
            // test1DescriptionLabel
            // 
            this.test1DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.test1DescriptionLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test1DescriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.test1DescriptionLabel.Name = "test1DescriptionLabel";
            this.test1DescriptionLabel.Size = new System.Drawing.Size(647, 110);
            this.test1DescriptionLabel.TabIndex = 8;
            this.test1DescriptionLabel.Text = "label1";
            this.test1DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Green;
            this.startButton.Location = new System.Drawing.Point(568, 115);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(92, 49);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startTrial_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(294, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 75);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(294, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 75);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(294, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.UseVisualStyleBackColor = false;
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsychometricTest.Properties.Resources.checkedBackground;
            this.ClientSize = new System.Drawing.Size(666, 588);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.test1DescriptionLabel);
            this.Controls.Add(this.hamulec);
            this.Controls.Add(this.gaz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Test1";
            this.Text = "Test1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gaz;
        private System.Windows.Forms.Button hamulec;
        private System.Windows.Forms.Label test1DescriptionLabel;
        private System.Windows.Forms.Button startButton;
        private RoundButton pictureBox1;
        private RoundButton pictureBox2;
        private RoundButton pictureBox3;
    }
}