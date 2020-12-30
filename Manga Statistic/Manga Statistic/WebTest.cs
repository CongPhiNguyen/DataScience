using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manga_Statistic
{
	public partial class WebTest : Form
	{
		WebActivity wa = new WebActivity();
		public WebTest()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void btGet_Click(object sender, EventArgs e)
		{
			Thread th = new Thread(getSource);
			th.IsBackground = false;
			th.Start();
		}

		private void getSource()
		{
			this.rtbSource.Text = "Đang lấy source .....";
			string k = wa.getSource(wa.renderLink());
			this.rtbSource.Text = k;
		}

		private void btGetDetail_Click(object sender, EventArgs e)
		{
			Thread th = new Thread(GetDetail);
			th.IsBackground = false;
			th.Start();
		}
		private void GetDetail()
		{
			string k = this.rtbSource.Text;
			if (k.IndexOf("list-truyen") == -1)
			{
				this.rtbDetail.Text = "Không có dữ liệu";
			}
			k = k.Substring(k.IndexOf("list-truyen"));
			k = k.Substring(k.IndexOf("href=")+6);
			string link = k.Substring(0, k.IndexOf("\""));
			k = k.Substring(k.IndexOf("title=") + 7);
			string title = k.Substring(0, k.IndexOf("\""));
			k = k.Substring(k.IndexOf("src=") + 5);
			string imageSource = k.Substring(0, k.IndexOf("\""));
			this.rtbDetail.Text ="Link: " + link +"\nTitle: "+title;
			this.rtbDetail.Text += "\nSource: " + imageSource;
		}
	}
}
