﻿namespace PsychometricTest
{
    partial class Test3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test3));
            this.button1 = new System.Windows.Forms.Button();
            this.test3Label = new System.Windows.Forms.Label();
            this.startButtonTest3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(147, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.alarmButton_Clicked);
            // 
            // test3Label
            // 
            this.test3Label.BackColor = System.Drawing.Color.Transparent;
            this.test3Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test3Label.Location = new System.Drawing.Point(13, 13);
            this.test3Label.Name = "test3Label";
            this.test3Label.Size = new System.Drawing.Size(376, 103);
            this.test3Label.TabIndex = 1;
            this.test3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButtonTest3
            // 
            this.startButtonTest3.BackColor = System.Drawing.Color.Green;
            this.startButtonTest3.Location = new System.Drawing.Point(300, 131);
            this.startButtonTest3.Name = "startButtonTest3";
            this.startButtonTest3.Size = new System.Drawing.Size(89, 36);
            this.startButtonTest3.TabIndex = 2;
            this.startButtonTest3.Text = "Start";
            this.startButtonTest3.UseVisualStyleBackColor = false;
            this.startButtonTest3.Click += new System.EventHandler(this.onStart_Click);
            // 
            // Test3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(401, 355);
            this.Controls.Add(this.startButtonTest3);
            this.Controls.Add(this.test3Label);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test3";
            this.Text = "Test3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test3Label;
        private System.Windows.Forms.Button startButtonTest3;
    }
}