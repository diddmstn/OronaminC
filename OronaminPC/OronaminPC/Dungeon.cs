using static System.Net.Mime.MediaTypeNames;
using System;
using System.Reflection;
using System.Xml.Linq;

namespace OronaminPC
{
    internal class Dungeon
    {
        int Dungeonlevel = 1;
        int getExp = 0;
        List<Monster> monster = new List<Monster>();

        public Dungeon()
        {
            monster.Add(new Monster(1, "미니언", 5, 50));
            monster.Add(new Monster(2, "대포미니언", 7, 100));
            monster.Add(new Monster(3, "공허충", 9, 150));
            monster.Add(new Monster(4, "블루", 12, 175));
            monster.Add(new Monster(5, "레드", 15, 200));
            monster.Add(new Monster(6, "용", 20, 250));
            monster.Add(new Monster(7, "바론", 25, 300));

        }
        public void EnterDungeon(ref Player player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                   <<던전 입장>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("   던전으로 들어가 몬스터와 전투를 진행하실 수 있습니다.\n");
            Console.WriteLine("");
            Console.Write("  1. ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("RPG 게임");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("이나 한판 해야겠구만 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"(현재 진행 : {Dungeonlevel}층)");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("  >>");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 1);

            switch (number)
            {
                case 0:
                    return;
                case 1:
                    BattleBoard(ref player);
                    break;
                default:
                    Console.WriteLine("　똑디 말해라 문디 자슥아 (ㅡ∧ㅡ)");
                    Thread.Sleep(1000);
                    this.EnterDungeon(ref player);
                    break;
            }
        }
        public Monster[] GenerateMonster()//몬스터 생성
        {
            Random random = new Random();
            int monsterCount = random.Next(1, 5);
            Monster[] battleMonster = new Monster[monsterCount];

            for (int i = 0; i < monsterCount; i++)//배열에 몬스터 추가
            {
                battleMonster[i] = monster[random.Next(Dungeonlevel - 1, Dungeonlevel + 1)].ReturnDeepCopy();
                
            }

            return battleMonster;

        }

