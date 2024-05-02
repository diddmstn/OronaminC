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
        public List<Item> equipment = new List<Item>();
        public List<Item> potion = new List<Item>();
        public Shop()
        {
            equipment.Add(new Item("부서진 마우스", Item.Type.마우스, "샷건치면 볼 사라짐", 700, 7, 0, 0, 0));
            equipment.Add(new Item("레이저 마우스", Item.Type.마우스, "고양이 소환 가능", 1600, 14, 0, 0, 0));
            equipment.Add(new Item("게이밍 마우스", Item.Type.마우스, "게임은 역시 장비빨", 4300, 28, 0, 0, 0));
            equipment.Add(new Item("다이소 키보드", Item.Type.키보드, "쒸프트 키까 안빠쪄요", 500, 0, 10, 0, 0));
            equipment.Add(new Item("사무용 키보드", Item.Type.키보드, "일하기 싫을 때 흉기로", 1500, 0, 20, 0, 0));
            equipment.Add(new Item("게이밍 키보드", Item.Type.키보드, "역시 돈도 재능이다", 4000, 0, 40, 0, 0));
            equipment.Add(new Item("고장난 헤드셋", Item.Type.헤드셋, "한 쪽이 안들린다", 1000, 0, 0, 10, 0));
            equipment.Add(new Item("저급한 헤드셋", Item.Type.헤드셋, "지지직은 BGM이겠지..", 2500, 0, 0, 20, 10));
            equipment.Add(new Item("게이밍 헤드셋", Item.Type.헤드셋, "적의 숨소리가 들린다", 6000, 0, 0, 35, 25));

            potion.Add(new Item("콜  라", Item.Type.음료수, "PC방 콜라 국룰이지", 300, 0, 0, 30, 0));
            potion.Add(new Item("핫식스", Item.Type.음료수, "하루종일 게임 쌉가능", 500, 0, 0, 30, 10));
            potion.Add(new Item("레드불", Item.Type.음료수, "이거슨 합법적 각성제", 1500, 3, 5, 50, 20));
            potion.Add(new Item("박카스", Item.Type.음료수, "심장이 도킹도킹!!", 2500, 5, 10, 70, 25));
            potion.Add(new Item("얼박사", Item.Type.음료수, "맛있는데 힘까지 넘쳐", 4000, 10, 20, 100, 35));
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
            Console.WriteLine("                       <<상 점>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine($"  {player.name} : 허벌나게 무섭구먼 소주말고 다른거나 사야게쓰");
            Console.WriteLine("");

            //for (int i = 0; i < equipment.Count(); i++)
            //{
            //    equipment[i].PrintItemShop(equipment[i].name, true, i + 1);
            //}
            //for (int i = 0; i < potion.Count(); i++)
            //{
            //    potion[i].PrintItemShop(potion[i].name, true, i + 1);
            //}

            Console.WriteLine("");
            Console.WriteLine("  1. 알바야 여기 장비도 파냐 (장비아이템 구매)");
            Console.WriteLine("");
            Console.WriteLine("  2. 알바야 음료수 좀 갖고와봐라 (소비아이템 구매)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("　>> ");
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 2);

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
                Shopequip(ref player);
            }
            else if (number == 2)
            {
                Shoppotion(ref player);
            }
        }

        public void Shopequip(ref Player player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("          사는 놈이 알지 파는 놈이 알겠습니까 ^^ ");
            Console.WriteLine("                     <<아이템 구매>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine($"  {player.name} : 아따 여기 사장 김씨 아인교? 나가 사장님이랑 으이?!");
            Console.WriteLine("");

            for (int i = 0; i < equipment.Count(); i++)
            {
                equipment[i].PrintItemShop(equipment[i].name, true, i + 1);
            }

            Console.WriteLine("");
            Console.Write("  센터를 까보니 나온 금액 : ");
            ConsoleUtility.PrintHighlight("", player.gold.ToString(), " G");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  분수에 맞게 골라서 숫자로 말해주세요 と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("　>> ");
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 9);

            if (number == -1)
            {
                Console.WriteLine("　안사실거면 함부로 만지지 말아주세요 (っ °Д °;)っ");
                Thread.Sleep(1000);
                Shopequip(ref player);
            }
            else if (number == 0)
            {
                return;
            }
            else
            {
                if (number >= 1 && number <= 9 && player.gold >= equipment[number - 1].price)
                {
                    if (equipment[number - 1].IsPurchase == true) 
                    {
                        Console.WriteLine("  같은 장비는 재고가 1개씩 밖에 없었어요!"); 
                        Thread.Sleep(1000);
                        Shopequip(ref player);
                    }
                    else
                    {
                        equipment[number - 1].IsPurchase = true;
                        player.inven.Add(equipment[number - 1]);
                        Console.WriteLine("  주문하신 물건은 자리에 가져다 드릴게요");
                        Thread.Sleep(1000);
                        player.gold -= equipment[number - 1].price;
                        Shopequip(ref player);
                    }
                }
                else if (number >= 1 && number <= 9 && player.gold < equipment[number - 1].price)
                {
                    equipment[number - 1].IsPurchase = false;
                    Console.WriteLine("  돈 없으시면 가서 게임이나 하세요 ^^");
                    Thread.Sleep(1000);
                    Shopequip(ref player);
                }
                else
                {
                    return;
                }
                
            }
        }
        public void Shoppotion(ref Player player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("          사는 놈이 알지 파는 놈이 알겠습니까 ^^ ");
            Console.WriteLine("                  <<소비아이템 구매>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine($"  {player.name} : 아따 여기 사장 김씨 아인교? 나가 사장님이랑 으이?!");
            Console.WriteLine("");

            for (int i = 0; i < potion.Count(); i++)
            {
                potion[i].PrintItemShop(potion[i].name, true, i + 1);
            }

            Console.WriteLine("");
            Console.Write("  센터를 까보니 나온 금액 : ");
            ConsoleUtility.PrintHighlight("", player.gold.ToString(), " G");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  분수에 맞게 골라서 숫자로 말해주세요 と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("　>> ");
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 5);

            if (number == -1)
            {
                Console.WriteLine("　안사실거면 함부로 만지지 말아주세요 (っ °Д °;)っ");
                Thread.Sleep(1000);
                Shoppotion(ref player);
            }
            else if (number == 0)
            {
                return;
            }
            else
            {
                if (number >= 1 && number <= 5 && player.gold >= potion[number - 1].price)
                {
                    potion[number - 1].IsPurchase = true;
                    player.inven.Add(potion[number - 1]);
                    Console.WriteLine("  주문하신 물건은 자리에 가져다 드릴게요");
                    Thread.Sleep(1000);
                    player.gold -= potion[number - 1].price;
                    Shoppotion(ref player);
                }
                else if (number >= 1 && number <= 14 && player.gold < potion[number - 1].price)
                {
                    potion[number - 1].IsPurchase = false;
                    Console.WriteLine("  돈 없으시면 가서 게임이나 하세요 ^^");
                    Thread.Sleep(1000);
                    Shoppotion(ref player);
                }
                else
                {
                    return;
                }

            }
        }
    }   
}
