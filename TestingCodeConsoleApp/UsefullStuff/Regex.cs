using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace TestingCodeConsoleApp.UsefullStuff
{
    class RegexTesting
    {
        // Files for regex are in the usefull notes folder
        // Later read dummy file from here and use regex 

        public void A()
        {
            string pattern = @"https?:\/\/(www\.)?(\w+)(\.\w+)";
            string input = @"https://www.google.com http://coreyms.com https://youtube.com https://www.nasa.gov";
            RegexOptions options = RegexOptions.Multiline;
            List<string> values = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}
