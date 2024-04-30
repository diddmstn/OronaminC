﻿namespace OronaminPC
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
        public void EnterDungeon(Player player)
        {
            //상원님 저도 여기 알아서 꾸며주세요 감사합니다^^7
            Console.Clear();
            Console.WriteLine("던전");
            Console.WriteLine("던전으로 들어가 몬스터와 전투를 진행하실 수 있습니다.\n");
            Console.WriteLine("1. 던전입장");
            Console.WriteLine("0. 나가기");

            string userInput = Console.ReadLine();
            int number = ConsoleUtility.InputCheck(userInput, 1);

            switch(number)
            {
                case 0:
                    return;
                case 1:
                    ConsoleUtility.BattleInfo(player,Battle());
                    break;
                default:
                    Console.WriteLine("　똑디 말해라 문디 자슥아");
                    Thread.Sleep(1000);
                    this.EnterDungeon(player);
                    break;
            }
        }
        public Monster[] Battle()//몬스터 생성
        {
            Random random = new Random();
            int monsterCount = random.Next(1, 4);
            Monster[] battleMonster =new Monster[monsterCount];

            for(int i = 0; i< monsterCount; i++)//배열에 몬스터 추가
            {
                battleMonster[i] = monster[random.Next(1,monster.Count())];
                Console.WriteLine(battleMonster[i].name);
            }

            return battleMonster;
           
        }

    }
}
