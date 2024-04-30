namespace OronaminPC
{
    internal class Dungeon
    {
        int level = 1;
        List<Monster> monster = new List<Monster>();
        
        public Dungeon()
        {
            monster.Add(new Monster(1, "미니언", 5 , 50));
            monster.Add(new Monster(2, "대포미니언",7, 100));
            monster.Add(new Monster(3, "공허충", 9, 150));
            monster.Add(new Monster(4, "블루", 12, 175));
            monster.Add(new Monster(5, "레드", 15, 200));
            monster.Add(new Monster(6, "용", 20, 250));
            monster.Add(new Monster(7, "바론", 25, 300));
           
        }
        public void EnterDungeon()
        {
            //상원님 저도 여기 알아서 꾸며주세요 감사합니다^^7
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                        <<던전>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("던전으로 들어가 몬스터와 전투를 진행하실 수 있습니다.\n");
            Console.WriteLine("");
            Console.WriteLine("1. 던전입장");
            Console.WriteLine("0. 나가기");
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
            else
            {
                Console.WriteLine("　똑디 말해라 문디 자슥아");
                Thread.Sleep(1000);
                this.EnterDungeon();
            }
        }
        public void Battle()//몬스터 생성과 턴 변경
        {
            Random random = new Random();
            int monsterCount = random.Next(1, 4);
            Monster[] battleMonster =new Monster[monsterCount];

            for(int i = 0; i< monsterCount; i++)//배열에 몬스터 추가
            {
                battleMonster[i] = monster[random.Next(1,monster.Count())];
                Console.WriteLine(battleMonster[i].name);
            }
          
            //ConsoleUtility.BattleInfo(battleMonster);

            /*
             * BattleInfo에 매개변수로 몬스터와 플레이어를 받아야함
             * BattleInfo(플레이어정보, 생성된 몬스터)
             * {
             *      int 턴
             *     
             *      while(몬스터가 다 죽든, 플레이어가 다 죽을때까지)
             *      {
             *          ~배틀 화면 출력~
             *          
             *          턴이 플레이어일 때
             *          {
             *             공격할 몬스터 선택 입력받기
             *             해당 몬스터 피통 -player.Attack()
             *          }
             *          턴이 몬스터일 때
             *          {
             *              어쩌구저쩌구
             *          }
             *          
             *          ~턴 바꾸기~
             *      }
             * 
             * }
             */

        }

    }
}
