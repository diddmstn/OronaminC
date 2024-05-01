using Newtonsoft.Json.Linq;

namespace OronaminPC
{
    public class Player
    {
        public string name { get; set; }
        public string job { get; set; }
        public int level { get; set; }
        public int attack { get; set; }
        public int defense {  get; set; }
        public int health { get; set; }
        public int manaPoint {  get; set; }
        public int gold { get; set; }
     
        // 인벤토리 리스트
        // 레벨업 들어간다면 exp(경험치통) 경험치통이 레벨업에 따라 커지는 함수
        // 5 (count++) if count = 1 -> 5 * 2 예시^^
        
        public Player(string _name, string _job)
        {
            if (File.Exists("./Save/Test.json"))
            {
                JObject jobject = SaveLoad.Load();//저장한 파일과 이름이 같은지 확인
                if (name == jobject["playerName"].ToString())//이름이 같다면 정보 셋팅
                {
                    level = (int)jobject["playerLevel"];
                    attack = (int)jobject["playerAttack"];
                    defense = (int)jobject["playerDefense"];
                    health = (int)jobject["playerHealth"];
                    gold = (int)jobject["playerGold"];

                    return;
                }
            }
            name = _name;
            job = _job;
            level = 1;
            if (_job == "단골학생")
            {
                attack = 10;
                defense = 5;
                health = 100;
                manaPoint = 50;
            }
            if (_job == "게임폐인")
            {
                attack = 15;
                defense = 0;
                health = 70;
                manaPoint = 200;
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
            Console.WriteLine($"                     <<상 태 보 기>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  워메 카페인이 들어가니께 몸 상태가 달라져부러야\n");
            Console.WriteLine($"  Lv. {level.ToString("00")}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"  {name} ({job})");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  공격력 : {attack}");
            Console.WriteLine($"  방어력 : {defense}");
            Console.WriteLine($"  체  력 : {health}");
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

        public int Skill()
        {
            int damage = 0;
            switch (this.job)
            {
                case "단골학생":
                    Console.WriteLine("키보드 샷건");
                    damage = this.attack * 3;
                    return damage;
                case "게임폐인":
                    Console.WriteLine("꾸준함의 미학");
                    damage = this.attack * 3;
                    return damage;
                case "스트리머":
                    Console.WriteLine("후원 리액션");
                    damage = this.attack * 3;
                    return damage;
                default:
                    Console.WriteLine("직업 설정 에러");
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
    }
}