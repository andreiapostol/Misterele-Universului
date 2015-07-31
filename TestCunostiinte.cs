/*
 * Created by SharpDevelop.
 * User: Mariana
 * Date: 6/4/2014
 * Time: 2:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Universul_Virtual
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class TestCunostiinte : Form
    {
        public TestCunostiinte()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            string[] lines = File.ReadAllLines("Resurse/Facts.txt");
        }


        string[] raspunsuriCorecte = new string[10];
        string[] raspunsBifat = new string[10];
        public void AdaugaIntrebariSiRaspunsuri()
        {
            Random rnd = new Random();
            int[] verificare = new int[30];
            int x, y;
            for (int i = 1; i <= 15; i++)
                verificare[i] = 1;
            int verif1;
            int[] numere = new int[30];

            //intrebarea 1

            x = rnd.Next(1, 25);
            verificare[x] = 0;
            string[] lines = File.ReadAllLines("Resurse/Intrebari/" + x + ".txt");
            label1.Text = lines[0];
            raspunsuriCorecte[1] = lines[1];
            y = rnd.Next(1, 3);
            checkBox1.Text = lines[y];
            verif1 = y;
            y = rnd.Next(1, 3);
            if (y == verif1)
            {
                int yaux = y;
                if (y == 3) y--;
                else if (y == 2) y++;
                else if (y == 1) y++;
            }
            checkBox2.Text = lines[y];
            y = 6 - verif1 - y;
            checkBox3.Text = lines[y];


            //intrebarea 2
            while (verificare[x] == 0)
            { x = rnd.Next(1, 25); }
            verificare[x] = 0;
            lines = File.ReadAllLines("Resurse/Intrebari/" + x + ".txt");
            label2.Text = lines[0];
            raspunsuriCorecte[2] = lines[1];
            y = rnd.Next(1, 3);
            checkBox4.Text = lines[y];
            verif1 = y;
            if (y == verif1)
            {
                int yaux = y;
                if (y == 3) y--;
                else if (y == 2) y++;
                else if (y == 1) y++;
            }
            checkBox5.Text = lines[y];
            y = 6 - verif1 - y;
            checkBox6.Text = lines[y];

            //intrebarea 3
            while (verificare[x] == 0)
                x = rnd.Next(1, 25);
            verificare[x] = 0;
            lines = File.ReadAllLines("Resurse/Intrebari/" + x + ".txt");
            label3.Text = lines[0];
            raspunsuriCorecte[3] = lines[1];
            y = rnd.Next(1, 3);
            checkBox7.Text = lines[y];
            verif1 = y;
            if (y == verif1)
            {
                int yaux = y;
                if (y == 3) y--;
                else if (y == 2) y++;
                else if (y == 1) y++;
            }
            checkBox8.Text = lines[y];
            y = 6 - verif1 - y;
            checkBox9.Text = lines[y];

            //intrebarea 4
            while (verificare[x] == 0)
                x = rnd.Next(1, 25);
            verificare[x] = 0;
            lines = File.ReadAllLines("Resurse/Intrebari/" + x + ".txt");
            label4.Text = lines[0];
            raspunsuriCorecte[4] = lines[1];
            y = rnd.Next(1, 3);
            verif1 = y;
            checkBox10.Text = lines[y];
            if (y == verif1)
            {
                int yaux = y;
                if (y == 3) y--;
                else if (y == 2) y++;
                else if (y == 1) y++;
            }
            checkBox11.Text = lines[y];
            y = 6 - verif1 - y;
            checkBox12.Text = lines[y];

            //intrebarea 5
            while (verificare[x] == 0)
                x = rnd.Next(1, 25);
            verificare[x] = 0;
            lines = File.ReadAllLines("Resurse/Intrebari/" + x + ".txt");
            label5.Text = lines[0];
            raspunsuriCorecte[5] = lines[1];
            y = rnd.Next(1, 3);
            checkBox13.Text = lines[y];
            verif1 = y;
            if (y == verif1)
            {
                int yaux = y;
                if (y == 3) y--;
                else if (y == 2) y++;
                else if (y == 1) y++;
            }
            checkBox14.Text = lines[y];
            y = 6 - verif1 - y;
            checkBox15.Text = lines[y];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            AdaugaIntrebariSiRaspunsuri();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            checkBox11.Enabled = true;
            checkBox12.Enabled = true;
            checkBox13.Enabled = true;
            checkBox14.Enabled = true;
            checkBox15.Enabled = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, notafinala = 0, raspunsuricorecte = 0;
            for (i = 1; i <= 5; i++)
            {
                if (raspunsuriCorecte[i] == raspunsBifat[i]) 
                {
                    notafinala += 2; raspunsuricorecte++;  
                }
            }
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            if (raspunsuriCorecte[1] == raspunsBifat[1])
            {
                textBox1.ForeColor = Color.Green;
                textBox1.Text = "Corect";

            }
            else
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Greșit";
            }
            if (raspunsuriCorecte[2] == raspunsBifat[2])
            {
                textBox2.ForeColor = Color.Green;
                textBox2.Text = "Corect";

            }
            else
            {
                textBox2.ForeColor = Color.Red;
                textBox2.Text = "Greșit";
            }
            if (raspunsuriCorecte[3] == raspunsBifat[3])
            {
                textBox3.ForeColor = Color.Green;
                textBox3.Text = "Corect";

            }
            else
            {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = "Greșit";
            }
            if (raspunsuriCorecte[4] == raspunsBifat[4])
            {
                textBox4.ForeColor = Color.Green;
                textBox4.Text = "Corect";

            }
            else
            {
                textBox4.ForeColor = Color.Red;
                textBox4.Text = "Greșit";
            }
            if (raspunsuriCorecte[5] == raspunsBifat[5])
            {
                textBox5.ForeColor = Color.Green;
                textBox5.Text = "Corect";

            }
            else
            {
                textBox5.ForeColor = Color.Red;
                textBox5.Text = "Greșit";
            }
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label6.Text = "Felicitări! Ai rezolvat ";
            label7.Text = "corect " + raspunsuricorecte.ToString() +" din 5 întrebări";
            label8.Text = "asta însemnând nota " + notafinala.ToString() + ".";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            button1.Text = "Reîncearcă!";
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                raspunsBifat[1] = checkBox1.Text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                raspunsBifat[1] = checkBox2.Text;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                raspunsBifat[1] = checkBox3.Text;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                raspunsBifat[2] = checkBox4.Text;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                raspunsBifat[2] = checkBox5.Text;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                raspunsBifat[2] = checkBox6.Text;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                raspunsBifat[3] = checkBox7.Text;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox7.Checked = false;
                checkBox9.Checked = false;
                raspunsBifat[3] = checkBox8.Text;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox8.Checked = false;
                checkBox7.Checked = false;
                raspunsBifat[3] = checkBox9.Text;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                raspunsBifat[4] = checkBox10.Text;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox10.Checked = false;
                checkBox12.Checked = false;
                raspunsBifat[4] = checkBox11.Text;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox11.Checked = false;
                checkBox10.Checked = false;
                raspunsBifat[4] = checkBox12.Text;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                raspunsBifat[5] = checkBox13.Text;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                checkBox13.Checked = false;
                checkBox15.Checked = false;
                raspunsBifat[5] = checkBox14.Text;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                raspunsBifat[5] = checkBox15.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scopul testului este foarte simplu: să testeze cunoștiințele acumulate de cei ce au folosit acest program. Se dau 5 întrebări, fiecare cu 3 răspunsuri, doar unul fiind corect. Nota se va acorda dublând numarul răspunsurilor corecte, nefiind puncte din oficiu.", "Instrucțiuni");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdaugaIntrebariSiRaspunsuri();
            timer1.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestCunostiinte_Load(object sender, EventArgs e)
        {

        }











    }
}
	
