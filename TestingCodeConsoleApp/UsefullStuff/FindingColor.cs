using System;
using System.IO;
using System.Net;

namespace TestingCodeConsoleApp.UsefullStuff
{
    class FindingColor
    {




        public string Calling(string hex)
        {
            try
            {

                string html = string.Empty;
                hex = "https://www.htmlcsscolor.com/hex/" + hex;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(hex);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                return html;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetBetween(string strSource, string strStart = "known color: ", string strEnd = ".")
        {
            int start, end;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                start = strSource.IndexOf(strStart, 0) + strStart.Length;
                end = strSource.IndexOf(strEnd, start);
                //return strSource.Substring(Start, End - Start);
                //double a = ConvertToCelsius(strSource.Substring(start, end - start));
                return strSource.Substring(start, end - start);
            }
            else
            {
                return GetBetweenUnknowColor(strSource);
            }
        }

        private string GetBetweenUnknowColor(string strSource, string strStart = "approx ", string strEnd = ".")
        {
            int start, end;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                start = strSource.IndexOf(strStart, 0) + strStart.Length;
                end = strSource.IndexOf(strEnd, start);

                return strSource.Substring(start, end - start);
            }
            else
            {
                return "Not Found";
            }
        }

        void InMain()
        {
            FindingColor colorFinder = new FindingColor();

            // temp is our website in a string
            string temp = colorFinder.Calling("FF6346");

            Console.WriteLine(colorFinder.GetBetween(temp));

        }
    }
}
