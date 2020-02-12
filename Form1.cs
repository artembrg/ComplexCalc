using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double re1 = 0, re2 = 0, im1 = 0, im2 = 0;
            if (Double.TryParse(textBox3.Text, out re1) && Double.TryParse(textBox2.Text, out im1)
                && Double.TryParse(textBox8.Text, out re2) && Double.TryParse(textBox7.Text, out im2))
            {
                Complex z1 = new Complex(re1, im1);
                Complex z2 = new Complex(re2, im2);
                Complex z = z1 + z2;
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double re1 = 0, re2 = 0, im1 = 0, im2 = 0;
            if (Double.TryParse(textBox3.Text, out re1) && Double.TryParse(textBox2.Text, out im1)
                && Double.TryParse(textBox8.Text, out re2) && Double.TryParse(textBox7.Text, out im2))
            {
                Complex z1 = new Complex(re1, im1);
                Complex z2 = new Complex(re2, im2);
                Complex z = z1 - z2;
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double re1 = 0, re2 = 0, im1 = 0, im2 = 0;
            if (Double.TryParse(textBox3.Text, out re1) && Double.TryParse(textBox2.Text, out im1)
                && Double.TryParse(textBox8.Text, out re2) && Double.TryParse(textBox7.Text, out im2))
            {
                Complex z1 = new Complex(re1, im1);
                Complex z2 = new Complex(re2, im2);
                Complex z = z1 * z2;
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double re1 = 0, re2 = 0, im1 = 0, im2 = 0;
            if (Double.TryParse(textBox3.Text, out re1) && Double.TryParse(textBox2.Text, out im1)
                && Double.TryParse(textBox8.Text, out re2) && Double.TryParse(textBox7.Text, out im2))
            {
                Complex z1 = new Complex(re1, im1);
                Complex z2 = new Complex(re2, im2);
                Complex z = z1 / z2;
                if (z == null)
                {
                    textBox11.Text = "Division";
                    textBox12.Text = "by zero";
                    return;
                }
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double re = 0, im = 0;
            if (Double.TryParse(textBox3.Text, out re) && Double.TryParse(textBox2.Text, out im))
            {
                Complex z1 = new Complex(re, im);
                Complex z = z1.Sine(z1);
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double re = 0, im = 0;
            if (Double.TryParse(textBox3.Text, out re) && Double.TryParse(textBox2.Text, out im))
            {
                Complex z1 = new Complex(re, im);
                Complex z = z1.Cosine(z1);
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double re = 0, im = 0;
            if (Double.TryParse(textBox3.Text, out re) && Double.TryParse(textBox2.Text, out im))
            {
                Complex z1 = new Complex(re, im);
                Complex z = z1.Exponent(z1);
                textBox11.Text = z.Re.ToString();
                textBox12.Text = z.Im.ToString();
                textBox10.Text = z.Mod.ToString();
                textBox9.Text = z.Angle.ToString();
            }
            else
            {
                textBox11.Text = "Incorrect";
                textBox12.Text = "data!";
                textBox10.Text = "Enter the";
                textBox9.Text = "real numbers!";
            }
        }
    }
}
