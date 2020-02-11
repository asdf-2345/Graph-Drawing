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
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
				return;
			}
		}
		
		bool drawPossibility = false;
		void GraphTopicsEnter(int length){
			try{
			int max = 0, min = int.MaxValue;
			for(int a = 1; a <= length; a++){
				Form1 form1 = new Form1();
				form1.num = a;
				form1.ShowDialog();
				GraphTopics[a-1] = form1.Size;
				if(min > GraphTopics[a-1]){
					min = GraphTopics[a-1];
				}
				if(max < GraphTopics[a-1]){
					max = GraphTopics[a-1];
				}
				Console.WriteLine(GraphTopics[a-1]);
			}
			Console.WriteLine(max + " " + min);
			Console.WriteLine();
			Console.WriteLine(panel1.Width);
			if(max > panel1.Width){
				Console.WriteLine(panel1.Width);
				Console.WriteLine(max);
				Console.WriteLine(panel1.Width / max);
				double multiplicationNumber = (double)panel1.Width / (double)max;
				Console.WriteLine(multiplicationNumber);
				for(int a = 0; a < GraphTopics.Length; a++){
					GraphTopics[a] = (int)Math.Round(GraphTopics[a] * multiplicationNumber - 1);
					Console.WriteLine(GraphTopics[a]);
				}
			}
			else if(min < 51){
				int multiplicationNumber = 51 / min;
				
				if(max * multiplicationNumber + 5 < panel1.Width){
					
				}
			}
			
			drawPossibility = true;
			
			Pen p = new Pen(Color.Black, 1);
			Graphics g = this.panel1.CreateGraphics();
			
			for(int a = 0; a < GraphTopics.Length; a++){
				drawRectangle(p, g, 10 + a * 30, GraphTopics[a]);
			}
		}
		catch(Exception ex){
				MessageBox.Show(ex.ToString());
		}
		}
	}
}
