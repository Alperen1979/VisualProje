using System;
using System.Windows.Forms;

namespace WindowsFormsApp1_Aleatorio
{
    public partial class Form1 : Form
    {
        int vAleat1 = 0, vAleat2 = 0, vAleat3 = 0;
        int num1, num2, num3;
        int i = 1, j = 1, k = 1;
        int totalMoney = 0; // Para sayacı

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonONOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
            timer1.Start();
            timer2.Start();
            timer3.Start();

            Random aleat1 = new Random();
            num1 = aleat1.Next(15) + 10;
            num2 = aleat1.Next(15) + 40;
            num3 = aleat1.Next(15) + 70;

            totalMoney = 1000; // Başlangıç parası
            labelMoney.Text = "$" + totalMoney;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Random aleat1 = new Random();
            vAleat1 = aleat1.Next(15);
            SetFruitImage(vAleat1, pictureBoxFrutas1);

            vAleat2 = aleat1.Next(15);
            SetFruitImage(vAleat2, pictureBoxFrutas2);

            vAleat3 = aleat1.Next(15);
            SetFruitImage(vAleat3, pictureBoxFrutas3);

            // Para ekleme ve kaybetme kontrolü
            if (vAleat1 == vAleat2 && vAleat2 == vAleat3)
            {
                totalMoney += 10; // 10 dolar ekleme
                labelMoney.Text = "$" + totalMoney;
            }
            else
            {
                totalMoney -= 5; // 5 dolar çıkarma
                if (totalMoney < 0)
                {
                    totalMoney = 0; // Para 0'ın altına düşmesin
                    MessageBox.Show("Maalesef paranız bitti!"); // Uyarı
                }
                labelMoney.Text = "$" + totalMoney;
            }
        }

        private void buttonGuaranteeWin_Click_1(object sender, EventArgs e)
        {

            // Garanti kazanç
            vAleat1 = vAleat2 = vAleat3 = 0; // Tüm slotları aynı yapar
            SetFruitImage(vAleat1, pictureBoxFrutas1);
            SetFruitImage(vAleat2, pictureBoxFrutas2);
            SetFruitImage(vAleat3, pictureBoxFrutas3);

            totalMoney += 10;
            labelMoney.Text = "$" + totalMoney;
        }

        private void SetFruitImage(int value, PictureBox pictureBox)
        {
            switch (value)
            {
                case 0:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._1_Banana;
                    break;
                case 1:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._2_Cereza;
                    break;
                case 2:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._3_Fresa;
                    break;
                case 3:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._4_Pera;
                    break;
                case 4:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._5_Mora;
                    break;
                case 5:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._6_Granada;
                    break;
                case 6:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._7_Papaya;
                    break;
                case 7:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._8_Sandia;
                    break;
                case 8:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._9_Melon;
                    break;
                case 9:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._10_Coco;
                    break;
                case 10:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._11_Mango;
                    break;
                case 11:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._12_Pina;
                    break;
                case 12:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._13_Guayaba;
                    break;
                case 13:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._14_Guanabana;
                    break;
                case 14:
                    pictureBox.Image = WindowsFormsApp1_Aleatorio.Properties.Resources._15_Palta;
                    break;
            }
        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= num1)
                i++;
            else
                i = 1;
            if (i == num1) timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (j <= num2)
                j++;
            else
                j = 1;
            if (j == num2) timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (k <= num3)
                k++;
            else
                k = 1;
            if (k == num3) timer3.Stop();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
    }
}
