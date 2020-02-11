/*
 * Created by SharpDevelop.
 * User: asdf-2345
 * Date: 2020-02-11
 * Time: 오후 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 막대그래프_그리기
{
	public partial class Form1 : Form
	{
		int number;
		public int num{
			get{
				return number;
			}
			set{
				number = value;
			}
		}
		
		int size;
		public int Size{
			get{
				return size;
			}
			set{
				size = value;
			}
		}
		
		public Form1()
		{
			InitializeComponent();
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			label1.Text = "항목" + number + "의 값 : ";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
				size = int.Parse(textBox1.Text.ToString());
				this.Close();
			}
			catch{
				MessageBox.Show("다시 입력해주세요.");
				return;
			}
		}
	}
}
