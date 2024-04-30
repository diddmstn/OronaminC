namespace OronaminPC
{
    
    public class Item
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }    
        public int health { get; set; }    
        public int manaPoint { get; set; }    
        public int gold { get; set; }
        public string description { get; set; }

        public Item(string name, int attack, int defense, int health, int manaPoint, int gold, string description)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.health = health;
            this.manaPoint = manaPoint;
            this.gold = gold;
            this.description = description;
        }
    
        public enum Type
        {
            투구,
            갑옷,
            신발,
            무기
        }
    }
    //public class Potion : Item
    //{
    //    string name = "asasd";
    //    public Potion(string name, int attack, int defense, int health, int manaPoint, int gold, string description) : base(name, 0,0,0,0,0,"Aaa")
    //    {
    //        //public Minion(int _level, string _name, int _atk, int _hp) : base(1, "미니언", 5, 50) { }
    //    }

    //}
}
