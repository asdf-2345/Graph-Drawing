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
		
		void drawRectangle(Pen p, Graphics g, int y, int x){
			Rectangle rec = new Rectangle(0, y, x, 20);
            g.DrawRectangle(p, rec);
		}
		
		void drawLine(Pen p, Graphics g){
			Point point1 = new Point(0, 0);
			Point point2 = new Point(0, panel1.Height);
			g.DrawLine(p, point1, point2);
		}
		
		int[] GraphTopics;
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			Pen p = new Pen(Color.Black, 1);
			Graphics g = this.panel1.CreateGraphics();
			
			drawLine(p, g);
			
			if(drawPossibility){
				
				for(int a = 0; a < GraphTopics.Length; a++){
					drawRectangle(p, g, 10 + a * 30 ,GraphTopics[a]);
				}
			}
		}
		
		//항목개수 입력완료
		void Button1Click(object sender, EventArgs e)
		{
			try{
				int a = int.Parse(textBox1.Text.ToString());
				GraphTopics = new int[a];
				GraphTopicsEnter(a);
			}
			catch{
				MessageBox.Show("다시 입력해주세요.");
				return;
			}
		}
		
		bool drawPossibility = false;
		void GraphTopicsEnter(int length){
			for(int a = 1; a <= length; a++){
				Form1 form1 = new Form1();
				form1.num = a;
				form1.ShowDialog();
				GraphTopics[a-1] = form1.Size;
				Console.WriteLine(GraphTopics[a-1]);
			}
			drawPossibility = true;
			
			Pen p = new Pen(Color.Black, 1);
			Graphics g = this.panel1.CreateGraphics();
			
			for(int a = 0; a < GraphTopics.Length; a++){
				drawRectangle(p, g, 10 + a * 30, GraphTopics[a]);
			}
		}
	}
}
