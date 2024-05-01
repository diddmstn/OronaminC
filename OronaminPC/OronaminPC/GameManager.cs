using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            SaveLoad saveLoad= new SaveLoad();
            if (File.Exists("./Save/SaveFile.json"))
            {
                JObject jobject = SaveLoad.Read();//저장한 파일과 이름이 같은지 확인
                if (player.name == jobject["playerName"].ToString())
                {
                    SaveLoad.Load(player, jobject);
                }
            };
            while (true)
            {
                SaveLoad.Save(player);//save 
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
                        player.Inventory();
                        break;
                    case 3:
                        player.Shop();
                        break;
                    case 4:
                        dungeon.EnterDungeon(ref player);
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
