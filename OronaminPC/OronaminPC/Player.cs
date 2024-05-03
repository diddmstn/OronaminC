using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace OronaminPC
{
    public class Player
    {
        public string name { get; set; }
        public string job { get; set; }
        public int level { get; set; }
        private static int[] EXP = { 10, 35, 65, 100 };
        public int exp {  get; set; }
        public int attack { get; set; }
        public int attackBonus { get; set; }
        public int defense { get; set; }
        public int defenseBonus { get; set; }
        public int health { get; set; }
        public int healthBonus { get; set; }
        public int manaPoint { get; set; }
        public int manaPointBonus { get; set; }
        public int gold { get; set; }

        public List<Item> inven = new List<Item>();
        // 레벨업 들어간다면 exp(경험치통) 경험치통이 레벨업에 따라 커지는 함수
        // 5 (count++) if count = 1 -> 5 * 2 예시^^

        public Player(string _name, string _job)
        {
            name = _name;
            job = _job;
            level = 1;
            manaPoint = 50;

            if (_job == "단골학생")
            {
                attack = 10;
                defense = 5;
                health = 100;
            }
            if (_job == "게임폐인")
            {
                attack = 15;
                defense = 0;
                health = 70;
            }
            if (_job == "스트리머")
            {
                attack = 5;
                defense = 10;
                health = 120;
                manaPoint = 100;
            }
            gold = 1500;
        }
        public void Status()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("            주문하신 아이스 커피 나왔습니다~!");
            Console.WriteLine("                     <<상 태 보 기>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  {name} : 워메 카페인이 들어가니께 몸 상태가 달라져부러야");
            Console.WriteLine($"  Lv. {level.ToString("00")}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"  {name} ({job})");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  공격력 : {attack} {(attackBonus > 0 ? $"(+ {attackBonus})":"")}");
            Console.WriteLine($"  방어력 : {defense} {(defenseBonus > 0 ? $"(+ {defenseBonus})":"")}");
            Console.WriteLine($"  체  력 : {health} {(healthBonus > 0 ? $"(+ {healthBonus})" : "")}");
            Console.WriteLine($"  마  력 : {manaPoint} {(manaPointBonus > 0 ? $"(+ {manaPointBonus})" : "")}");
            Console.WriteLine($"  Gold   : {gold}G\n");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("　>>");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 0);
            if (number == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("　똑디 말해라 문디 자슥아 (ㅡ∧ㅡ)");
                Thread.Sleep(1000);
                this.Status();
            }

        }

        public void Inventory()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("            네 에어컨 18도로 맞춰드렸습니다~!");
            Console.WriteLine("                     <<인 벤 토 리>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  {name} : 아따 찹다찹다 한국이 아니고 러시아가 되부러쓰");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  <장비아이템>");
            Console.ResetColor();
            Console.WriteLine("");

            for (int i = 0; i < inven.Count(); i++)
            {
                if (inven[i].type != Item.Type.음료수)
                    inven[i].PrintItemInventory(inven[i].name, false, i + 1);
            }

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  <소비아이템>");
            Console.ResetColor();
            Console.WriteLine("");

            for (int i = 0; i < inven.Count(); i++)
            {
                if (inven[i].type == Item.Type.음료수)
                inven[i].PrintItemInventory(inven[i].name, false, i + 1);
            }

            Console.WriteLine("");
            Console.WriteLine("  1. 알바가 갖다준 물건을 쪼매 써볼까잉");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
            Console.WriteLine("　>>");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 1);
            if (number == 0)
            {
                return;
            }
            else if (number == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                   <<아 이 템 장 착>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"  {name} : 이야~ 방금 받은 물건들이 따끈따끈하구마잉");
                Console.WriteLine("");

                int equipItemCount = 0;
                Item[] equipInven = new Item[inven.Count()];
                for (int i = 0; i < inven.Count(); i++)
                {
                    if (inven[i].type != Item.Type.음료수)
                    {
                        inven[i].PrintItemInventory(inven[i].name, true, equipItemCount + 1);
                        equipInven[equipItemCount] = inven[i];
                        equipItemCount++;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("  허메 뭘 써야 좋은 걸 썼다고 소문이 날랑가... 번호로 눌러보자");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
                Console.WriteLine("　>>");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
                Console.ForegroundColor = ConsoleColor.White;
                string userInput2 = Console.ReadLine();
                int number2 = ConsoleUtility.InputCheck(userInput2, equipItemCount);
                if (number2 == -1)
                {
                    Console.WriteLine("　똑디 말해라 문디 자슥아 (ㅡ∧ㅡ)");
                    Thread.Sleep(1000);
                }
                else if (number2 == 0)
                {
                
                }
                else
                {
                    ItemEquip(equipInven[number2 - 1]);
                }
                Inventory();
            }
            else
            {
                Console.WriteLine("　똑디 말해라 문디 자슥아 (ㅡ∧ㅡ)");
                Thread.Sleep(1000);
            }

        }

        public void ItemEquip(Item item)
        {
            item.ToggleEquipStatus();
            StatusUpdate(item);
        }

        public void StatusUpdate(Item item)
        {
            // 아이템 변수 (매개변수 : 아이템)
            if (item.isEquip == true)
            {
                if (item.attack != 0)
                {
                    this.attack += item.attack;
                    this.attackBonus += item.attack;
                }
                if (item.defense != 0)
                {
                    this.defense += item.defense;
                    this.defenseBonus += item.defense;
                }
                if (item.health != 0)
                {
                    this.health += item.health;
                    this.healthBonus += item.health;
                }
                if (item.manaPoint != 0)
                {
                    this.manaPoint += item.manaPoint;
                    this.manaPointBonus += item.manaPoint;
                }
            }
            else
            {
                if (item.attack != 0)
                {
                    this.attack -= item.attack;
                    this.attackBonus -= item.attack;
                }
                if (item.defense != 0)
                {
                    this.defense -= item.defense;
                    this.defenseBonus -= item.defense;
                }
                if (item.health != 0)
                {
                    this.health -= item.health;
                    this.healthBonus -= item.health;
                }
                if (item.manaPoint != 0)
                {
                    this.manaPoint -= item.manaPoint;
                    this.manaPointBonus -= item.manaPoint;
                }
            }
        }

        public void LevelUpCheck(int getExp)
        {
            exp += getExp;
            if (EXP[level - 1] <= exp)
            {
                exp -= EXP[level - 1];
                level++;
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Console.WriteLine($"  레벨이 {level}로 올랐습니다!");
            this.attack += 3;
            Console.WriteLine($"  공격력이 3이 올랐습니다.");
            this.defense += 3;
            Console.WriteLine($"  방어력이 3이 올랐습니다.");
        }

        public int Skill()
        {
            int damage = 0;
            switch (this.job)
            {
                case "단골학생":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"  {this.name}의 키보드 샷건!!");
                    Console.ResetColor();
                    damage = this.attack * 3;
                    return damage;
                case "게임폐인":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"  {this.name}의 채팅 러시!!");
                    Console.ResetColor();
                    int script = new Random().Next(1, 4);
                    if(script == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"  {name} : 게임 더럽게 못하네!!");
                        Console.ResetColor();
                    }
                    if (script == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"  {name} : 손가락이 세 개 뿐이야??");
                        Console.ResetColor();
                    }
                    if (script == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"  {name} : 진짜 못한다 ㅋㅋㅋㅋ");
                        Console.ResetColor();
                    }
                    damage = (int)Math.Ceiling(this.attack * 1.5);
                    return damage;
                case "스트리머":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"  {this.name}의 후원 리액션!!");
                    Console.ResetColor();
                    damage = this.attack * 3;
                    return damage;
                default:
                    Console.WriteLine("  직업 설정 에러");
                    return damage;
            }
        }

        public bool IsCritical()
        {
            int criRate = level * 5;
            Random random = new Random();
            int critical = random.Next(0, 101);
            if (critical >= 0 && critical <= criRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDodge()
        {
            int dodgeRate = defense * 2;
            Random random = new Random();
            int dodge = random.Next(0, 101);
            if( dodgeRate >= 0 && dodge <= dodgeRate )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int MonsterAttack()
        {
            double errorValue = Math.Ceiling((double)attack/10); //공격력 오차값, 오차가 소수점이라면 무조건 올림 처리
            Random random = new Random();

            int Damage = random.Next(attack-(int)errorValue, attack+(int)errorValue);

            return Damage;
        }

        public void Rest()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("            나가시는 문은 오른편에 있습니다 ^^");
            Console.WriteLine("                     <<휴식 하기>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine($"  {name} : 놀랍게도 눈알이 달려가 나도 보인당께");
            Console.WriteLine("");
            Console.WriteLine("  (500G 를 사용하여 체력과 마력을 회복할 수 있습니다)\n");
            Console.WriteLine($"  (보유 골드 : {gold} G)\n");
            Console.WriteLine("  1. 시원하게 바람 한 번 쐬고 와야겠구만");
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
            int number= ConsoleUtility.InputCheck(userInput, 1);

            if(number==1)
            {
                if(gold<500)
                {
                    Console.WriteLine("  금액이 모자릅니다.");
                    Thread.Sleep(1000);
                    Rest();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("　　　　　　　♥♥♥♥　　　　　　♥♥♥♥");
                    Console.WriteLine("　　　　　♥♥♥♥♥♥♥　　　　♥♥♥♥♥♥♥");
                    Console.WriteLine("　　　　♥♥♥♥♥♥♥♥♥　 ♥♥♥♥♥♥♥♥♥♥");
                    Console.WriteLine("　　　♥♥♥♥　　　　　　♥♥　　　　　　♥♥♥♥");
                    Console.WriteLine("　　 ♥♥♥♥　　　　　　　♥　　　　　　　　♥♥♥");
                    Console.Write("　　♥♥♥　　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■　　　　　　　　　■　■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.Write("　 ♥♥♥　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■■■■　　　　　　■　■　■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.Write(" 　♥♥♥　　　　　　　　　　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■　　■　■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.Write("　 ♥♥♥　　　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("●　　　　　　　　　　　■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.WriteLine("　　♥♥♥　　　　　　　　　　　　　　　　　　♥♥♥");
                    Console.Write("　　 ♥♥♥♥　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■■■■■　　■■■■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥♥");
                    Console.Write("　　　 ♥♥♥　　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■　■　　　　　　■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.Write("　　　　 ♥♥♥　　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■　■　　　　■　　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.Write("　　　　　　♥♥♥　　");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■　■　　　■　");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("♥♥♥");
                    Console.WriteLine("　　　　　　　 ♥♥　　　　　　　　　♥♥");
                    Console.WriteLine("　　　　　　　　 ♥♥　　　　　　　♥♥");
                    Console.WriteLine("　　　　　　　　　 ♥♥　　　　　♥♥");
                    Console.WriteLine("　　　　　　　　　　　♥♥　　♥♥");
                    Console.WriteLine("　　　　　　　　　　　　♥　　♥");
                    Console.WriteLine("　　　　　　　　　　　　　♥♥");
                    Console.WriteLine("　　　　　　　　　　　　　 ♥");
                    Console.ResetColor();
                    Console.WriteLine("");

                    Console.WriteLine($"　　　　　　　　　　　체력: {health} -> {health + 20}"); //회복량 임의로 설정 
                    Console.WriteLine($"　　　　　　　　　　　마력: {manaPoint} -> {manaPoint + 20}"); //회복량 임의로 설정 
                    Console.WriteLine($"　　　　　　　　 남은 골드: {gold} -> {gold - 500}"); //회복량 임의로 설정 
                    health += 20;
                    manaPoint += 20;
                    gold -= 500;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
                    Thread.Sleep(3600);
                }
            }
            else if(number==0)
            {

            }
            else
            {
                Console.WriteLine("올바른 입력이 아닙니다.");
                Thread.Sleep(1000);
                Rest();
            }

        }
    }
}