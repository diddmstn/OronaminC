namespace OronaminPC
{
    internal class Player
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
            attack = 10;   
            defense = 5;
            health = 100;
            gold = 1500;
        }
        public void Status()
        {
            Console.Clear();
            Console.WriteLine($"상태 보기");
            Console.WriteLine($"캐릭터의 정보가 표시됩니다.\n");
            Console.WriteLine($"Lv. {level.ToString("00")}");
            Console.WriteLine($"{name} ({job})");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
            Console.WriteLine($"체  력 : {health}");
            Console.WriteLine($"Gold   : {gold}G\n");
            Console.WriteLine($"0. 나가기");
            Console.Write(">> ");
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
            double errorValue = Math.Ceiling((double)(attack/10)); //공격력 오차값, 오차가 소수점이라면 무조건 올림 처리
            Random random = new Random();

            int Damage = random.Next(attack-(int)errorValue, attack+(int)errorValue);

            return Damage;
        }


    }
}