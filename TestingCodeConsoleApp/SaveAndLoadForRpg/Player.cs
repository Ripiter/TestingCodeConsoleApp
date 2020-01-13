using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    enum PlayerType
    {
        Hero,
        Demon,
        Undead
    }
    class Player
    {
        public string CurrectChapter { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public int CritChance
        {
            get { return critChance; }
            set { critChance = value; }
        }

        private string name;
        private int hp;
        private int mana;
        private int critChance;

        public Inventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        Inventory inventory;
        public void AddItemToInventory(Item item)
        {
            inventory.AddItemToList(item);
        }

        private PlayerType typeOfPlayer;

        public PlayerType TypeOfPlayer
        {
            get { return typeOfPlayer; }
            set { typeOfPlayer = value; }
        }


        public Player(string name, int hp, int mana, int critChance, PlayerType type)
        {
            inventory = new Inventory();
            TypeOfPlayer = type;
            //inventory.AddedToList += AddToPlayerInvetory;
            Name = name;
            Hp = hp;
            Mana = mana;
            CritChance = critChance;
        }
    }
}
