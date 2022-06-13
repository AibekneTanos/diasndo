using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diasndo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, s, d;
            a = Convert.ToDouble(textBox1.Text);
            s = Convert.ToDouble(textBox2.Text);
            d = (a * s) / (a + s);
            listBox1.Items.Add("d=" + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double b, r;
            b = Convert.ToDouble(textBox3.Text);
            r = Convert.ToDouble(textBox4.Text);

            listBox2.Items.Add("Ширина=" + b+"cm");
            listBox2.Items.Add("Выоста=" + r+"cm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double q, w, t, y;
            q = Convert.ToDouble(textBox5.Text);
            w= Convert.ToDouble(textBox6.Text);
            t = Convert.ToDouble(textBox7.Text);
            y = (q * t) + (w * t);
            listBox3.Items.Add("Стоимость покупки=" + y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double m, n, h, v, c, doh;
            m = Convert.ToDouble(textBox8.Text);
            n = Convert.ToDouble(textBox9.Text);
            h = Convert.ToDouble(textBox10.Text);
 
            c = (h / 100 * m) / 365 * n;
            doh = c + m;
            listBox4.Items.Add("сумма дохода=" + doh);
            listBox4.Items.Add("доход=" +c);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double o, k;
            o = Convert.ToDouble(textBox11.Text);
            k = o / 60;
            listBox5.Items.Add("otvet=" + k);


        }
    }

  
}
