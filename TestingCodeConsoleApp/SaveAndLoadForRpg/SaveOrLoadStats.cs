using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;

namespace TestingCodeConsoleApp
{
    static class SaveOrLoadStats
    {
        static string savePath = Path.GetTempPath();
        static string characterName = string.Empty;
       
        public static void SaveProfile(Player player)
        {
            characterName = player.Name;
            string jsonString = SerializeToString(player);
            EncryptJson(jsonString);
        }

        private static string SerializeToString(Player player)
        {
            string jString = JsonConvert.SerializeObject(player);
            return jString;
        }

        private static void EncryptJson(string jsonString)
        {
            // Do encryption
            SaveStringToFile(jsonString);
        }

        private static void SaveStringToFile(string textToSave)
        {
            if (Directory.Exists(savePath + "textRpg"))
            {
                File.WriteAllText(savePath + "/textRpg/"+characterName+".json", textToSave);
            }
            else
            {
                Directory.CreateDirectory(savePath + "textRpg");
                File.WriteAllText(savePath + "/textRpg/"+characterName+".json", textToSave);
            }
        }



        public static Player LoadPlayer(string characterToLoad)
        {
            string ecyptedString = ReadFromFile(characterToLoad);
            string decrypted = DecryptString(ecyptedString);
        
            return SerializeJson(decrypted);
        }

        private static Player SerializeJson(string decryptedString)
        {
            Player player = JsonConvert.DeserializeObject<Player>(decryptedString);
            return player;
        }

        private static string DecryptString(string encryptedString)
        {
            return encryptedString;
        }

        private static string ReadFromFile(string nameOfCharacter)
        {
            if(Directory.Exists(savePath + "textRpg") && File.Exists(savePath + "/textRpg/"+nameOfCharacter+".json"))
                return File.ReadAllText(savePath + "/textRpg/"+nameOfCharacter+".json");
            return null;
        }

        public static string[] ShowAllSaves()
        {
            string[] files = Directory.GetFiles(savePath + "/textRpg");
            string[] allProfiles = new string[files.Length];
            int pos = 0;
            foreach (string file in files)
            {
                allProfiles[pos] = Path.GetFileNameWithoutExtension(file);
                pos++;
            }
            return allProfiles;
        }


        public static bool CheckIfCharacterExists(string name)
        {
            if (Directory.Exists(savePath + "textRpg") && File.Exists(savePath + "/textRpg/" + name + ".json"))
                return true;
            return false;
        }
    }

}
