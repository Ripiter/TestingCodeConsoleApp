using System;
using System.Net;
using System.IO;

namespace TestingCodeConsoleApp
{
    class JsonTesting
    {
        public string Calling()
        {
            string html = string.Empty;
            string url = "http://api.openweathermap.org/data/2.5/weather?appid=7b14dbf4bb8322258a8b3e5e43ba0d3e&q=Roskilde";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }
        public string GetBetween(string strSource, string strStart = "temp\":", string strEnd = ",")
        {
            int start, end;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                start = strSource.IndexOf(strStart, 0) + strStart.Length;
                end = strSource.IndexOf(strEnd, start);
                //return strSource.Substring(Start, End - Start);
                double a =  ConvertToCelsius( strSource.Substring(start, end - start) );
                return a + "c";
            }
            else
            {
                return "";
            }
        }



        public double ConvertToCelsius(string kelvin)
        {
            double kelving;

            if (kelvin.Contains("."))
                 kelvin = kelvin.Replace('.', ',');

            kelving = double.Parse(kelvin);
            return Math.Round(kelving - 273.15, 3);
        }

        // dynamic a = JsonConvert.DeserializeObject<dynamic>("id");
        public void Main()
        {
            string temp;
            JsonTesting json = new JsonTesting();

            temp = json.Calling();
            //  json.getBetween(temp);
            Console.WriteLine(json.GetBetween(temp));
            Console.WriteLine();
        }
    }
}
