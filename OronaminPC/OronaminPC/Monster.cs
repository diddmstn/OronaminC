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
                Console.WriteLine($"  {name}이(가) 결국 우리의 곁을 떠나 무지개 다리를...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"  {exp}의 경험치를 획득하였습니다!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"  {name}이(가) {damage}의 피해를 입고 삶에 대한 미련이 {hp}만큼 남았습니다!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
      
    }
    public class Minion : Monster
    {
        public Minion(int _level, string _name, int _atk, int _hp) : base(1, "미니언", 5, 50) { }
    }
    public class CanonMinion : Monster
    {
        public CanonMinion(int _level, string _name, int _atk, int _hp) : base(2, "대포미니언", 7, 100) { }
    }
    public class EmptyBug : Monster
    {
        public EmptyBug(int _level, string _name, int _atk, int _hp) : base(3, "공허충", 9, 150) { }
    }
    public class MonBlue : Monster
    {
        public MonBlue(int _level, string _name, int _atk, int _hp) : base(4, "블루", 12, 175) { }
    }
    public class MonRed : Monster
    {
        public MonRed(int _level, string _name, int _atk, int _hp) : base(5, "레드", 15, 200) { }
    }
    public class Dragon : Monster
    {
        public Dragon(int _level, string _name, int _atk, int _hp) : base(6, "용", 20, 250) { }
    }
    public class Baron : Monster
    {
        public Baron(int _level, string _name, int _atk, int _hp) : base(7, "바론", 25, 300) { }
    }
}
