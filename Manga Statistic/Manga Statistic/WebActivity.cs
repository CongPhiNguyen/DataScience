using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Manga_Statistic
{
	class WebActivity
	{
		public string getSource(string url)
		{
			WebClient client = new WebClient();
			client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:47.0) Gecko/20100101 Firefox/47.0");
			string res = client.DownloadString(url);
			return res;
		}
		public string renderLink()
		{
			string url= "https://mangakakalot.com/manga_list?type=latest&category=11&state=all&page=1";
			return url;
		}
	}
}
