using SesliSessizOdev.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliSessizOdev
{
    public partial class Form1 : Form
    {
        SesliSessizHarfService service;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            comboBox1.Items.Add("Sesli Harf"); //0
            comboBox1.Items.Add("Sessiz Harf"); // 1
            comboBox1.SelectedIndex = 0;
            service = new SesliSessizHarfService();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen Bir Kelime Giriniz");
                return;
            }
            string sonuc = service.sesliHarfBul(textBox1.Text.Trim());
            if (comboBox1.SelectedIndex == 1)
            {
                sonuc = service.sessizHarfBul(textBox1.Text.Trim(),sonuc);
            }
            if (sonuc != "")
                lSonuc.Text = sonuc;
            else
                lSonuc.Text = comboBox1.Text + "Bulunamadı";
        }
    }
}
