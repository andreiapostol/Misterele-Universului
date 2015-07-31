/*
 * Created by SharpDevelop.
 * User: Darius
 * Date: 03-Jun-14
 * Time: 21:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Universul_Virtual
{
	/// <summary>
	/// Description of MariPersonalitati.
	/// </summary>
	public partial class MariPersonalitati : Form
	{
		public MariPersonalitati()
		{
			
			InitializeComponent();
			string text = System.IO.File.ReadAllText("Resurse/MariPersonalitati/1.txt");
			label3.Text = text;
		}
		int i= 1;
		//urmatoarea personalitate
		void Label1Click(object sender, EventArgs e)
		{
			i = i + 1;
			if ( i == 9) i = 1;
			
			string path = "Resurse/MariPersonalitati/";
			path = path + i + ".txt";
			
			string text = System.IO.File.ReadAllText(path);
			label3.Text = text;
			
		}
		
		//personalitatea precedenta
		void Label2Click(object sender, EventArgs e)
		{
			i = i - 1;
			if (i == 0) i = 9;
			else{
			string path = "Resurse/MariPersonalitati/";
			path = path + i + ".txt";
			
			string text = System.IO.File.ReadAllText(path);
			label3.Text = text;
			}
			
		}
		
		//iesire
		void Label4Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
