using static System.Net.Mime.MediaTypeNames;
using System;

namespace OronaminPC
{
    internal class Dungeon
    {
        int level = 1;
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
            Console.WriteLine("이나 한판 해야겠구만");
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
            int monsterCount = random.Next(1, 4);
            Monster[] battleMonster = new Monster[monsterCount];

            for (int i = 0; i < monsterCount; i++)//배열에 몬스터 추가
            {
                battleMonster[i] = monster[random.Next(1, monster.Count())];
                Console.WriteLine(battleMonster[i].name);
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
                            if(index == -2)
                            {
                                Console.WriteLine("  다시.");
                                break;
                            }
                            Console.WriteLine($"  {player.name} 의 공격!");
                            Console.Write($"  Lv.{monsters[index].level} {monsters[index].name} 을(를) 맞췄습니다. ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($" [데미지 : {damage}]");
                            Console.ForegroundColor = ConsoleColor.White;
                            PlrAttack(monsters[index], damage);
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
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (monsters[i].IsDead != true)
                        {
                            Console.WriteLine($"  {monsters[i].name} 의 공격!");
                            Console.Write($"  {player.name} 을(를) 맞췄습니다. ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($" [데미지 : {monsters[i].atk - Math.Ceiling(monsters[i].atk * (player.defense * 0.01))}]");
                            Console.ForegroundColor = ConsoleColor.White;
                            player.health -= monsters[i].atk - (int)(Math.Ceiling(monsters[i].atk * (player.defense * 0.01))); // 체력이 0 이하로 떨어지면 0으로 고정
                            if(player.health < 0)
                            {
                                player.health = 0;
                            }
                        }
                        PlrDeathCheck(player, ref game);
                    }
                    NextTurn(ref turn);
                }
            }
            if (game >= 1)
            {
                cu.Defeat();
            }
            else if(game == -1) 
            {
                cu.Victory();
            }
        }

        public void NextTurn(ref int turn)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  턴을 바꿀 차례야! Enter를 눌러보자!");
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


        public void PlrAttack(Monster monster, int damage)
        {
            int temp = monster.hp; // 쳐맞기전 몬스터 체력
            monster.TakeDamage(damage);
        }
    }
}
