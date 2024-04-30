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
        public int gold { get; set; }
     
        // 인벤토리 리스트
        // 레벨업 들어간다면 exp(경험치통) 경험치통이 레벨업에 따라 커지는 함수
        // 5 (count++) if count = 1 -> 5 * 2 예시^^
        
        public Player(string _name, string _job)
        {
            name = _name;
            job = _job;
            level = 1;
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
                Console.WriteLine("　똑디 말해라 문디 자슥아");
                Thread.Sleep(1000);
                this.Status();
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