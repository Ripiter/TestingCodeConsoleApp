using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TestingCodeConsoleApp
{
    class Program
    {
        static Player player = null;

        static string path = @"c:\peoplesList.json";
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            string content = File.ReadAllText(path);
            if (content != string.Empty)
                people = JsonConvert.DeserializeObject<List<Person>>(content);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("add or see");
                Menu(Console.ReadLine());
                Console.ReadKey();
            }
        }

       

        static void Menu(string userInput)
        {
            switch (userInput)
            {
                case "add":
                    Person person = new Person();
                    Console.WriteLine("first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("last name");
                    string lastName = Console.ReadLine();
                    person.Name = firstName;
                    person.LastName = lastName;

                    people.Add(person);

                    string outPut = JsonConvert.SerializeObject(people);
                    File.WriteAllText(path, outPut);
                    break;
                case "see":
                    foreach (Person per in people)
                    {
                        Console.WriteLine(per.ToString());
                    }
                    break;
                default:
                    break;
            }
        }


        #region Later
        //Console.WriteLine("what is the name of your character");
        //string name = Console.ReadLine();
        //int chapterNumber = 0;
        //while (true)
        //{
        //    Console.WriteLine("what do you want to do next");

        //    Console.WriteLine("0 - Create a new player");
        //    Console.WriteLine("1 - Keep moving");
        //    Console.WriteLine("2 - See stats");
        //    Console.WriteLine("3 - Open inventory");
        //    Console.WriteLine("4 - Save");
        //    Console.WriteLine("5 - Load Player"); ;
        //    Console.WriteLine("6 - Show player items"); ;

        //    string userinput = Console.ReadLine();

        //    switch (userinput)
        //    {
        //        case "0":
        //            player = new Player(name, 100, 20, 20,PlayerType.Hero);
        //            break;
        //        case "1":
        //            if (player == null)
        //            {
        //                Console.WriteLine("player was not created");
        //                continue;
        //            }
        //            player.Hp -= 30;
        //            player.CurrectChapter = "chapter " + chapterNumber;
        //            chapterNumber++;
        //            Adventure();
        //            break;
        //        case "2":
        //            // Shows stats
        //            break;
        //        case "3":
        //            // Opens inventory
        //            break;
        //        case "4":
        //            SaveOrLoadStats.SaveProfile(player);
        //            break;
        //        case "5":
        //            PrintAllCharacters();
        //            string characterName = Console.ReadLine();

        //            if (SaveOrLoadStats.CheckIfCharacterExists(characterName))
        //            {
        //                player = SaveOrLoadStats.LoadPlayer(characterName);
        //                //Inventory.Items = player.PlayerItems;
        //            }
        //            else
        //                Console.WriteLine("Character Doesnt exists");
        //            break;
        //        case "6":
        //            ShowPlayerItems(player);
        //            break;

        //        default:
        //            break;
        //    }

        //    if (player != null)
        //    {
        //        Console.WriteLine("currect player name:" + player.Name);
        //        Console.WriteLine("currect player hp: " + player.Hp);
        //        Console.WriteLine("currect player chapter: " + player.CurrectChapter);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No Character Selected");
        //    }

        //    Console.ReadKey();
        //    Console.Clear();
        //}
        //Console.ReadLine();
        #endregion
        #region BonusRpg
        static void PrintAllCharacters()
        {
            foreach (string saveName in SaveOrLoadStats.ShowAllSaves())
                Console.WriteLine("Character with name: " + saveName);
        }

        static void ShowPlayerItems(Player player)
        {
            foreach (Item item in player.Inventory.Items)
                Console.WriteLine(item.Name);
        }

        static void Adventure()
        {
            IronChestplate ironChestplate = new IronChestplate("Dirty iron chestplate");

            player.AddItemToInventory(ironChestplate);
        }
        #endregion


        #region Database
        // overload operators

        //string connectionString = "Data Source=ZBC-EMA-23111;Initial Catalog=StoredDB; Integrated Security=True";

        //DataTable table = new DataTable();

        //using (SqlConnection conn = new SqlConnection(connectionString))
        //{
        //    conn.Open();
        //    using (SqlCommand cmd = new SqlCommand("select playerName from playerInfo" , conn))
        //    {
        //        SqlDataAdapter ds = new SqlDataAdapter(cmd);
        //        ds.Fill(table);
        //    }
        //    conn.Close();
        //}

        //foreach (DataRow item in table.Rows)
        //{
        //    Console.WriteLine($"user name: { item["playerName"].ToString() }");
        //}






        //// when using cmd.CommandType = CommandType.StoredProcedure exec is not requared
        //string sqlQuery = "ReplaceUserName";


        //Console.WriteLine("write username to be replaced");
        //string oldName = Console.ReadLine();

        //Console.WriteLine("write new username");
        //string newName = Console.ReadLine();


        //using (SqlConnection conn = new SqlConnection(connectionString))
        //{
        //    conn.Open();
        //    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@oldName", oldName));
        //        cmd.Parameters.Add(new SqlParameter("@newName", newName));

        //        //SqlDataAdapter ds = new SqlDataAdapter(cmd);
        //        //ds.Fill(table);
        //        cmd.ExecuteNonQuery();

        //    }
        //    conn.Close();
        //}





        #endregion
        #region Rpg
        //static Player player = null;
        //Console.WriteLine("what is the name of your character");
        //string name = Console.ReadLine();
        //int chapterNumber = 0;
        //while (true)
        //{
        //    Console.WriteLine("what do you want to do next");

        //    Console.WriteLine("0 - Create a new player");
        //    Console.WriteLine("1 - Keep moving");
        //    Console.WriteLine("2 - See stats");
        //    Console.WriteLine("3 - Open inventory");
        //    Console.WriteLine("4 - Save");
        //    Console.WriteLine("5 - Load Player"); ;
        //    Console.WriteLine("6 - Show player items"); ;

        //    string userinput = Console.ReadLine();

        //    switch (userinput)
        //    {
        //        case "0":
        //            player = new Player(name, 100, 20, 20);
        //            break;
        //        case "1":
        //            if (player == null)
        //            {
        //                Console.WriteLine("player was not created");
        //                continue;
        //            }
        //            player.Hp -= 30;
        //            player.CurrectChapter = "chapter " + chapterNumber;
        //            chapterNumber++;
        //            Adventure();
        //            break;
        //        case "2":
        //            // Shows stats
        //            break;
        //        case "3":
        //            // Opens inventory
        //            break;
        //        case "4":
        //            SaveOrLoadStats.SaveProfile(player);
        //            break;
        //        case "5":
        //            PrintAllCharacters();
        //            string characterName = Console.ReadLine();

        //            if (SaveOrLoadStats.CheckIfCharacterExists(characterName))
        //            {
        //                player = SaveOrLoadStats.LoadPlayer(characterName);
        //                //Inventory.Items = player.PlayerItems;
        //            }
        //            else
        //                Console.WriteLine("Character Doesnt exists");
        //            break;
        //        case "6":
        //            ShowPlayerItems(player);
        //            break;

        //        default:
        //            break;
        //    }

        //    if (player != null)
        //    {
        //        Console.WriteLine("currect player name:" + player.Name);
        //        Console.WriteLine("currect player hp: " + player.Hp);
        //        Console.WriteLine("currect player chapter: " + player.CurrectChapter);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No Character Selected");
        //    }

        //    Console.ReadKey();
        //    Console.Clear();
        //}
        #endregion
    }
}


























//            #region The worst Code you will ever see
//            int lenghtOf = 10;

//            int[] numbers = new int[lenghtOf];

//            Random rnd = new Random();
//            for (int i = 0; i < lenghtOf; i++)
//            {
//                numbers[i] = rnd.Next(1, 9);
//            }

//            string temp = "";
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                temp += numbers[i];
//            }

//            float alotofnumbers = float.Parse(temp);
//            double bigNumber = double.Parse(alotofnumbers.ToString());

//            string numbersToString = "";

//            for (int i = 0; i < alotofnumbers.ToString().Length; i++)
//            {
//                if (i == 1)
//                    numbersToString += "/";
//                else if (i == 3)
//                    numbersToString += "/";
//                else if (numbersToString.Length <= 7)
//                    numbersToString += bigNumber.ToString() [rnd.Next(1, bigNumber.ToString().Length)];
//            }


//            DateTime date = DateTime.Parse(numbersToString);

//            Console.WriteLine(date);
//#endregion




//class AccessPoint
//{
//    public string City { get; set; }
//    public string Floor { get; set; }
//    public string Mac { get; set; }
//    public string X { get; set; }
//    public string Y { get; set; }
//}
