using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Yarışı_2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SeritSayisi = 1;
        Random R = new Random();

        private void AracYerine()
        {
            if(SeritSayisi == 1)
            {
                RedCar.Location = new Point(200, 343);
            }
            else if (SeritSayisi == 0)
            {
                RedCar.Location = new Point(60, 343);
            }
            else if (SeritSayisi == 2)
            {
                RedCar.Location = new Point(400, 343);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (SeritSayisi < 2) 
                    SeritSayisi++;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if(SeritSayisi > 0)
                    SeritSayisi--;
            }
            AracYerine();
        }

        private void RandomMusicEkle()
        {
            int MuzikDeger = R.Next(1, 4);

            axWindowsMediaPlayer1.URL = @"music/track" + MuzikDeger.ToString() + ".mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AracYerine();
            RandomMusicEkle();
        }

        bool SesKontrol = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SesKontrol == true)
            {
                SesKontrol = false;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pictureBox2.Image = Properties.Resources.volumeOff;
            }
            else if (SesKontrol == false)
            {
                SesKontrol = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Image = Properties.Resources.volumeON;
            }
        }

        bool SeritHareket = false;

        private void timerSerit_Tick(object sender, EventArgs e)
        {

            if(SeritHareket == false)
            {
                for (int i = 1; i < 6; i++)
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top -= 25;
                    this.Controls.Find("labelSagSerit" + i.ToString(), true)[0].Top -= 25;
                    SeritHareket = true;
                }
            }
            else
            {
                for (int i = 1; i < 6; i++)
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top += 25;
                    this.Controls.Find("labelSagSerit" + i.ToString(), true)[0].Top += 25;
                    SeritHareket = false;
                }
            }
        }
    }
}
