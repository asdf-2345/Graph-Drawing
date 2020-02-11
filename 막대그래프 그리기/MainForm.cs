/*
 * Created by SharpDevelop.
 * User: asdf-2345
 * Date: 2020-02-08
 * Time: 오후 2:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 막대그래프_그리기
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void drawRectangle(Pen p, Graphics g){
			int y = 10;
			int x = 50;
			Rectangle rec = new Rectangle(0, y, x, 20);
            g.DrawRectangle(p, rec);
		}
		
		void drawLine(Pen p, Graphics g){
			int y = 10;
			int x = 50;
			Point point1 = new Point(0, 0);
			Point point2 = new Point(0, panel1.Height);
			g.DrawLine(p, point1, point2);
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			Pen p = new Pen(Color.Black, 1);
			Graphics g = this.panel1.CreateGraphics();
			drawLine(p, g);
			drawRectangle(p, g);
		}
	}
}
