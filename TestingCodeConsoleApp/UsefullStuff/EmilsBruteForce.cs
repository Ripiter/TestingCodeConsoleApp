using System;

namespace TestingCodeConsoleApp
{
    class EmilsBruteForce : IBruteForce
    {
        /// <summary>
        /// The name of the bruteforce
        /// </summary>
        public string Name => "Simple BruteForce";

        public int MaxChars => 10;

        private readonly int charCount = 125;

        /// <summary>
        /// The password which the bruteforce is trying to guess
        /// </summary>
        private string passwordToGuess;
        private int[] chars;

        public void Initialise(string password, int maxNmber)
        {
            passwordToGuess = password;
            chars = new int[maxNmber];
        }

        public void DisplayPassword()
        {
            Console.WriteLine(GetCurGuess());
        }

        private string GetCurGuess()
        {
            string val = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 0)
                    continue;

                val += (char)chars[i];
            }
            return val;
        }

        private void Next()
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != charCount)
                {
                    chars[i]++;
                    ResetAfter(i);
                    return;
                }
            }
        }

        private void ResetAfter(int index)
        {
            if (index == 0)
                return;

            for (int i = index - 1; i >= 0; i--)
            {
                chars[i] = 0;
            }
        }

        public bool CheckPassword()
        {
            if (passwordToGuess == GetCurGuess())
            {
                timer = DateTime.Now - start;
                Console.WriteLine(timer);
                Console.WriteLine(GetCurGuess());
                return true;
            }

            return false;
        }

        DateTime start;
        TimeSpan timer;

        public void Run()
        {
            start = DateTime.Now;
            bool guessed = false;

            while (!guessed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Next();
                guessed = CheckPassword();
                DisplayPassword();
            }
        }

        public void Main()
        {
            EmilsBruteForce force = new EmilsBruteForce();
            //force.FirstDef();
            force.Initialise("abc", 6);
            force.Run();
        }
    }
}
