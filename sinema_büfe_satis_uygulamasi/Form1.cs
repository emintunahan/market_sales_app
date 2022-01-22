using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satis_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam, misir, cay, su, bilet;
            misir = 4;
            su = 1;
            cay = 2;
            bilet = 6;
            toplam = (misir * Convert.ToInt32(maskedTextBox1.Text)) + (su * Convert.ToInt32(maskedTextBox2.Text)) + (cay * Convert.ToInt32(maskedTextBox3.Text)) + (bilet * Convert.ToInt32(maskedTextBox4.Text));
            textBox1.Text = toplam + " TL ";
            kasa = kasa + toplam;
            textBox2.Text = kasa + " TL ";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = " ";
            maskedTextBox2.Text = " ";
            maskedTextBox3.Text = " ";
            maskedTextBox4.Text = " ";
            maskedTextBox1.Focus();
        }
    }
}
