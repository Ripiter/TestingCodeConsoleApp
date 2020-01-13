using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    class ApiCall
    {
        public  string  Calling()
        {
            string url = "https://icanhazdadjoke.com/";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/plain";
            WebResponse jokeRes = request.GetResponse();

            string joke = string.Empty;

            using (StreamReader sr = new StreamReader(jokeRes.GetResponseStream()))
                joke = sr.ReadToEnd();

            return joke;
        }
    }
}
