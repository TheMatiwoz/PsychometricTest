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
            this.gaz = new System.Windows.Forms.Button();
            this.hamulec = new System.Windows.Forms.Button();
            this.test1DescriptionLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new PsychometricTest.RoundButton();
            this.pictureBox2 = new PsychometricTest.RoundButton();
            this.roundButton3 = new PsychometricTest.RoundButton();
            this.SuspendLayout();
            // 
            // gaz
            // 
            this.gaz.Location = new System.Drawing.Point(55, 379);
            this.gaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gaz.Name = "gaz";
            this.gaz.Size = new System.Drawing.Size(242, 159);
            this.gaz.TabIndex = 3;
            this.gaz.Text = "GAZ";
            this.gaz.UseVisualStyleBackColor = true;
            this.gaz.Click += new System.EventHandler(this.gas_Click);
            // 
            // hamulec
            // 
            this.hamulec.Location = new System.Drawing.Point(370, 379);
            this.hamulec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hamulec.Name = "hamulec";
            this.hamulec.Size = new System.Drawing.Size(244, 159);
            this.hamulec.TabIndex = 4;
            this.hamulec.Text = "HAMULEC";
            this.hamulec.UseVisualStyleBackColor = true;
            this.hamulec.Click += new System.EventHandler(this.brake_Click);
            // 
            // test1DescriptionLabel
            // 
            this.test1DescriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.test1DescriptionLabel.Name = "test1DescriptionLabel";
            this.test1DescriptionLabel.Size = new System.Drawing.Size(645, 68);
            this.test1DescriptionLabel.TabIndex = 8;
            this.test1DescriptionLabel.Text = "label1";
            this.test1DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Green;
            this.startButton.Location = new System.Drawing.Point(586, 105);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 35);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startTrial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(294, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(294, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 75);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Black;
            this.roundButton3.Location = new System.Drawing.Point(294, 267);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(80, 75);
            this.roundButton3.TabIndex = 16;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 590);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.test1DescriptionLabel);
            this.Controls.Add(this.hamulec);
            this.Controls.Add(this.gaz);
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
        private RoundButton roundButton3;
    }
}