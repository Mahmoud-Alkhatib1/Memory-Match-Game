using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormInterMediate : BaseForm
    {
        public FormInterMediate()
        {
            InitializeComponent();
        }

        // ============================================
        // توزيع الصور
        // ============================================

        private void DistributeImages()
        {
            List<string> images = new List<string>()
            {
                "icons8_pineapple.ico",
                "icons8_pineapple.ico",
                "icons8_laptop_64.png",
                "icons8_laptop_64.png",
                "icons8_green_apple_64.png",
                "icons8_green_apple_64.png",
                "icons8_avocado_64.png",
                "icons8_avocado_64.png",
                "icons8_red_apple_64.png",
                "icons8_red_apple_64.png",
                "icons8_hot_pepper.ico",
                "icons8_hot_pepper.ico"
            };

            ShuffleImages(images);
            AssignImagesToButtons(images);
        }

        // ============================================
        // دوال الأزرار (1 - 12)
        // ============================================
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button1))
                return;

            button1.BackColor = Color.White;
            button1.Image = Image.FromFile(imagePath + button1.Tag);

            if (firstClicked == null)
                firstClicked = button1;
            else
            {
                secondClicked = button1;
                CheckForMatch();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button2))
                return;

            button2.BackColor = Color.White;
            button2.Image = Image.FromFile(imagePath + button2.Tag);

            if (firstClicked == null)
                firstClicked = button2;
            else
            {
                secondClicked = button2;
                CheckForMatch();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button3))
                return;

            button3.BackColor = Color.White;
            button3.Image = Image.FromFile(imagePath + button3.Tag);

            if (firstClicked == null)
                firstClicked = button3;
            else
            {
                secondClicked = button3;
                CheckForMatch();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button4))
                return;

            button4.BackColor = Color.White;
            button4.Image = Image.FromFile(imagePath + button4.Tag);

            if (firstClicked == null)
                firstClicked = button4;
            else
            {
                secondClicked = button4;
                CheckForMatch();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button5))
                return;

            button5.BackColor = Color.White;
            button5.Image = Image.FromFile(imagePath + button5.Tag);

            if (firstClicked == null)
                firstClicked = button5;
            else
            {
                secondClicked = button5;
                CheckForMatch();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button6))
                return;

            button6.BackColor = Color.White;
            button6.Image = Image.FromFile(imagePath + button6.Tag);

            if (firstClicked == null)
                firstClicked = button6;
            else
            {
                secondClicked = button6;
                CheckForMatch();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button7))
                return;

            button7.BackColor = Color.White;
            button7.Image = Image.FromFile(imagePath + button7.Tag);

            if (firstClicked == null)
                firstClicked = button7;
            else
            {
                secondClicked = button7;
                CheckForMatch();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button8))
                return;

            button8.BackColor = Color.White;
            button8.Image = Image.FromFile(imagePath + button8.Tag);

            if (firstClicked == null)
                firstClicked = button8;
            else
            {
                secondClicked = button8;
                CheckForMatch();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button9))
                return;

            button9.BackColor = Color.White;
            button9.Image = Image.FromFile(imagePath + button9.Tag);

            if (firstClicked == null)
                firstClicked = button9;
            else
            {
                secondClicked = button9;
                CheckForMatch();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button10))
                return;

            button10.BackColor = Color.White;
            button10.Image = Image.FromFile(imagePath + button10.Tag);

            if (firstClicked == null)
                firstClicked = button10;
            else
            {
                secondClicked = button10;
                CheckForMatch();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button11))
                return;

            button11.BackColor = Color.White;
            button11.Image = Image.FromFile(imagePath + button11.Tag);

            if (firstClicked == null)
                firstClicked = button11;
            else
            {
                secondClicked = button11;
                CheckForMatch();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button12))
                return;

            button12.BackColor = Color.White;
            button12.Image = Image.FromFile(imagePath + button12.Tag);

            if (firstClicked == null)
                firstClicked = button12;
            else
            {
                secondClicked = button12;
                CheckForMatch();
            }
        }

        // ============================================
        // زر Back
        // ============================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================================
        // زر Restart
        // ============================================
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            matchedPairs.Clear();

            isWaiting = true;
            firstClicked = null;
            secondClicked = null;
            lblResultAnswer.Text = "";
            lblResultAnswer.Visible = false;

            DistributeImages();  
            MemoryPicture(sender, e);
            timer1.Enabled = true;

            isWaiting = true;
        }

        // ============================================
        // أحداث الفورم
        // ============================================
        private void FormInterMediate_Load(object sender, EventArgs e)
        {
            lblCountdown = lblCountdown1;  


            if (lblCountdown != null)
            {
                lblCountdown.Text = "";
                lblCountdown.Visible = false;
            }

            pbLives = new PictureBox[] { pbLife1, pbLife2, pbLife3, pbLife4, pbLife5 };

            allButtons = new List<Button>()
            {
                button1, button2, button3, button4, button5, button6,
                button7, button8, button9, button10, button11, button12
            };

            // عدد الأزواج للفوز
            totalPairs = 6;

            // توزيع الصور
            DistributeImages();

            timer1.Interval = 2000;
            MemoryPicture(sender, e);
            timer1.Enabled = true;

            isWaiting = true;
        }

        // ============================================
        // دوال الـ Timer
        // ============================================
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FlipAllToQuestionMarks();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            Restart(tempButton1);
            Restart(tempButton2);

            tempButton1 = null;
            tempButton2 = null;
            isWaiting = false;
        }

        // ============================================
        // Override الدوال الافتراضية
        // ============================================
        protected override void StartHideTimer()
        {
            timer2.Enabled = true;
        }

        protected override void CheckWin()
        {
            if (matchedPairs.Count == 12)
            {
                SoundHelper.PlayWin();  
                lblResultAnswer.Text = "🎉 مبرووووك لقد فزت! 🎉";
                lblResultAnswer.ForeColor = Color.Black;
                lblResultAnswer.Visible = true;
            }
        }

        protected override void CheckLives()
        {
            if (Lives == 0)
            {
                CheckWrong();
                return;
            }

            UpdateHearts();

            int seconds = 0;

            if (Lives == 1) seconds = 150;
            else if (Lives == 2) seconds = 100;
            else if (Lives == 3) seconds = 75;
            else if (Lives == 4) seconds = 50;

            timer3.Interval = seconds * 1000;

            timer3.Enabled = true;


            StartCountdown(seconds);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;


            StopCountdown();

            buttonRestart_Click(sender, e);
            
            Lives = 5;
            FillAllHearts();  


            foreach (Button btn in allButtons)
                btn.Enabled = true;

            lblResultAnswer.Text = "";
            lblResultAnswer.Visible = false;
            buttonRestart.Enabled = true;
        }

        protected override void CheckWrong()
        {
            for (int i = 0; i < pbLives.Length; i++)
                pbLives[i].Image = Image.FromFile(imagePath + "icons8_loveGrey.ico");


            foreach (Button btn in allButtons)
                btn.Enabled = false;

            SoundHelper.PlayGameOver();
            lblResultAnswer.Text = "Game Over!";
            lblResultAnswer.ForeColor = Color.Black;
            buttonRestart.Enabled = false;
            lblResultAnswer.Visible = true;

            timer3.Enabled = true;
        }

    }
}