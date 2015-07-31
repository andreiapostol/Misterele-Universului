/*
 * Created by SharpDevelop.
 * User: Darius
 * Date: 03-Jun-14
 * Time: 22:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Universul_Virtual
{
	/// <summary>
	/// Description of DateImportante.
	/// </summary>
	public partial class DateImportante : Form
	{
		public DateImportante()
		{
			InitializeComponent();
			string text = System.IO.File.ReadAllText("Resurse/DateImportante.txt");
			richTextBox1.Text = text;
			richTextBox1.ReadOnly = true;
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
