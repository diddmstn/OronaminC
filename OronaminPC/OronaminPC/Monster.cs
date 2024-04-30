using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OronaminPC
{
    public class Monster
    {
        public int level { get; set; }
        public string name { get; set; }
        public int atk { get; set; }
        public int hp { get; set; }
        public int exp { get; }

        public bool IsDead => hp <= 0;

        public Monster(int _level, string _name, int _atk, int _hp)
        { 
            level = _level;
            name = _name;
            atk = _atk;
            hp = _hp;
            exp = _level;
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;

            if (IsDead)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"  {name}이(가) 숨을 거뒀습니다. RIP...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"  {exp}의 경험치를 획득하였습니다!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"  {name}이(가) {damage}의 피해를 입고 체력 {hp}이(가) 남았습니다!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public class Minion : Monster
        {
            public Minion(int _level, string _name, int _atk, int _hp) : base(1, "미니언", (new Random().Next(2, 7)), 50) { }
        }
        public class CanonMinion : Monster
        {
            public CanonMinion(int _level, string _name, int _atk, int _hp) : base(2, "대포미니언", (new Random().Next(4, 9)), 100) { }
        }
        public class EmptyBug : Monster
        {
            public EmptyBug(int _level, string _name, int _atk, int _hp) : base(3, "공허충", (new Random().Next(6, 11)), 150) { }
        }
        public class MonBlue : Monster
        {
            public MonBlue(int _level, string _name, int _atk, int _hp) : base(4, "블루", (new Random().Next(9, 15)), 175) { }
        }
        public class MonRed : Monster
        {
            public MonRed(int _level, string _name, int _atk, int _hp) : base(5, "레드", (new Random().Next(12, 18)), 200) { }
        }
        public class Dragon : Monster
        {
            public Dragon(int _level, string _name, int _atk, int _hp) : base(6, "용", (new Random().Next(15, 25)), 250) { }
        }
        public class Baron : Monster
        {
            public Baron(int _level, string _name, int _atk, int _hp) : base(7, "바론", (new Random().Next(20, 30)), 300) { }
        }
    }
}
