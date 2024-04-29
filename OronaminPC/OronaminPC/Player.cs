namespace OronaminPC
{
    internal class Player
    {
        public string name { get; set; }
        public int level { get; set; }
        public int attack { get; set; }
        public int defense {  get; set; }
        public int health { get; set; }
        public int gold { get; set; }
        
        public Player(string _name,int _level, int _attack, int _defense, int _health, int _gold)
        {
            name = _name;
            level = _level; 
            attack = _attack;   
            defense = _defense;
            health = _health;
            gold = _gold;   
        }
        void Status()
        {
            Console.WriteLine($"Lv. {level.ToString("00")}");
            Console.WriteLine($"{name} (전사)");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
            Console.WriteLine($"체  력 : {health}");
            Console.WriteLine($"Gold   : {gold}\n");
            Console.WriteLine($"0. 나가기");
        }
       
    }
}