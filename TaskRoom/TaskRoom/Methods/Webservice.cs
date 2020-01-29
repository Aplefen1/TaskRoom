using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Web;

namespace TaskRoom.Methods
{
    public class Webservice
    {

        public static readonly HttpClient Client = new HttpClient();

        public string NewGetReq()
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
                sLine = WebReader.ReadLine();
                if (sLine != null)
                {
                    return sLine;
                }

            };
            return "oopsie";
        }
        public async void Login(string name, string lastName, string username, string password, string age)
        {
            //This is the URL to the part of the API that contains a function that inserts the record to the database
            string URL = "http://10.84.129.125:1027/newChild";

            //The dictionary is used to define the new child
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "name", name },
                { "lastname", lastName },
                { "username", username },
                { "password", password },
                { "age", age}
            };

            var content = new FormUrlEncodedContent(postData);

            // Set the ContentType property of the WebRequest.
            //request.ContentType = "application/x-www-form-urlencoded";
            var response = await Client.PostAsync(URL, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        public string findUser(string name, string username)
        {
            string URL = "http://10.84.129.125:1027/showChild";

        }

    }
}
