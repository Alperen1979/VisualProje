using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace VisiaulLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BlackJack uygulamasını çalıştırmak için doğru bir dosya yolu belirtildi
            System.Diagnostics.Process.Start(@"C:\Users\immor\Desktop\VisiualProjee\BlackJack-main\Blackjack\Blackjack\bin\Debug\Blackjack.exe");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            // WindowsFormsApp1_Aleatorio uygulamasını çalıştırmak için doğru bir dosya yolu belirtildi
            System.Diagnostics.Process.Start(@"C:\Users\immor\Desktop\VisiualProjee\WindowsFormsApp_Aleatorio-master\WindowsFormsApp1_Aleatorio\bin\Debug\WindowsFormsApp1_Aleatorio.exe");
        }

      
    }
}
