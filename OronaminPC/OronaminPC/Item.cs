﻿using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace OronaminPC
{

    public class Item
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int health { get; set; }
        public int manaPoint { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public Type type { get; set; }

        public bool isEquip { get; set; }
        public bool IsPurchase { get; set; }

        public enum Type
        {
            마우스,
            키보드,
            헤드셋,
            음료수
        }

        public Item(string _name, Type _type, string _description, int _price, int _attack, int _defense, int _health, int _manaPoint)
        {
            name = _name;
            attack = _attack;
            defense = _defense;
            health = _health;
            manaPoint = _manaPoint;
            price = _price;
            description = _description;
            type = _type;

            IsPurchase = false;
        }

        internal void PrintItemInventory(string Itemname, bool withNumber = false, int idx = 0)
        {
            Console.Write("  - ");
            if (withNumber)
            {
                Console.Write($"{idx} ");
            }
            if (isEquip)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("E");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("]");
                Console.ResetColor();
                Console.Write(ConsoleUtility.PadRightForMixedText(name, 12));
            }
            else Console.Write(ConsoleUtility.PadRightForMixedText(name, 15));

            Console.Write(" | ");
            Console.WriteLine(description);


            Console.Write("    | ");
            if (attack != 0)
            {
                Console.Write($"공격력 {(attack >= 0 ? "+" : "")}{attack}");
                Console.Write(" | ");
            }
            if (defense != 0)
            {
                Console.Write($"방어력 {(defense >= 0 ? "+" : "")}{defense}");
                Console.Write(" | ");
            }
            if (health != 0)
            {
                Console.Write($"체  력 {(health >= 0 ? "+" : "")}{health}");
                Console.Write(" | ");
            }
            if (manaPoint != 0)
            {
                Console.Write($"마  력 {(manaPoint >= 0 ? "+" : "")}{manaPoint}");
                Console.Write(" | ");
            }
            Console.WriteLine("");

        }

        public void ToggleEquipStatus()
        {
            isEquip = !isEquip;
        }

        //public Item UsePotion(ref Player player)
        //{
        //    List<Item> potions = new List<Item>(); // 소비 아이템만 들어갈 리스트
        //    foreach (Item item in player.inven)
        //    {
        //        if (item.type.ToString() == "음료수")
        //        {
        //            potions.Add(item);
        //        }
        //    }
        //    foreach (Item item in potions)
        //    {
        //        PrintItemInventory(item.name, true);
        //    }

        //    Console.WriteLine("뭐 마실래?");
        //    string userInput = Console.ReadLine();
        //    int index = ConsoleUtility.InputCheck(userInput, potions.Count) - 1;
        //    if (index < 0)
        //    {
        //        Console.WriteLine("당신은 소중한 기회를 날리셨습니다. 목마름은 책임지지 않아요^^");
        //        Item temp = new Item("", type, "", 0, 0, 0, 0, 0);
        //        return temp;
        //    }
        //    else
        //    {
        //        // 먹기
        //        player.ItemEquip(potions[index]);
        //        potions[index].
        //        return potions[index];
        //    }
        //}

        public void PrintItemShop(string itemname, bool withNumber = false, int idx = 0)
        {
            Console.Write("  - ");
            if (withNumber)
            {
                Console.Write("{0} {1} ", idx, itemname);
            }
            else Console.Write(ConsoleUtility.PadRightForMixedText(name, 13));

            Console.Write(" | ");
            Console.Write(ConsoleUtility.PadRightForMixedText(description, 16));
            Console.Write(" | ");

            if (IsPurchase)
            {
                Console.WriteLine("구매완료");
            }
            else
            {
                ConsoleUtility.PrintHighlight("", price.ToString(), " G");
            }

            Console.Write("      | ");
            if (attack != 0)
            {
                Console.Write($"공격력 {(attack >= 0 ? "+" : "")}{attack}");
                Console.Write(" | ");
            }
            if (defense != 0)
            {
                Console.Write($"방어력 {(defense >= 0 ? "+" : "")}{defense}");
                Console.Write(" | ");
            }
            if (health != 0)
            {
                Console.Write($"체  력 {(health >= 0 ? "+" : "")}{health}");
                Console.Write(" | ");
            }
            if (manaPoint != 0)
            {
                Console.Write($"마  력 {(manaPoint >= 0 ? "+" : "")}{manaPoint}");
                Console.Write(" | ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public void Purchased()
        {
            IsPurchase = true;
        }

        
    }
}
