using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project
{
    public static class SoundHelper
    {
        // ============================================
        // تشغيل صوت
        // ============================================
        private static void PlaySound(string soundFileName)
        {
            try
            {
                string soundPath = Application.StartupPath + "\\Sound\\" + soundFileName;

                if (System.IO.File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.Play();
                }
            }
            catch
            {
                // تجاهل الأخطاء
            }
        }

        public static void PlayCorrect()
        {
            PlaySound("correct.wav");
        }

        public static void PlayWrong()
        {
            PlaySound("wrong.wav");
        }

        public static void PlayWin()
        {
            PlaySound("win.wav");
        }

        public static void PlayClick()
        {
            PlaySound("click.wav");
        }

        public static void PlayStart()
        {
            PlaySound("Start.wav");
        }

        public static void PlayGameOver()
        {
            PlaySound("GameOver.wav");
        }

    }
}
