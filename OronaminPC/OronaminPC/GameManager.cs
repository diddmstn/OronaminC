using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OronaminPC
{
    internal class GameManager
    {
        public static void Init()
        {
            ConsoleUtility cu = new ConsoleUtility();
            string[] str = cu.Title();
            Player player = new Player(str[0], str[1]);
            Dungeon dungeon = new Dungeon();
            while (true)
            {
                int menu = cu.Menu();
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Console.WriteLine("               다신 오지 마세요~! (つ ^^)つ ");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);
                        return;
                    case 1:
                        player.Status();
                        break;
                    case 2:
                        Console.WriteLine("  지금 영하 18도에요 ^^"); // 인벤토리 추가 후 삭제 예정
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        Console.WriteLine("  경찰서는 112입니다 ^^7"); // 샵 추가 후 삭제 예정
                        Thread.Sleep(1000);
                        break;
                    case 4:
                        dungeon.EnterDungeon(player);
                        break;
                    default:
                        Console.WriteLine("  손님~ 주문은 똑바로 하셔야죠~");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}
