namespace OronaminPC
{
    internal class Dungeon
    {
        int level = 1;
        List<Monster> monster = new List<Monster>();
        
        public Dungeon()
        {
            //몬스터 추가
            //Monster monster= new Monster(1, "미니언", new Random().Next(2, 7), 50);
            //Minion minon = new Minion();
            //int _level, string _name, int _atk, int _hp) : base(1, "미니언", (new Random().Next(2, 7)), 50

           // monster.Add(1, "미니언", new Random().Next(2, 7), 50);

        }
        public void EnterDungeon()
        {
            Console.Clear();
            Console.WriteLine("던전");
            Console.WriteLine("던전으로 들어가 몬스터와 전투를 진행하실 수 있습니다.");
            Console.WriteLine("1. 던전입장");
        }
        public Player[] Battle()
        {
            Random random = new Random();
            int monsterCount = random.Next(1, 4);
            Player[] battleMonster =new Player[monsterCount];

            for(int i = 0; i< monsterCount; i++)
            {
                //battleMonster[] = monster[random.Next()];
            }    
       

            return battleMonster;
        }

    }
}
