namespace Project
{
    partial class FormEasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEasy));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblResultAnswer = new System.Windows.Forms.Label();
            this.btnRestart1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbLife1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbLife2 = new System.Windows.Forms.PictureBox();
            this.pbLife3 = new System.Windows.Forms.PictureBox();
            this.pbLife4 = new System.Windows.Forms.PictureBox();
            this.pbLife5 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 462);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Answer : ";
            // 
            // lblResultAnswer
            // 
            this.lblResultAnswer.AutoSize = true;
            this.lblResultAnswer.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAnswer.Location = new System.Drawing.Point(56, 505);
            this.lblResultAnswer.Name = "lblResultAnswer";
            this.lblResultAnswer.Size = new System.Drawing.Size(0, 33);
            this.lblResultAnswer.TabIndex = 7;
            // 
            // btnRestart1
            // 
            this.btnRestart1.Location = new System.Drawing.Point(691, 473);
            this.btnRestart1.Name = "btnRestart1";
            this.btnRestart1.Size = new System.Drawing.Size(90, 52);
            this.btnRestart1.TabIndex = 9;
            this.btnRestart1.Text = "Restart";
            this.btnRestart1.UseVisualStyleBackColor = true;
            this.btnRestart1.Click += new System.EventHandler(this.btnRestart1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(583, 473);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 52);
            this.button8.TabIndex = 10;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lives :";
            // 
            // pbLife1
            // 
            this.pbLife1.Image = global::Project.Properties.Resources.icons8_love_32;
            this.pbLife1.Location = new System.Drawing.Point(104, 3);
            this.pbLife1.Name = "pbLife1";
            this.pbLife1.Size = new System.Drawing.Size(23, 35);
            this.pbLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife1.TabIndex = 12;
            this.pbLife1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(541, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 197);
            this.button6.TabIndex = 5;
            this.button6.Tag = "2";
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(282, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 197);
            this.button5.TabIndex = 4;
            this.button5.Tag = "1";
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(20, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 197);
            this.button4.TabIndex = 3;
            this.button4.Tag = "3";
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(541, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 197);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(282, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 197);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(20, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 197);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbLife2
            // 
            this.pbLife2.Image = global::Project.Properties.Resources.icons8_love_32;
            this.pbLife2.Location = new System.Drawing.Point(133, 3);
            this.pbLife2.Name = "pbLife2";
            this.pbLife2.Size = new System.Drawing.Size(23, 35);
            this.pbLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife2.TabIndex = 13;
            this.pbLife2.TabStop = false;
            // 
            // pbLife3
            // 
            this.pbLife3.Image = global::Project.Properties.Resources.icons8_love_32;
            this.pbLife3.Location = new System.Drawing.Point(162, 3);
            this.pbLife3.Name = "pbLife3";
            this.pbLife3.Size = new System.Drawing.Size(23, 35);
            this.pbLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife3.TabIndex = 14;
            this.pbLife3.TabStop = false;
            // 
            // pbLife4
            // 
            this.pbLife4.Image = global::Project.Properties.Resources.icons8_love_32;
            this.pbLife4.Location = new System.Drawing.Point(191, 3);
            this.pbLife4.Name = "pbLife4";
            this.pbLife4.Size = new System.Drawing.Size(23, 35);
            this.pbLife4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife4.TabIndex = 15;
            this.pbLife4.TabStop = false;
            // 
            // pbLife5
            // 
            this.pbLife5.Image = global::Project.Properties.Resources.icons8_love_32;
            this.pbLife5.Location = new System.Drawing.Point(220, 3);
            this.pbLife5.Name = "pbLife5";
            this.pbLife5.Size = new System.Drawing.Size(23, 35);
            this.pbLife5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLife5.TabIndex = 16;
            this.pbLife5.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 200000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblCountdown1
            // 
            this.lblCountdown1.AutoSize = true;
            this.lblCountdown1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCountdown1.Location = new System.Drawing.Point(677, 10);
            this.lblCountdown1.Name = "lblCountdown1";
            this.lblCountdown1.Size = new System.Drawing.Size(46, 23);
            this.lblCountdown1.TabIndex = 18;
            this.lblCountdown1.Text = "___";
            this.lblCountdown1.Visible = false;
            // 
            // FormEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 550);
            this.Controls.Add(this.lblCountdown1);
            this.Controls.Add(this.pbLife5);
            this.Controls.Add(this.pbLife4);
            this.Controls.Add(this.pbLife3);
            this.Controls.Add(this.pbLife2);
            this.Controls.Add(this.pbLife1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnRestart1);
            this.Controls.Add(this.lblResultAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormEasy";
            this.Text = "FormEasy";
            this.Load += new System.EventHandler(this.FormEasy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblResultAnswer;
        private System.Windows.Forms.Button btnRestart1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLife1;
        private System.Windows.Forms.PictureBox pbLife2;
        private System.Windows.Forms.PictureBox pbLife3;
        private System.Windows.Forms.PictureBox pbLife4;
        private System.Windows.Forms.PictureBox pbLife5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblCountdown1;

    }
}