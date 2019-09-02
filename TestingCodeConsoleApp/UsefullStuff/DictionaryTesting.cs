using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingCodeConsoleApp
{
    class DictionaryTesting
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        public DictionaryTesting()
        {
            dict.Add(420, "boy");
            dict.Add(404, "boy");
            dict.Add(666, "boy2");
            dict.Add(123, "boy3");
            dict.Add(1, "boy4");
            dict.Add(2, "boy5");
            dict.Add(3, "boy6");
        }

        public void PrintF()
        {
            dict.Add(dict.Keys.Count + 1 , "boy6");

            for (int i = 0; i < dict.Count; i++)
            {
                
                if (dict[dict.Keys.ElementAt(i)] == "boy")
                {
                    Console.WriteLine("Boy with key " +  dict.Keys.ElementAt(i));
                }

                Console.WriteLine("Key {0}, value: {1}",
                    dict.Keys.ElementAt(i),dict[ dict.Keys.ElementAt(i)] );
            }
        }
        //Code that goes into main
        private void Main()
        {
            DictionaryTesting dic = new DictionaryTesting();
            while (true)
            {
                dic.PrintF();
                Console.ReadKey(true);
            }
        }

        public void LoopDictionary()
        {
            List<string> list = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int redAmount = 0;
            int blueAmount = 0;
            int greenAmount = 0;
            list.Add("red");
            list.Add("red");
            list.Add("blue");
            list.Add("blue");
            list.Add("blue");
            list.Add("green");

            int listCounter = list.Count;
            for (int i = 0; i < listCounter; i++)
            {
                if (list.Contains("red"))
                {
                    list.Remove("red");
                    redAmount++;
                }

                if (list.Contains("blue"))
                {
                    list.Remove("blue");
                    blueAmount++;
                }
            }
            dic.Add("red", redAmount);
            dic.Add("blue", blueAmount);

            for (int i = 0; i < dic.Values.Count; i++)
            {
                Console.WriteLine($"Color {dic.Keys.ElementAt(i)} with value {dic[dic.Keys.ElementAt(i)]}");
            }
        }
    }
}
