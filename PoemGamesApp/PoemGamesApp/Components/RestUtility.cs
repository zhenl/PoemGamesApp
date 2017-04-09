using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RestSharp;

namespace PoemGamesApp.Components
{
    public class RestUtility
    {
        public static int GetLineCount()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://192.168.0.6/WebApiTest/");
            //client.BaseUrl = new Uri("http://115.28.49.93/webapi/");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("content-type", "application/json");
            

            request.Resource = "api/Poem/GetLineCount";
            var response = client.Execute(request);
            return int.Parse(response.Content);
            
        }

        public static string GetLineContentByIndxe(int idx)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://192.168.0.6/WebApiTest/");
            //client.BaseUrl = new Uri("http://115.28.49.93/webapi/");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("content-type", "application/json");
            
            request.Resource = "api/Poem/GetPoemLineByIndex/" + idx;
            var response = client.Execute<ClientResponse>(request);

            return response.Data.LineContent;
            
        }
    }
}