        public void BattleBoard(ref Player player)
        {
            int pHpStart = player.health;
            int game = 0; // 1일때 패배 -1일때 승리 -> 필요한가 모르곘네
            int turn = 0;
            ConsoleUtility cu = new ConsoleUtility();
            Monster[] monsters = GenerateMonster();
            
            while (game == 0)
            {
                Console.Clear();
                cu.BattleInfo(ref player, monsters, pHpStart);
                if (turn % 2 == 0)
                {
                    // 플레이어 턴
                    string action = cu.Action();
                    switch (action)
                    {
                        case "1":
                            // 공격
                            int index = cu.SelectMonster(player, monsters) - 1;
                            int damage = player.MonsterAttack();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<League of Text RPG>>▧▧▧▧▧▧▧▧▧▧");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("                         B A T T L E");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            if (index == -2)
                            {
                                Console.WriteLine("  다시.");
                                break;
                            }
                            Console.WriteLine($"  {player.name} 의 공격!");
                            Console.Write($"  Lv.{monsters[index].level} {monsters[index].name} 을(를) 맞췄습니다. ");
                            bool crit = player.IsCritical();
                            if (crit == true)
                            {
                                damage = damage * 2;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("  크리티컬!!");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"  [데미지 : {damage}]");
                            Console.ForegroundColor = ConsoleColor.White;
                            PlrAttack(monsters[index], damage, ref player);
                            NextTurn(ref turn);
                            break;
                        case "2":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<League of Text RPG>>▧▧▧▧▧▧▧▧▧▧");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("                         B A T T L E");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            if (player.manaPoint >= 10)
                            {
                                player.manaPoint -= 10;
                                SkillAttack(ref player, monsters, pHpStart);
                            }
                            else
                            {
                                Console.WriteLine("  스킬 사용에 필요한 마나가 부족하여 공격 타이밍을 놓쳤습니다...");
                            }
                            NextTurn(ref turn);
                            break;
                        default:
                            Console.WriteLine("  다시.");
                            break;
                    }
                }
                else
                {
                    // 몬스터 턴
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<League of Text RPG>>▧▧▧▧▧▧▧▧▧▧");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("                         B A T T L E");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    int vic = 0;
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (monsters[i].IsDead != true)
                        {
                            Console.WriteLine($"  {monsters[i].name} 의 공격!");
                            bool dodge = player.IsDodge();
                            if (dodge == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("  회피 성공!!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write($"  {player.name} 을(를) 맞췄습니다. ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"  [데미지 : {monsters[i].atk - Math.Ceiling(monsters[i].atk * (player.defense * 0.01))}]");
                                Console.ForegroundColor = ConsoleColor.White;
                                player.health -= monsters[i].atk - (int)(Math.Ceiling(monsters[i].atk * (player.defense * 0.01))); // 체력이 0 이하로 떨어지면 0으로 고정
                            }
                            
                            if(player.health < 0)
                            {
                                player.health = 0;
                            }
                        }
                        else if (monsters[i].IsDead == true) // 승리 조건 확인 코드
                        {
                            vic++;
                        }
                        if (vic == monsters.Length)
                        {
                            game = -1;
                        } // 여기까지
                        PlrDeathCheck(player, ref game);
                    }
                    NextTurn(ref turn);
                }
            }
            if (game >= 1)
            {
                cu.Defeat();
                player.manaPoint += 10;
            }
            else if(game == -1) 
            {
                cu.Victory(ref player,monsters.Length, getExp);
                if(Dungeonlevel!=6)
                {
                    Dungeonlevel++;//던전 레벨증가
                }
            }
        }

        public void SkillAttack(ref Player player, Monster[] monsters, int pHpStart)
        {
            int damage;
            ConsoleUtility cu = new ConsoleUtility();
            if (player.job == "단골학생")
            {
                for (int index = 0; index < monsters.Length; index++)
                {
                    if (monsters[index].IsDead == false)
                    {
                        Console.Write($"  Lv.{monsters[index].level} {monsters[index].name} 을(를) 맞췄습니다. ");
                        damage = player.Skill();
                        bool crit = player.IsCritical();
                        if (crit == true)
                        {
                            damage = damage * 2;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("  크리티컬!!");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"  [데미지 : {damage}]");
                        Console.ForegroundColor = ConsoleColor.White;
                        PlrAttack(monsters[index], damage, ref player);
                    }
                }
            }
            else if (player.job == "게임폐인")
            {
                int index = cu.SelectMonster(player, monsters) - 1;
                int attChance = new Random().Next(1, 6);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  {attChance}번 공격!!");
                Console.ResetColor();
                for (int i = 0; i < attChance; i++)
                {
                    Console.Write($"  Lv.{monsters[index].level} {monsters[index].name} 을(를) 맞췄습니다. ");
                    damage = player.Skill();
                    bool crit = player.IsCritical();
                    if (crit == true)
                    {
                        damage = damage * 3;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("  크리티컬!!");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"  [데미지 : {damage}]");
                    Console.ForegroundColor = ConsoleColor.White;
                    PlrAttack(monsters[index], damage, ref player);
                }
            }
            else if (player.job == "스트리머")
            {
                int attempt = 0;
                for (int index = 0; index < monsters.Length; index++)
                {
                    if (monsters[index].IsDead == false)
                    {
                        attempt++;
                        Console.Write($"  Lv.{monsters[index].level} {monsters[index].name} 을(를) 맞췄습니다. ");
                        damage = player.Skill();
                        bool crit = player.IsCritical();
                        if (crit == true)
                        {
                            damage = damage * 2;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("  크리티컬!!");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"  [데미지 : {damage}]");
                        Console.ForegroundColor = ConsoleColor.White;
                        PlrAttack(monsters[index], damage, ref player);
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"후원을 받아 기분이 좋아진 당신!!\n 체력을 {attempt * 5}만큼 흡수합니다.");
                if ((player.health + (attempt * 5)) <= pHpStart)
                {
                    player.health += (attempt * 5);
                }
                else
                {
                    player.health = pHpStart;
                }
            }
        }

        public void NextTurn(ref int turn)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  Enter를 눌러보자!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            turn++;
        }

        public void LoseCheck(bool lose, ref int game)
        {
            if(lose == true)
            {
                game++;
            }
        }
        public void PlrDeathCheck(Player player, ref int game)
        {
            bool temp;
            if(player.health <= 0)
            {
                LoseCheck(temp = true, ref game);
            }
            else
            {
                LoseCheck(temp = false, ref game);
            }
        }


        public void PlrAttack(Monster monsters, int damage, ref Player player)
        {
            int temp = monsters.hp; // 쳐맞기전 몬스터 체력
            if (temp > 0)
            {
                getExp = monsters.TakeDamage(damage);
                player.LevelUpCheck(getExp);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"  {monsters.name}은(는) 이미 싸늘히 식었습니다... 그만하세요...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
