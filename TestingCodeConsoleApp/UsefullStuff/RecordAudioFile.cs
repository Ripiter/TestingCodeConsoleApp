using System;
using System.Runtime.InteropServices;
using System.IO;


namespace TestingCodeConsoleApp.UsefullStuff
{
    class RecordAudioFile
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public void Record()
        {
            string path = Path.GetTempPath(); ;
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
            Console.WriteLine("recording, press Enter to stop and save ...");

            Console.ReadLine();
            mciSendString("save recsound " + path + "result.wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
            Console.WriteLine("saved");
            Console.ReadKey();
        }
    }
}
