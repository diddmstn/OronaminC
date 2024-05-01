using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace OronaminPC
{

    public class Item
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int health { get; set; }
        public int manaPoint { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public Type type { get; set; }

        public bool IsEquip { get; private set; }
        public bool IsPurchase { get; private set; }

        public enum Type
        {
            마우스,
            키보드,
            헤드셋,
            음료수
        }

        public Item(string _name, Type _type, string _description, int _price, int _attack, int _defense, int _health, int _manaPoint)
        {
            name = _name;
            attack = _attack;
            defense = _defense;
            health = _health;
            manaPoint = _manaPoint;
            price = _price;
            description = _description;
            type = _type;
        }

        public List<Item> Init()
        {
            List<Item> list = new List<Item>();

            Item mouse1 = new Item("볼 마우스", Type.마우스, "샷건치면 볼 사라짐", 700, 7, 0, 0, 0);
            list.Add(mouse1);
            Item mouse2 = new Item("레이저 마우스", Type.마우스, "고양이 소환 가능", 1600, 14, 0, 0, 0);
            list.Add(mouse2);
            Item mouse3 = new Item("게이밍 마우스", Type.마우스, "게임은 역시 장비빨", 4300, 28, 0, 0, 0);
            list.Add(mouse3);
            Item keyboard1 = new Item("다이소 키보드", Type.키보드, "쒸프트 키까 안빠쪄요", 500, 0, 10, 0, 0);
            list.Add(keyboard1);
            Item keyboard2 = new Item("사무용 키보드", Type.키보드, "일하기 싫을 때 흉기로", 1500, 0, 20, 0, 0);
            list.Add(keyboard2);
            Item keyboard3 = new Item("게이밍 키보드", Type.키보드, "역시 돈도 재능이다", 4000, 0, 40, 0, 0);
            list.Add(keyboard3);
            Item headset1 = new Item("고장난 헤드셋", Type.헤드셋, "한 쪽이 안들린다", 1000, 0, 0, 10, 0);
            list.Add(headset1);
            Item headset2 = new Item("저급한 헤드셋", Type.헤드셋, "지지직은 BGM이겠지..", 2500, 0, 0, 20, 5);
            list.Add(headset2);
            Item headset3 = new Item("게이밍 헤드셋", Type.헤드셋, "적의 숨소리가 들린다", 6000, 0, 0, 35, 15);
            list.Add(headset3);
            Item drink1 = new Item("콜  라", Type.음료수, "PC방 콜라 국룰이지", 300, 0, 0, 30, 0);
            list.Add(drink1);
            Item drink2 = new Item("핫식스", Type.음료수, "하루종일 게임 쌉가능", 500, 0, 0, 30, 10);
            list.Add(drink2);
            Item drink3 = new Item("레드불", Type.음료수, "이거슨 합법적 각성제", 1500, 3, 5, 50, 15);
            list.Add(drink3);
            Item drink4 = new Item("박카스", Type.음료수, "심장이 도킹도킹!!", 2500, 5, 10, 70, 20);
            list.Add(drink4);
            Item drink5 = new Item("얼박사", Type.음료수, "맛있는데 힘까지 넘쳐", 4000, 10, 20, 100, 30);
            list.Add(drink5);

            return list;
        }

        internal void PrintItemInventory(bool withNumber = false, int idx = 0)
        {
            Console.Write("  - ");
            if (withNumber)
            {
                Console.Write($"{idx} ");
            }
            if (IsEquip)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("E");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("]");
                Console.ResetColor();
                Console.Write(ConsoleUtility.PadRightForMixedText(name, 12));
            }
            else Console.Write(ConsoleUtility.PadRightForMixedText(name, 15));

            Console.Write(" | ");
            Console.WriteLine(description);
            Console.Write(" | ");

            Console.Write(" | ");
            if (attack != 0)
            {
                Console.Write($"공격력 {(attack >= 0 ? "+" : "")}{attack}");
                Console.Write(" | ");
            }
            if (defense != 0)
            {
                Console.Write($"방어력 {(defense >= 0 ? "+" : "")}{defense}");
                Console.Write(" | ");
            }
            if (health != 0)
            {
                Console.Write($"체  력 {(health >= 0 ? "+" : "")}{health}");
                Console.Write(" | ");
            }
            if (manaPoint != 0)
            {
                Console.Write($"마  력 {(manaPoint >= 0 ? "+" : "")}{manaPoint}");
                Console.Write(" | ");
            }
            Console.WriteLine(" | ");

        }

        internal void ToggleEquipStatus()
        {
            IsEquip = !IsEquip;
        }

        internal void PrintItemShop(bool withNumber = false, int idx = 0)
        {
            Console.Write("  - ");
            if (withNumber)
            {
                Console.Write("{0} ", idx);
            }
            else Console.Write(ConsoleUtility.PadRightForMixedText(name, 12));

            Console.Write(" | ");
            Console.Write(ConsoleUtility.PadRightForMixedText(description, 15));
            Console.Write(" | ");

            if (IsPurchase)
            {
                Console.WriteLine("구매완료");
            }
            else
            {
                ConsoleUtility.PrintHighlight("", price.ToString(), " G");
                Console.WriteLine("");
            }

            Console.Write(" | ");
            if (attack != 0)
            {
                Console.Write($"공격력 {(attack >= 0 ? "+" : "")}{attack}");
                Console.Write(" | ");
            }
            if (defense != 0)
            {
                Console.Write($"방어력 {(defense >= 0 ? "+" : "")}{defense}");
                Console.Write(" | ");
            }
            if (health != 0)
            {
                Console.Write($"체  력 {(health >= 0 ? "+" : "")}{health}");
                Console.Write(" | ");
            }
            if (manaPoint != 0)
            {
                Console.Write($"마  력 {(manaPoint >= 0 ? "+" : "")}{manaPoint}");
                Console.Write(" | ");
            }
            Console.WriteLine(" | ");
        }
        internal void Purchased()
        {
            IsPurchase = true;
        }
    }
}
