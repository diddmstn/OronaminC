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
        int Attack(int monsterHealth)//몬스터 체력
        {
            double errorValue = Math.Ceiling((double)(attack/10)); //공격력 오차값, 오차가 소수점이라면 무조건 올림 처리
            Random random = new Random();

            int Damage = random.Next(attack-(int)errorValue, attack+(int)errorValue);

            return Damage;
        }


    }
}