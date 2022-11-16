using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayıBulmaYazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            double sayi = Convert.ToDouble(textBox1.Text); ;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int kimlik = 2 ; kimlik <= sayi; kimlik++)
            {
                int kontrol = 0;
                for (int j = 2; j < kimlik; j++)
                {
                    if (kimlik % j == 0)
                    {
                        kontrol++;
                        break;
                    }

                }
                if (kontrol == 0)
                {
                    listBox1.Items.Add(kimlik);
                    sayac++;
                }
            }
            listBox2.Items.Add(sayac);
        }
    }
}
