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
    public partial class FormEasy : BaseForm
    {
        private void DistributeImages()
        {
            List<string> images = new List<string>()
            {
                "icons8_pineapple.ico",
                "icons8_pineapple.ico",
                "icons8_laptop_64.png",
                "icons8_laptop_64.png",
                "icons8_green_apple_64.png",
                "icons8_green_apple_64.png"
            };

            ShuffleImages(images);

            AssignImagesToButtons(images);
        }

        public FormEasy()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidClick(button1))
                return;

            button1.BackColor = Color.White;
            button1.Image = Image.FromFile(imagePath + button1.Tag);  // استخدم الـ Tag

            if (firstClicked == null)
            {
                firstClicked = button1;
            }
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
            {
                firstClicked = button2;
            }
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
            {
                firstClicked = button3;
            }
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
            {
                firstClicked = button4;
            }
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
            {
                firstClicked = button5;
            }
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
            {
                firstClicked = button6;
            }
            else
            {
                secondClicked = button6;
                CheckForMatch();
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart1_Click(object sender, EventArgs e)
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

        private void FormEasy_Load(object sender, EventArgs e)
        {

            lblCountdown = lblCountdown1;  

            if (lblCountdown != null)
            {
                lblCountdown.Text = "";
                lblCountdown.Visible = false;
            }


            pbLives = new PictureBox[] { pbLife1, pbLife2, pbLife3, pbLife4, pbLife5 };
            
            allButtons = new List<Button>() { button1, button2, button3, button4, button5, button6 };

            DistributeImages();

            timer1.Interval = 2000;
            MemoryPicture(sender, e);
            timer1.Enabled = true;

            isWaiting = true;
        }

        protected override void StartHideTimer()
        {
            timer2.Enabled = true;  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            FlipAllToQuestionMarks();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Enabled = false;

            Restart(tempButton1);
            Restart(tempButton2);

            // تنظيف المتغيرات المؤقتة
            tempButton1 = null;
            tempButton2 = null;

            // اسمح للمستخدم بالضغط مجدداً
            isWaiting = false;
        }

        // دالة التحقق من الفوز
        protected override void CheckWin()
        {
            if (matchedPairs.Count == 6) 
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

            btnRestart1_Click(sender,e);

            Lives = 5;
            FillAllHearts(); 


            foreach (Button btn in allButtons)
                btn.Enabled = true;

            lblResultAnswer.Text = "";
            lblResultAnswer.Visible = false;
            btnRestart1.Enabled = true;
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
            btnRestart1.Enabled = false;
            lblResultAnswer.Visible = true;

            timer3.Enabled = true;
        }
    }
}
