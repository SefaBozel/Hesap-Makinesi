using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac
{
    public partial class hesap_makinesi : Form
    {
        public hesap_makinesi()
        {
            InitializeComponent();
        }

        private void hesap_makinesi_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hesapla;
            int sayi1, sayi2;
            string islem;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            islem = comboBox1.Text;
            switch (islem)
            {
                case "+": hesapla = sayi1 + sayi2; label4.Text = hesapla.ToString(); break;
                case "-": hesapla = sayi1 - sayi2; label4.Text = hesapla.ToString(); break;
                case "*": hesapla = sayi1 * sayi2; label4.Text = hesapla.ToString(); break;
                case "/": hesapla = sayi1 / sayi2; label4.Text = hesapla.ToString(); break;
            }
        }
    }
}
