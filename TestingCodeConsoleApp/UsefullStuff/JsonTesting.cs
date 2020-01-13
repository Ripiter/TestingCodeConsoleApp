using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;

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

        
        public void ReadingFromStream()
        {
            string s = string.Empty;
            string path = @"c:\newJsonString.json";

            using (Stream readingStream = File.OpenRead(path))
            {
                byte[] temp = new byte[10];
                UTF8Encoding encoding = new UTF8Encoding(true);

                int len = 0;

                while ((len = readingStream.Read(temp, 0, temp.Length)) > 0)
                {
                    // Converts to string.
                    s += encoding.GetString(temp, 0, len);
                }
            }
        }

        //string path = @"c:\textRpg.json";
        //string chapter = "chapter_1";
        //string jsonString = File.ReadAllText(path);
        //JObject json = JObject.Parse(jsonString);
        //string print = "";




        //JToken jToken = json[chapter];
        //print = (string)jToken["text"];
        //Console.WriteLine(print);




        //Console.WriteLine("Do combat");



        //chapter = "chapter_2";
        //jToken = json[chapter];
        //print = (string)jToken["text"];
        //Console.WriteLine(print);



        //    string path = @"C:\Usefull Notes\jsonFormated.json";
        //    string[] macFound = new string[] { "ac:a3:1e:f5:f0:c3", "36:f6:4b:af:f6:7c", "a" };

        //            using (StreamReader sr = new StreamReader(path))
        //            {
        //                string json = sr.ReadToEnd();

        //    JObject jObject = JObject.Parse(json);
        //    JToken jUser;
        //    string city;
        //                for (int i = 0; i<macFound.Length; i++)
        //                {
        //                        jUser = jObject[macFound[i]];
        //                    try
        //                    {
        //                        city = (string) jUser["city"];
        //}
        //                    catch (Exception e)
        //                    {
        //                        continue;
        //                    }

        //                    string floor = (string)jUser["floor"];
        //string x = (string)jUser["x"];
        //string y = (string)jUser["y"];

        //Console.WriteLine("City : " + city);
        //                    Console.WriteLine("Floor : " + floor);
        //                    Console.WriteLine("X : " + x);
        //                    Console.WriteLine("Y:" + y);
        //                    Console.WriteLine("");
        //                }
        //            }
        //            Console.ReadKey();
    }
}
