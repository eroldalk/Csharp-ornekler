using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X___O___X
{
    public partial class Form1 : Form
    {
        bool X_Sıra;
        bool O_Sıra;

        int işlem_Sayısı = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void X_Belirle()
        {
            //yatay başlangıç 

            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            if (b3.Text == "X" && b5.Text == "X" && b6.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            if (b7.Text == "X" && b8.Text == "X" && b9.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            // YATAY BİTİŞ

            // Dikey Başlangıç

            if (b1.Text == "X" && b4.Text == "X" && b7.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            if (b2.Text == "X" && b5.Text == "X" && b8.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            if (b3.Text == "X" && b6.Text == "X" && b9.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            // Dikey bitiş 

            // Çapraz Başlangıç

            if (b1.Text == "X" && b5.Text == "X" && b9.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }

            if (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
            {
                Temizle();
                MessageBox.Show("X kazandı,", "Tebrikler, X!");
            }


            // çapraz bitiş
        }



        public void O_Belirle()
        {
            //yatay başlangıç 

            if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            if (b3.Text == "O" && b5.Text == "O" && b6.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            if (b7.Text == "O" && b8.Text == "O" && b9.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            // YATAY BİTİŞ

            // Dikey Başlangıç

            if (b1.Text == "O" && b4.Text == "O" && b7.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            if (b2.Text == "O" && b5.Text == "O" && b8.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            if (b3.Text == "O" && b6.Text == "O" && b9.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            // Dikey bitiş 

            // Çapraz Başlangıç

            if (b1.Text == "O" && b5.Text == "O" && b9.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }

            if (b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
            {
                Temizle();
                MessageBox.Show("O kazandı,", "Tebrikler, O!");
            }


            // çapraz bitiş
        }

        public void Temizle()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";


            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;

            işlem_Sayısı = 0;
        }


        public void Beraberlik()
        {
            if(işlem_Sayısı == 9)
            {
                Temizle();
                MessageBox.Show("Berabere bitti", "beraberlik...");
            }

        }

        private void Toplu_Tık(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            işlem_Sayısı = işlem_Sayısı + 1;

            if(X_Sıra)
            {
                X_Sıra = false;
                O_Sıra = true;

                b.Text = "X";
                b.Enabled = false;

                X_Belirle();
                Beraberlik();

            }

            else if (O_Sıra)
            {
                X_Sıra = true;
                O_Sıra = false;

                b.Text = "0";
                b.Enabled = false;

                O_Belirle();
                Beraberlik();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X_Sıra = true;
        }
    }
}


