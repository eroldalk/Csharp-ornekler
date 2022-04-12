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
       
    }
}
