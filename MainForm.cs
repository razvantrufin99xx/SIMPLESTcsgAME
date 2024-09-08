/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/8/2024
 * Time: 8:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InfinitLoop
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			p1.Left = 100;
			p1.Top = 200;
			p1.Width = 10;
			p1.Height = 10;
			p1.BackColor = Color.Red;
			p1.Visible = true;
			this.Controls.Add(p1);
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		public Panel p1 = new Panel();
		
		public DateTime dt = DateTime.Now;
		void Timer1Tick(object sender, EventArgs e)
		{
				dt = DateTime.Now;
				Text = dt.ToString();
		}
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			Text += c;
			if(c=='A'){p1.Left-=10;}
			if(c=='S'){p1.Top+=10;}
			if(c=='D'){p1.Left+=10;}
			if(c=='W'){p1.Top-=10;}
			
		}
		
	}
}
