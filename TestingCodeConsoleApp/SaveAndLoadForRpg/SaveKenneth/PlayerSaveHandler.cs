using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    class PlayerSaveHandler
    {
        public static void SaveCurrentPlayer(Player player)
        {
            PlayerSave.SavePlayer(player);
        }

        public static string[] ShowAllSaves()
        {
            string[] files = Directory.GetFiles(/*savePath*/ Path.GetTempPath()+ "/textRpg");
            return null;
        }

        public static Player Load(string characterToLoad)
        {
            return null;
        }
    }
}
