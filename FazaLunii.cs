using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Universul_Virtual
{
    public partial class FazaLunii : Form
    {
        public FazaLunii()
        {
            InitializeComponent();
        }
        static public int moon_phase(int y, int m, int d)
        {


            int c, e;
            double jd;
            int b;

            if (m < 3)
            {
                y--;
                m += 12;
            }
            ++m;
            c = (int)365.25 * y;
            e = (int)30.6 * m;
            jd = c + e + d - 694039.09;  
            jd /= 29.53;           
            b = (int)jd;		   
            jd -= b;		   
            b = (int)(jd * 8 + 0.5);	   
            b = b & 7;		   
            return b;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Today;
            int y = data.Year;
            int m = data.Month;
            int d = data.Day;
            int faza = moon_phase(y, m, d);
            label2.Text = "FAZA " + faza.ToString();
            string locatie_text = "Resurse/faza_" + faza.ToString() + ".txt";
            string locatie_imagine = "Resurse/faza_" + faza.ToString() + ".jpg";
            label6.Text = File.ReadAllText(locatie_text);
            pictureBox1.Image = Image.FromFile(locatie_imagine);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            pictureBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            label8.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;
            label8.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = Int32.Parse(textBox1.Text);
            int m = Int32.Parse(textBox2.Text);
            int d = Int32.Parse(textBox3.Text);
            int faza = moon_phase(y, m, d);
            label2.Text = "FAZA " + faza.ToString();
            string locatie_text = "Resurse/faza_" + faza.ToString() + ".txt";
            string locatie_imagine = "Resurse/faza_" + faza.ToString() + ".jpg";
            label6.Text = File.ReadAllText(locatie_text);
            pictureBox1.Image = Image.FromFile(locatie_imagine);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            pictureBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FazaLunii frm = new FazaLunii();
            this.Close();
            frm.Show();
        }
    }
}
