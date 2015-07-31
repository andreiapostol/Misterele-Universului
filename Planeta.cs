/*
 * Created by SharpDevelop.
 * User: Darius
 * Date: 01-Jun-14
 * Time: 22:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Universul_Virtual
{
	/// <summary>
	/// Description of Planeta.
	/// </summary>
	/// 
	
	public partial class Planeta : Form
	{
		public Planeta()
		{
		InitializeComponent();
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		
		this.BackgroundImage = Image.FromFile("Resurse/Background.jpg");
		
		
		pictureBox2.Visible = false;
		
		
		
		richTextBox1.Visible = true;
		
		
		string[] lines = File.ReadAllLines("Resurse/Facts.txt");
				label6.Text = lines[0];
		}
		
	
				
		//close program
		void Label1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		//highlight text
		void Label2Click(object sender, EventArgs e)
		{
			int index = 0;
			// dupa gasirea cuvintelor cu cuvantul A, pentru a cauta cuvantul B, deselecteaza totul (reimprospateaza textul)
			string temp = richTextBox1.Text; richTextBox1.Text = ""; richTextBox1.Text = temp;
			// cauta si selecteaza (highlight)
			while (index < richTextBox1.Text.LastIndexOf(textBox1.Text))
			{
				richTextBox1.Find(textBox1.Text,index,richTextBox1.TextLength,RichTextBoxFinds.None);
				richTextBox1.SelectionBackColor = Color.OrangeRed;
				index = richTextBox1.Text.IndexOf(textBox1.Text, index) +1;
			}			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			string temp = richTextBox1.Text; richTextBox1.Text = ""; richTextBox1.Text = temp;
		}
		
		//load
		
		void PlanetaLoad(object sender, EventArgs e)
		{
			
			//Thread.Sleep(1500);
			this.SuspendLayout();
			richTextBox1.Visible = true;
			textBox1.Visible = true;
			pictureBox1.Visible = true;
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			this.ResumeLayout();
			
			this.WindowState = FormWindowState.Maximized;
			
			//			PENTRU
			//			REZOLUTII
			
			richTextBox1.Width = (int)(this.Width * 0.49) ;
			richTextBox1.Height =(int)(this.Height * 0.75);	
			
			
			
		}
		
		//arata poza/ textul
		int j=0;
		
		void Label4Click(object sender, EventArgs e)
		{
		j= j+1;
		
		if (j==1)
		{   //modul poze
		
		button1.Visible = true;
		button2.Visible = true;
		pictureBox2.Visible = true;
		//					FOARTE
		//					IMPORTANT
		//pictureBox2.Width = (int)(this.Width * 0.49) ;
		//pictureBox2.Height = (int)(this.Height * 0.75);
		//
		//
		richTextBox1.Visible = false;
		label4.Text="Arată textul";
		j=-1;
		string path = label7.Text;
		path = path+ 1 +".jpg";
		pictureBox2.Image = Image.FromFile(path);
		

		}
		else if (j==0){   //modul text
		pictureBox2.Visible = false;
		richTextBox1.Visible = true;
		label4.Text="Arată pozele";
		
		button1.Visible = false;
		button2.Visible = false;
		
		}
				
		}
		
		
		//timer
		int ty=0;
		int g;
		Random rnd = new Random();
		void Timer1Tick(object sender, EventArgs e)
		{
			ty = ty + 1;
			if (ty == 5){
				g = rnd.Next(0,49);
				string[] lines = File.ReadAllLines("Resurse/Facts.txt");
				label6.Text = lines[g];
				ty = 0;
			
						}	
		}
		int i = 1;
		
		//poza trecuta
		void Button1Click(object sender, EventArgs e)
		{
				
		i = i - 1;
		
			if (i == -1) i = 5;
			if (i == 0) i = 5;
			label8.Text = i.ToString();
		string path = label7.Text;
		path = path+ i +".jpg";
		pictureBox2.Image = Image.FromFile(path);
		path= "sef";		
		}
			
		
		
		//poza urmatoare
		void Button2Click(object sender, EventArgs e)
		{
			
				i = i + 1;
			
		if (i == 6 ) i = 1;	
		label8.Text = i.ToString();
		string path = label7.Text;
		path = path + i + ".jpg";
		pictureBox2.Image = Image.FromFile(path);
		path = "sef";
		}
		

		
		void Label6Click(object sender, EventArgs e)
		{
			
		}

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

	}
}

