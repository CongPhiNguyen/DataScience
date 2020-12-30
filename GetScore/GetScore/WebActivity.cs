using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.Net.Http;
using System.IO;
namespace GetScore
{
	class WebActivity
	{
		public string getSourceWithMessage(string SoBaoDanh)
		{
			string res="";
			string url = "http://diemthi.hcm.edu.vn/Home/Show";
			WebClient wc = new WebClient();
			wc.Encoding = Encoding.UTF8;
			NameValueCollection myNameValueCollection = new NameValueCollection();
			myNameValueCollection.Add("SoBaoDanh", SoBaoDanh);
			byte[] responseArray = wc.UploadValues(url, myNameValueCollection);
			res=Encoding.UTF8.GetString(responseArray);
			if (res == "") res = "Fuck";
			return res;
		}
		public string Curl(string SoBaoDanh)
		{
			string strCommand = "curl -F \"SoBaoDanh=" + SoBaoDanh + "\" diemthi.hcm.edu.vn/Home/Show";
			string path = "Code.bat";
			// This text is added only once to the file.
			if (!File.Exists(path))
			{
				using (StreamWriter sw = File.CreateText(path))
				{

				}
			}
			System.IO.File.WriteAllText("Code.bat", strCommand);
			//this.rtbSource.Text = k;
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			p.StartInfo.CreateNoWindow = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.FileName = path;
			p.StartInfo.UseShellExecute = false;
			p.Start();
			string output = p.StandardOutput.ReadToEnd();
			p.WaitForExit();
			//this.rtbSource.Text = output;
			return output;
		}
		public string getScore(string SoBaoDanh)
		{
			// Cho chạy từ 02000001 đến 02074719
			try
			{
				string k = getSourceWithMessage(SoBaoDanh);
				string res = "SBD: " + SoBaoDanh+"\n";
				while (k.IndexOf("solid\"") != -1)
				{
					k = k.Substring(k.IndexOf("solid\"") + 7);
					string data = "";
					data+= k.Substring(0, k.IndexOf("<"));
					data = data.Replace("  ", "");
					data = data.Replace("\n", "");
					res += data + "\n";
				}
				if (res == "")
				{
					//Viết vô file sai
					string path = "Fail.txt";
					if (!File.Exists(path))
					{ 
						using (StreamWriter sw = File.CreateText(path))
						{
						
						}
					}
					using (StreamWriter sw = File.AppendText(path))
					{
						sw.WriteLine(SoBaoDanh);
					}
				}
				return res;
			}
			catch
			{
				// Viết vô file là không lấy được
				string path = "Fail.txt";
				if (!File.Exists(path))
				{
					using (StreamWriter sw = File.CreateText(path))
					{

					}
				}
				using (StreamWriter sw = File.AppendText(path))
				{
					sw.WriteLine(SoBaoDanh);
				}
				return "Không lấy được thông tin";
			}
		}
	}
}
