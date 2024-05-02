using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OronaminPC
{
    public class Shop
    {
        List<Item> item = new List<Item>();
        public Shop()
        {
            item.Add(new Item("볼 마우스", Item.Type.마우스, "샷건치면 볼 사라짐", 700, 7, 0, 0, 0));
            item.Add(new Item("레이저 마우스", Item.Type.마우스, "고양이 소환 가능", 1600, 14, 0, 0, 0));
            item.Add(new Item("게이밍 마우스", Item.Type.마우스, "게임은 역시 장비빨", 4300, 28, 0, 0, 0));
            item.Add(new Item("다이소 키보드", Item.Type.키보드, "쒸프트 키까 안빠쪄요", 500, 0, 10, 0, 0));
            item.Add(new Item("사무용 키보드", Item.Type.키보드, "일하기 싫을 때 흉기로", 1500, 0, 20, 0, 0));
            item.Add(new Item("게이밍 키보드", Item.Type.키보드, "역시 돈도 재능이다", 4000, 0, 40, 0, 0));
            item.Add(new Item("고장난 헤드셋", Item.Type.헤드셋, "한 쪽이 안들린다", 1000, 0, 0, 10, 0));
            item.Add(new Item("저급한 헤드셋", Item.Type.헤드셋, "지지직은 BGM이겠지..", 2500, 0, 0, 20, 10));
            item.Add(new Item("게이밍 헤드셋", Item.Type.헤드셋, "적의 숨소리가 들린다", 6000, 0, 0, 35, 25));
            item.Add(new Item("콜  라", Item.Type.음료수, "PC방 콜라 국룰이지", 300, 0, 0, 30, 0));
            item.Add(new Item("핫식스", Item.Type.음료수, "하루종일 게임 쌉가능", 500, 0, 0, 30, 10));
            item.Add(new Item("레드불", Item.Type.음료수, "이거슨 합법적 각성제", 1500, 3, 5, 50, 20));
            item.Add(new Item("박카스", Item.Type.음료수, "심장이 도킹도킹!!", 2500, 5, 10, 70, 25));
            item.Add(new Item("얼박사", Item.Type.음료수, "맛있는데 힘까지 넘쳐", 4000, 10, 20, 100, 35));
        }
        public void ItemShop(ref Player player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("           소주병으로 머리 때려드릴 순 있습니다 ^^");
            Console.WriteLine($"                       <<상 점>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  허벌나게 무섭구먼 소주말고 다른거나 사야게쓰");
            Console.WriteLine("");

            for (int i = 0; i < item.Count(); i++)
            {
                item[i].PrintItemShop(item[i].name, false, i + 1);
            }

            Console.WriteLine("");
            Console.WriteLine($"  1. 알바야 이거 얼마냐  (아이템 구매)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("　>> ");
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 1);

            if (number == -1)
            {
                Console.WriteLine("　안사실거면 함부로 만지지 말아주세요 (っ °Д °;)っ");
                Thread.Sleep(1000);
                ItemShop(ref player);
            }
            else if (number == 0)
            {
                return;
            }
            else if (number == 1)
            {
                Shopping(ref player);
            }


        }

        public void Shopping(ref Player player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("          사는 놈이 알지 파는 놈이 알겠습니까 ^^ ");
            Console.WriteLine($"                     <<아이템 구매>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  아따 여기 사장 김씨 아인교? 나가 사장님이랑 으이?!");
            Console.WriteLine("");

            for (int i = 0; i < item.Count(); i++)
            {
                item[i].PrintItemShop(item[i].name, true, i + 1);
            }

            Console.WriteLine("");
            Console.Write("  센터를 까보니 나온 금액 : ");
            ConsoleUtility.PrintHighlight("", player.gold.ToString(), " G");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  분수에 맞게 골라서 숫자로 말해주세요 と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("　>> ");
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 14);

            if (number == -1)
            {
                Console.WriteLine("　안사실거면 함부로 만지지 말아주세요 (っ °Д °;)っ");
                Thread.Sleep(1000);
                Shopping(ref player);
            }
            else if (number == 0)
            {
                return;
            }
            else
            {
                item[number-1].IsPurchase = true;
                player.inven.Add(item[number-1]);
                Shopping(ref player);
            }
        }
    }   
}
