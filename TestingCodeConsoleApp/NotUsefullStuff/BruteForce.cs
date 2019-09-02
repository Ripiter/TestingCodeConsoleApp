using System;

namespace TestingCodeConsoleApp
{
    public class BruteForce
    {
        char[] characters = new char[] { 'a', 'b', 'c', 'd' };
        byte[] numbers = new byte[] { 0, 1,2, 3, 4 };

        //string passwordGuess = "";
        string password = "ab0";



        public void FirstDef()
        {
            // From 0 => 9
            for (int i = 0; i < numbers.Length; i++)
            {
                CheckPass(numbers[i].ToString());
            }

            // From a -> z
            for (int i = 0; i < characters.Length; i++)
            {
                CheckPass(characters[i].ToString());
            }

            // From 00 => 99
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    CheckPass(numbers[i].ToString() + numbers[j].ToString());
                }
            }

            // From 0a => 0z
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    CheckPass(numbers[i].ToString() + characters[j].ToString());
                }
            }



        }
        private void CheckPass(string tryPass)
        {
            Console.WriteLine(tryPass);
            if (tryPass == password)
            {
                Console.WriteLine("Done");
                Console.ReadKey(true);
            }
        }

    }
}
