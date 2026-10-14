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
    public partial class Form1 : Form
    {
        // ============================================
        // المتغيرات
        // ============================================
        private Timer loadingTimer;
        private int progressValue = 0;
        private Form targetForm = null;

        // ============================================
        // Constructor
        // ============================================
        public Form1()
        {
            InitializeComponent();
        }

        // ============================================
        // Form Load
        // ============================================
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundHelper.PlayStart(); 
            progressBar1.Visible = false;
            lblLoading.Visible = false;
            lbl0.Visible = false;

            lblLoading.AutoSize = false;
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            lblLoading.Size = new Size(100, 25);
        }

        // ============================================
        // دوال التحميل
        // ============================================
        private void StartLoading(Form form)
        {
            targetForm = form;
            progressValue = 0;

            // إظهار عناصر التحميل
            progressBar1.Visible = true;
            lblLoading.Visible = true;
            lbl0.Visible = true;

            // جعلها في المقدمة
            lblLoading.BringToFront();
            lbl0.BringToFront();
            progressBar1.BringToFront();

            // تهيئة الـ ProgressBar
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            // إنشاء Timer
            loadingTimer = new Timer();
            loadingTimer.Interval = 500;
            loadingTimer.Tick += LoadingTimer_Tick;
            loadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {

                progressValue += 10;

                progressBar1.Value = progressValue;

                lbl0.Text = progressValue + "%";

                string[] loadingTexts = { "Loading   ", "Loading.  ", "Loading.. ", "Loading..." };
                int index = (progressValue / 10) % 4;
                lblLoading.Text = loadingTexts[index];
            }
            else
            {
                loadingTimer.Stop();
                loadingTimer.Dispose();

                progressBar1.Visible = false;
                lblLoading.Visible = false;
                lbl0.Visible = false;

                this.Refresh();

                this.BeginInvoke(new Action(() =>
                {
                    if (targetForm != null)
                    {
                        targetForm.ShowDialog();
                    }
                }));
            }
        }

        // ============================================
        // دوال الأزرار
        // ============================================
        private void btnEasy_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayCorrect(); 
            StartLoading(new FormEasy());
        }
        
        private void btnInterMediate_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayCorrect();   
            StartLoading(new FormInterMediate());
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayCorrect();  
            StartLoading(new FormHard());
        }
    }
}