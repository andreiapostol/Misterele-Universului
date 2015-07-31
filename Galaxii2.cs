/*
 * Created by SharpDevelop.
 * User: Darius
 * Date: 01-Jun-14
 * Time: 15:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Universul_Virtual
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Galaxii2 : Form
	{
		public Galaxii2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label7.Visible = false;
			label19.Visible = false;
			
		}
		
		
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
		panel1.Height= this.Height / 12;

		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
		label4.Text = DateTime.Now.ToString("HH:mm:ss");	
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		 void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
		//MessageBoxManager.Yes = "Da";
    	//MessageBoxManager.No = "Nu";
    	//MessageBoxManager.Register();
    	//DialogResult dialog = MessageBox.Show("Doriți să ieșiți?","Ieșiți?",MessageBoxButtons.YesNo);  
    	//MessageBoxManager.Unregister();
    	//if (dialog == DialogResult.No)
    	//{
    	//	e.Cancel = true;
    	//}
   
		}
		//despre noi
		void Label2Click(object sender, EventArgs e)
		{
			DespreProiect frm = new DespreProiect();
			frm.Show();
			frm.label1.Text = "Suntem o echipă de elevi din CNITV, clasa a XI a, pasionați de informatică și devotați acestui domeniu." + "\r\n" + "Apostol Andrei Laurențiu" + "\r\n" + "Medar Andrei" + "\r\n" + "Ghita Sebastian Cristian ";
			System.Diagnostics.Process.Start("www.lbi.ro");
			
			
		}
		//despre proiect
		void Label7Click(object sender, EventArgs e)
		{
			DespreProiect frm = new DespreProiect();
			frm.Show();
            frm.label1.Text = "Acest proiect are în vedere prezentarea sistemului nostru solar si a catorva galaxii, precum și analiza, respectiv informații referitoare la fiecare planetă, galaxie (sau satelit) în parte. Programul folosește un cod pentru a crea, pe baza unor informații din fișiere text și imagini, o pagină proprie fiecărui corp ceresc. Astfel, expansiunea proiectului va putea fi mult mai eficientă și mai rapidă. ";			
		}
		
		//Mari Personalitati
		void Label1Click(object sender, EventArgs e)
		{
			MariPersonalitati frm = new MariPersonalitati();
			frm.Show();
		}
		
		//Date Importante
		void Label19Click(object sender, EventArgs e)
		{
			DateImportante frm = new DateImportante();
			frm.Show();
		}
		
		//pamantul
		void PictureBox11Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Pamantul/pamantul.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Pamantul/Pamantul.gif");
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			frm.label7.Text = ("Resurse/Pamantul/");
	
		}
		
		//luna
		void PictureBox6Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Luna/luna.txt");
			frm.richTextBox1.Text = text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Luna/Luna.png");
			frm.label7.Text = ("Resurse/Luna/");
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			
			
		}
		
		//saturn
		void PictureBox2Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Saturn/Saturn.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Saturn/Saturn.jpg");
			
			
			
			frm.label7.Text = ("Resurse/Saturn/");
			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			
			
			
		}
		
		//mercur
		void PictureBox8Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Mercur/Mercur.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Mercur/Mercur.gif");
			
			frm.label7.Text = ("Resurse/Mercur/");
			
			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			
		}
		
		
		//venus
		void PictureBox10Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Venus/Venus.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Venus/Venus.gif");
			
			frm.label7.Text = ("Resurse/Venus/");
		
			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			
		}
		
		//marte
		void PictureBox9Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Marte/Marte.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Marte/Marte.gif");
			
			frm.label7.Text = ("Resurse/Marte/");


			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
				
		}
		
		//jupiter
		void PictureBox1Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Jupiter/Jupiter.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Jupiter/Jupiter.gif");
			
			frm.label7.Text = ("Resurse/Jupiter/");

			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

		}
		
		//uranus
		void PictureBox3Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Uranus/Uranus.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Uranus/Uranus_2.jpg");
			
			
			frm.label7.Text = ("Resurse/Uranus/");
	
			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
	
		}
		
		//neptun
		void PictureBox4Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Neptun/Neptun.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Neptun/Neptun.gif");
			
			
			frm.label7.Text = ("Resurse/Neptun/");
	
			
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

		}
		
		//Soarele
		void PictureBox7Click(object sender, EventArgs e)
		{
			Planeta frm = new Planeta();
			frm.Show();
			string text = System.IO.File.ReadAllText("Resurse/Soarele/Soarele.txt");
			frm.richTextBox1.Text =text;
			frm.pictureBox1.Image = Image.FromFile("Resurse/Soarele/Soarele.gif");
			
			
			frm.label7.Text = ("Resurse/Soarele/");
	
			frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
			frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
	
		}
		
		
		//hover
		
		void Label6MouseEnter(object sender, EventArgs e)
		{
		label1.Visible = false;
		label2.Visible = false;
		label3.Visible = false;	
		label7.Visible = false;
        testcun.Visible = false;
        label19.Visible = false;
        label22.Visible = false;
		label18.Visible = true;
		
		}
		
		void Label5MouseEnter(object sender, EventArgs e)
		{
		label1.Visible = true;
		label2.Visible = true;
		label3.Visible = true;
		label7.Visible = true;
		label19.Visible = true;
        testcun.Visible = true;
        label22.Visible = true;
		label18.Visible = false;

		}
	
		
		
		
		
		
		
		
		
		
		void TestcunClick(object sender, EventArgs e)
		{
			TestCunostiinte frm = new TestCunostiinte();
			frm.Show();			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Galaxii2 frm = new Galaxii2();
            frm.Show();
            this.Hide();

        }

        private void label22_Click(object sender, EventArgs e)
        {
            FazaLunii frm = new FazaLunii();
            frm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Planeta frm = new Planeta();
            frm.Show();
            string text = System.IO.File.ReadAllText("Resurse/GalaxiiVar2/Andromeda/Andromeda.txt");
            frm.richTextBox1.Text = text;
            frm.pictureBox1.Image = Image.FromFile("Resurse/GalaxiiVar2/Andromeda/1.jpg");


            frm.label7.Text = ("Resurse/GalaxiiVar2/Andromeda/");

            frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
	
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Planeta frm = new Planeta();
            frm.Show();
            string text = System.IO.File.ReadAllText("Resurse/GalaxiiVar2/Calea Lactee/Calea Lactee.txt");
            frm.richTextBox1.Text = text;
            frm.pictureBox1.Image = Image.FromFile("Resurse/GalaxiiVar2/Calea Lactee/1.jpg");


            frm.label7.Text = ("Resurse/GalaxiiVar2/Calea Lactee/");

            frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Planeta frm = new Planeta();
            frm.Show();
            string text = System.IO.File.ReadAllText("Resurse/GalaxiiVar2/Cartwheel/Cartwheel.txt");
            frm.richTextBox1.Text = text;
            frm.pictureBox1.Image = Image.FromFile("Resurse/GalaxiiVar2/Cartwheel/1.jpg");


            frm.label7.Text = ("Resurse/GalaxiiVar2/Cartwheel/");

            frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Planeta frm = new Planeta();
            frm.Show();
            string text = System.IO.File.ReadAllText("Resurse/GalaxiiVar2/M82/M82.txt");
            frm.richTextBox1.Text = text;
            frm.pictureBox1.Image = Image.FromFile("Resurse/GalaxiiVar2/M82/1.jpg");


            frm.label7.Text = ("Resurse/GalaxiiVar2/M82/");

            frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            frm.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Close();
            frm.Show();
        }


	}
}
