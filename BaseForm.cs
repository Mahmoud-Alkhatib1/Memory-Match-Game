using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project
{
    public class BaseForm : Form
    {
        // ============================================
        // المتغيرات المشتركة
        // ============================================

        // المسارات
        protected string questionMarkPath = @"C:\Users\dell\source\repos\Project\Image\question-mark-96.png";
        protected string imagePath = "C:\\Users\\dell\\source\\repos\\Project\\Image\\";

        // الأزرار
        protected Button firstClicked = null;
        protected Button secondClicked = null;
        protected Button tempButton1 = null;
        protected Button tempButton2 = null;

        // القوائم
        protected List<Button> matchedPairs = new List<Button>();
        protected List<Button> allButtons = new List<Button>();
        // الحالة
        protected bool isWaiting = false;

        // عدد الأزواج للفوز
        protected int totalPairs = 0;

        // عداد الحياة والارواح
        protected int Lives = 5;
        protected PictureBox[] pbLives;




        //  Label المؤقت (protected - كل Form يعبيه)
        protected Label lblCountdown;

        // Timer المؤقت التنازلي
        protected Timer countdownTimer;
        protected int remainingSeconds = 0;




        // ============================================
        // الدوال المشتركة
        // ============================================


        // خلط الصور عشوائياً
        protected void ShuffleImages(List<string> images)
        {
            Random rand = new Random();
            for (int i = 0; i < images.Count * 10; i++)
            {
                int image1 = rand.Next(images.Count);
                int image2 = rand.Next(images.Count);
                string temp = images[image1];
                images[image1] = images[image2];
                images[image2] = temp;
            }
        }


        // عرض الصورة من الـ Tag
        protected void ShowImageFromTag(Button btn)
        {
            if (btn.Tag != null)
            {
                btn.BackColor = Color.White;
                btn.Image = Image.FromFile(imagePath + btn.Tag.ToString());
            }
        }

        protected void Restart(Button btn)
        {
            if (btn == null) return;

            btn.BackColor = Color.WhiteSmoke;
            btn.Image = Image.FromFile(questionMarkPath);
            //btn.Tag = null;//هون تعديل
        }

        protected bool IsValidClick(Button btn)
        {
            // 1. هل ننتظر المقارنة؟
            if (isWaiting)
                return false;

            // 2. هل الزر مطابق مسبقاً (في قائمة المتطابقين)؟
            if (matchedPairs.Contains(btn))
                return false;

            // 3. هل الزر هو نفس الزر الأول المضغوط؟
            if (btn == firstClicked)
                return false;

            return true;
        }

        // قلب جميع الأزرار لعلامة استفهام
        protected void FlipAllToQuestionMarks()
        {
            foreach (Button btn in allButtons)
            {
                Restart(btn);
            }

            firstClicked = null;
            secondClicked = null;
            isWaiting = false;
        }

        // مقارنة الزرين المضغوطين (افتراضية)
        protected virtual void CheckForMatch()
        {
            isWaiting = true;

            if (firstClicked.Image != null && secondClicked.Image != null)
            {
                if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
                {
                    // ✅ متطابقين
                    SoundHelper.PlayClick();  // 🔥 صوت التطابق

                    firstClicked.BackColor = Color.Green;
                    secondClicked.BackColor = Color.Green;
                    matchedPairs.Add(firstClicked);
                    matchedPairs.Add(secondClicked);

                    firstClicked = null;
                    secondClicked = null;
                    isWaiting = false;
                    CheckWin();
                }
                else
                {
                    // ❌ غير متطابقين
                    SoundHelper.PlayWrong();  // 🔥 صوت الخطأ
                    Lives--;

                    CheckLives();
                    firstClicked.BackColor = Color.Red;
                    secondClicked.BackColor = Color.Red;
                    tempButton1 = firstClicked;
                    tempButton2 = secondClicked;
                    firstClicked = null;
                    secondClicked = null;

                    // 🔥 استدعاء دالة مجردة (سنعدلها في كل Form)
                    StartHideTimer();
                }
            }
        }

        // دالة مجردة لتشغيل Timer (كل Form يعدلها)
        protected virtual void StartHideTimer()
        {
            // سيتم تعديلها في كل Form
        }

        protected virtual void CheckWin()
        {
            // فارغة - سيتم تعديلها في كل Form
        }

        protected virtual void CheckWrong()
        { 

        }

        protected virtual void CheckLives()
        {
            
        }


        // 🔥 تعبئة القلوب الحمراء
        protected void FillAllHearts()
        {
            if (pbLives == null) return;

            for (int i = 0; i < pbLives.Length; i++)
            {
                pbLives[i].Image = Image.FromFile(imagePath + "icons8_love.ico");
            }
        }

        // تعبئة القلوب حسب Lives
        protected void UpdateHearts()
        {
            if (pbLives == null) return;

            for (int i = 0; i < pbLives.Length; i++)
            {
                if (i < Lives)
                    pbLives[i].Image = Image.FromFile(imagePath + "icons8_love.ico");     // ❤️
                else
                    pbLives[i].Image = Image.FromFile(imagePath + "icons8_loveGrey.ico"); // 🖤
            }
        }


        // ============================================
        // تشغيل المؤقت التنازلي
        // ============================================
        protected void StartCountdown(int seconds)
        {
            remainingSeconds = seconds;
            UpdateCountdownDisplay();

            if (countdownTimer == null)
            {
                countdownTimer = new Timer();
                countdownTimer.Interval = 1000;
                countdownTimer.Tick += CountdownTimer_Tick;
            }

            countdownTimer.Start();
        }

        // ============================================
        // Tick المؤقت
        // ============================================
        protected void CountdownTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;

            if (remainingSeconds <= 0)
            {
                countdownTimer.Stop();
                return;
            }

            UpdateCountdownDisplay();
        }

        // ============================================
        // تحديث عرض المؤقت
        // ============================================
        protected void UpdateCountdownDisplay()
        {
            if (lblCountdown == null) return;

            if (remainingSeconds > 0)
            {
                int minutes = remainingSeconds / 60;
                int seconds = remainingSeconds % 60;
                lblCountdown.Text = $"⏱️ {minutes:00}:{seconds:00}";
                lblCountdown.Visible = true;
            }
        }

        // ============================================
        // إيقاف المؤقت
        // ============================================
        protected void StopCountdown()
        {
            if (countdownTimer != null)
                countdownTimer.Stop();

            if (lblCountdown != null)
            {
                lblCountdown.Text = "";
                lblCountdown.Visible = false;
            }
        }

        protected void AssignImagesToButtons(List<string> shuffledImages)
        {
            for (int i = 0; i < allButtons.Count; i++)
            {
                allButtons[i].Tag = shuffledImages[i];
                allButtons[i].Image = Image.FromFile(imagePath + shuffledImages[i]);
                allButtons[i].BackColor = Color.White;
            }
        }

        public void MemoryPicture(object sender, EventArgs e)
        {
            foreach (Button btn in allButtons)
            {
                ShowImageFromTag(btn);
            }
        }

    }
}

