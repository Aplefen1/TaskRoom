using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Web;

namespace TaskRoom.Methods
{
    public class GetSetDB
    {

        public string checkLogin(string username, string password)
        {
            string URL;
            URL = "http://10.84.129.125:1027/list/";

            WebRequest GETURL;
            GETURL = WebRequest.Create(URL);

            //WebProxy MyProx = new WebProxy("MyProx", 8000);
            //MyProx.BypassProxyOnLocal = true;
            //GETURL.Proxy = MyProx;

            Stream WebStream;
            WebStream = GETURL.GetResponse().GetResponseStream();

            StreamReader WebReader = new StreamReader(WebStream);
            string sLine = "";
            int i = 0;
            while (sLine != null)
            {
                i++;
                string a;
                sLine = WebReader.ReadLine();
                if (sLine != null)
                {
                    return sLine;
                }

            };
            return "oopsie";
        }
    }
}
