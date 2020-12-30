using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace GetScore
{
	public partial class getScore : Form
	{
		WebActivity wa = new WebActivity();
		public getScore()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls=false;
		}

		private void btGet_Click(object sender, EventArgs e)
		{
			// 02000145
			Thread thr = new Thread(Print);
			thr.IsBackground = true;
			thr.Start();

			Thread thr1 = new Thread(Print1);
			thr1.IsBackground = true;
			thr1.Start();

			Thread thr2 = new Thread(Print2);
			thr2.IsBackground = true;
			thr2.Start();

			Thread thr3 = new Thread(Print3);
			thr3.IsBackground = true;
			thr3.Start();
		}
		void Print()
		{
			int k = 2000001;
			for(int i=0;i<20000;i++)
			{
				string l = wa.getScore("0"+(k+i));
				string path = "Score.txt";
				if (!File.Exists(path))
				{
					using (StreamWriter sw = File.CreateText(path))
					{

					}
				}
				using (StreamWriter sw = File.AppendText(path))
				{
					sw.WriteLine(l);
				}
				this.pgbget100.Value = (int)((i+1)*100.0/20000);
				this.lbGet100.Text = (i + 1) + "/20000";
			}	
			
		}
		void Print1()
		{
			int k = 2020000;
			for (int i = 0; i < 20000; i++)
			{
				string l = wa.getScore("0" + (k + i));
				string path = "Score1.txt";
				if (!File.Exists(path))
				{
					using (StreamWriter sw = File.CreateText(path))
					{

					}
				}
				using (StreamWriter sw = File.AppendText(path))
				{
					sw.WriteLine(l);
				}
				this.pgb1.Value = (int)((i + 1) * 100.0 / 20000);
				this.lb1.Text = (i + 1) + "/20000";
			}
		}
		void Print2()
		{
			int k = 2040000;
			for (int i = 0; i < 20000; i++)
			{
				string l = wa.getScore("0" + (k + i));
				string path = "Score2.txt";
				if (!File.Exists(path))
				{
					using (StreamWriter sw = File.CreateText(path))
					{

					}
				}
				using (StreamWriter sw = File.AppendText(path))
				{
					sw.WriteLine(l);
				}
				this.pgb2.Value = (int)((i + 1) * 100.0 / 20000);
				this.lb2.Text = (i + 1) + "/20000";
			}

		}
		void Print3()
		{
			int k = 2060000;
			for (int i = 0; i <= 2074719 - 2060000; i++)
			{
				string l = wa.getScore("0" + (k + i));
				string path = "Score3.txt";
				if (!File.Exists(path))
				{
					using (StreamWriter sw = File.CreateText(path))
					{

					}
				}
				using (StreamWriter sw = File.AppendText(path))
				{
					sw.WriteLine(l);
				}
				this.pgb3.Value = (int)((i + 1) * 100.0 / 20000);
				this.lb3.Text = (i + 1) + "/" + (2074719 - 2060000);
			}

		}
	}
	
}
