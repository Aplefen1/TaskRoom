using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Web;
using TaskRoom.Objects;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskRoom.Methods
{
    public class Webservice
    {
        public string status = "The big stink";
        public static readonly HttpClient Client = new HttpClient();
        public string URL = "http://10.84.129.125:1027/";
        public string returnedChildren;
        public List<string> returnedClasses;

        public async void newUser(string name, string lastName, string username, string password, string age)
        {
            //This is the URL to the part of the API that contains a function that inserts the record to the database
            string gURL = URL + "newChild";

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
            var response = await Client.PostAsync(gURL, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        public async void checkUser(string username, string password)
        {
            //adds the url for the login checking view
            string cURL = URL + "confirmLogin";

            
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "username", username },
                { "password", password }
            };
            //encodes the data into a query 
            var content = new FormUrlEncodedContent(postData);
            //sends the content and waits for a response
            var response = await Client.PostAsync(cURL, content);
            string responseString = await response.Content.ReadAsStringAsync();
            //the response is set to the status attribute in the class to be used externally as an indicator
            status = responseString;

        }

        public async Task<List<Objects.Child>> GetChildren(string className)
        {
            string eURL = URL + "getClassroom";
            Dictionary<string, string> postData = new Dictionary<string, string>()
            {
                { "classname", className }
            };

            var content = new FormUrlEncodedContent(postData);
            var response = await Client.PostAsync(eURL, content);

            string responseString = await response.Content.ReadAsStringAsync();

            LeaderboardRoot Data = JsonConvert.DeserializeObject<LeaderboardRoot>(responseString);
            Debug.WriteLine(Data.children);
            return Data.children;
        }

        public async Task<List<string>> getClassrooms()
        {
            string rURL = URL + "returnClasses";
            var response = await Client.GetAsync(rURL);
            var responseString = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(responseString);

            GetJsonClasses Data = JsonConvert.DeserializeObject<GetJsonClasses>(responseString);
            //Debug.WriteLine(Data.names[0]);

            return Data.names;
            //Debug.WriteLine(returnedClasses[0]);

        }
    }
}
