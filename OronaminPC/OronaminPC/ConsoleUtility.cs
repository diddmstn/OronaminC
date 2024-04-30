using OronaminPC;
using System;
using System.Security.Cryptography.X509Certificates;

public class ConsoleUtility
{
	public static int InputCheck(string userInput, int max)
	{
		int number;
		bool isValidInput = int.TryParse(userInput, out number);
		if (!isValidInput)
		{
			return -1;
		}
		else if (number < 0 || number > max)
		{
            return -1;
        }
		else
		{
			return number;
		}
	}

	public int Menu()
	{
		Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("　　　　　　　　　  　　[ 메  뉴 ]　　　　　　　　　　　　");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("  1. 아이 찹다 아이스 커피 (상태 보기)");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("  2. 저기요 여 에어컨 좀 틀아주소 (인벤토리)");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  3. 아까시 요 쇠주는 안파나? (상점)");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("  4. 아따 매버라 라면으로 사람 잡겄소 (던전 입장)");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("  무엇을 도와드릴까요 손님? ＼( ⌒  ∨ ⌒)／ 　　　　　　　");
        Console.WriteLine("  >>");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
        Console.ForegroundColor = ConsoleColor.White;
        string userInput = Console.ReadLine();
		int number = InputCheck(userInput, 4);
		return number;
    }

	public string[] Title()
	{
        string[] strings = new string[2];
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.WriteLine("□□□●●●●□□□□●●●●●●□□●●□□□□●●□□●●●●●●□●●□");
        Console.WriteLine("□□●●□□●●□□□□□□□□●□□●●□□□□●●□□●●□□●●□●●□");
        Console.WriteLine("□□●●□□●●□□□●●●●●●□□●●□□□□●●□□●●□□●●□●●□");
        Console.WriteLine("□□□●●●●□□□□●□□□□□□□●●●●●□●●●□●●●●●●□●●□");
        Console.WriteLine("□□□□□□□□□□□●●●●●●□□●●●●●□●●●□□□□□□□□●●□");
        Console.WriteLine("□□□□●●□□□□□□□●●□□□□□□□□□□●●□□●●□□□□□□□□");
        Console.WriteLine("□●●●●●●●●□●●●●●●●●□□□□□□□●●□□●●●●●●●●□□");
        Console.WriteLine("□●●●●●●●●□●●●●●●●●□□□□□□□●●□□●●●●●●●●□□");
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.WriteLine("□□□□□□□●●●●●□□□□□●●●●□□□□●●□●●□●●□□□□□□");
        Console.WriteLine("□□□□□□□●●□□●●□□□●●●●●●□□□●●●●●□●●□□□□□□");
        Console.WriteLine("□□□□□□□●●□□●●□□●●□□□□●●□□●●□●●□●●●□□□□□");
        Console.WriteLine("□□□□□□□●●□□●●□□●●□□□□□□□□●●●●●□●●□□□□□□");
        Console.WriteLine("□□□□□□□●●●●●●□□●●□□□□□□□□□□□□□□●●□□□□□□");
        Console.WriteLine("□□□□□□□●●□□□□□□●●□□□□●●□□□□●●●●□□□□□□□□");
        Console.WriteLine("□□□□□□□●●□□□□□□□●●●●●●□□□□●●□□●●□□□□□□□");
        Console.WriteLine("□□□□□□□●●□□□□□□□□●●●●□□□□□□●●●●□□□□□□□□");
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.WriteLine("□　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　□"); 
        Console.Write("□　　　　　　　　　　");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("오로나민 PC방");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("은 회원제로 운영됩니다.　　　　　　　　　□");
        Console.Write("□　　　　　　　　　　　　회원님의 ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("성함");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("을 입력해주세요　　　　　　　　　　　□");
        Console.WriteLine("□　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　□");
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        Console.Write("  회원명 : ");
        string name = Console.ReadLine();
        strings[0] = name;
		strings[1] = SelectJob();
		return strings;

	}

    public string SelectJob()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<오로나민 PC방>>▧▧▧▧▧▧▧▧▧▧");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine("                      [직업 선택]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        int count = 1;
        foreach (var jobs in Enum.GetValues(typeof(Job)))
        {
            Console.Write($"                     {count++}. ");
            Console.WriteLine($"{jobs}");
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("          양심껏 당신의 현재 직업을 선택해주세요");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.Write("  ▶ ");

        string userInput = Console.ReadLine();
        int check;
        string job = "";

        bool isValidInput = int.TryParse(userInput, out check);
        if (!isValidInput)
        {
            Console.WriteLine("　똑디 말해라 문디 자슥아");
            Thread.Sleep(1000);
            job = this.SelectJob();
        }
        else
        {
            int number = int.Parse(userInput);
            if (number <= 0 || number > 3)
            {
                Console.WriteLine("　똑디 말해라 문디 자슥아");
                Thread.Sleep(1000);
                return this.SelectJob();
            }
            else if (number == 1)
            {
                job = Job.단골학생.ToString();
                return job;
            }
            else if (number == 2)
            {
                job = Job.게임폐인.ToString();
                return job;
            }
            else if (number == 3)
            {
                job = Job.스트리머.ToString();
                return job;
            }
        }
        return job;
    }

    public static void BattleInfo(Player player, Monster[] monster)
    {
        int turn = 0;
        int pHpStart = player.health;
        Console.WriteLine("Battle!!\n");

        for(int i = 0; i < monster.Length; i++)
        {
            Console.WriteLine($"Lv.{monster[i].level} {monster[i].name} HP {monster[i].hp}");
        }
        Console.WriteLine();
        Console.WriteLine("[내 정보]");
        Console.WriteLine($"Lv.{player.level} {player.name} ({player.job})");
        Console.WriteLine($"HP {player.health}/{pHpStart}");
        Console.WriteLine();
        Console.WriteLine("1. 공격");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">> ");
        string userInput = Console.ReadLine();
        switch(userInput)
        {
            case "1":
                // 공격할 몬스터 선택 & 공격할 몬스터 체력 -= attack
                break;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                break;
        }
    }
	public ConsoleUtility()
	{
		
	}

    public enum Job
    {
        단골학생,
        게임폐인,
        스트리머
    }
}
