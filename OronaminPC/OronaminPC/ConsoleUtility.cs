using Newtonsoft.Json.Linq;
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
        Console.WriteLine("  3. 알바야 쇠주는 안파나? (상점)");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("  4. 아따 매버라 라면으로 사람 잡겄소 (던전 입장)");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("  0. 워메 한대 피고와야 쓰겄네  (나가기)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("  무엇을 도와드릴까요 손님? と( ⌒  ∨ ⌒)つ");
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
        Console.ForegroundColor= ConsoleColor.DarkRed;
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.Write("□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("□");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("□");
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("□");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("□");
        Console.Write("□□□□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("□");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□□□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("□□□□□□□□");
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●●●");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("□□");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("□□");
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("□□□□□□");
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("□□□□□□");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("□□□□□");
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("□□□□□□");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("□□□□□□□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("□□□□□□");
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("□□□□□□□");
        Console.Write("□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("●●●●");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        Console.ForegroundColor = ConsoleColor.White;
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

        if (File.Exists("./Save/SaveFile.json"))
        {
            JObject jobject = SaveLoad.Read();//저장한 파일과 이름이 같은지 확인
            if (name == jobject["playerName"].ToString())
            {
                strings[0] = jobject["playerName"].ToString();
                strings[1] = jobject["playerJob"].ToString();
                return strings;
            }
        }
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
            Console.WriteLine("　똑디 말해라 문디 자슥아 (ㅡ∧ㅡ)");
            Thread.Sleep(1000);
            job = this.SelectJob();
        }
        else
        {
            int number = int.Parse(userInput);
            if (number <= 0 || number > 3)
            {
                Console.WriteLine("　똑디 말해라 문디 자슥아 (ㅡ∧ㅡ)");
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

    public void BattleInfo(ref Player player, Monster[] monster, int pHpStart)
    {
        //int pHpStart = _pHpStart;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("▨▨▨▨▨▨▨▨▨▨<<League of Text RPG>>▧▧▧▧▧▧▧▧▧▧");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("                         B A T T L E");
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < monster.Length; i++)
        {
            //Console.WriteLine($"  {i + 1}. Lv.{monster[i].level} {monster[i].name} HP {monster[i].hp}");
            Console.WriteLine($"  {i + 1}. Lv.{monster[i].level} {monster[i].name} {(monster[i].hp <= 0 ? "\u001b[38;5;240mDead" : "\u001b[97mHP " + monster[i].hp)}");
            Console.ResetColor();
        }
        Console.WriteLine();
        Console.WriteLine("  [내 정보]");
        Console.WriteLine($"  Lv.{player.level} {player.name} ({player.job})");
        Console.WriteLine($"  HP {player.health}/{pHpStart}");
        Console.WriteLine();
    }

    public string Action()
    {
        Console.WriteLine("  1. 공격");
        Console.WriteLine("  2. 스킬 사용");
        Console.WriteLine();
        Console.WriteLine("  사람이라면 응당 골라야 할 것을 골라보자!");
        Console.Write("  >> ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    public int SelectMonster(Player player, Monster[] monster)
    {
        Console.WriteLine("  저 중에 누구한테 행패를 부려볼까?");
        Console.Write("  >> ");
        string userInput = Console.ReadLine();
        int number = InputCheck(userInput, monster.Length);
        return number;
    }

	public ConsoleUtility()
	{
		
	}

    public void Victory()
    {
        Console.Clear();
        Console.WriteLine("┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓");
        Console.Write("ㅣ  ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("now playing : 승리자(Feat: 보상)");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("プ(★ ∇★)プ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("ㅣ");
        Console.Write("ㅣ  ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("───────── ○────────────────────");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("　　　　 　　ㅣ");
        Console.Write("ㅣ  ◀◀  ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("▶  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("■  ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("▶▶   1:11 / 3:05 ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("────── ○");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("　 ㅣ");
        Console.WriteLine("┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛");
        Thread.Sleep(3600);
    }
    public void Defeat()
    {
        Console.Clear();
        Console.WriteLine("┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓");
        Console.Write("ㅣ  ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("now playing : 패배자(Feat: 똥손)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("　ど(@ 3@)づ ㅣ");
        Console.Write("ㅣ  ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("──────────────────── ○─────────");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("　　　　 　　ㅣ");
        Console.Write("ㅣ  ◀◀  ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("▶  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("■  ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("▶▶   2:22 / 3:05 ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("────── ○");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("　 ㅣ");
        Console.WriteLine("┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛");
        Thread.Sleep(3600);
    }
    public static int GetPrintableLength(string str)
    {
        int length = 0;
        foreach (char c in str)
        {
            if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
            {
                length += 2;
            }
            else
            {
                length += 1;
            }
        }

        return length;
    }
    public static string PadRightForMixedText(string str, int totalLength)
    {
        int currentLength = GetPrintableLength(str);
        int padding = totalLength - currentLength;
        return str.PadRight(str.Length + padding);
    }
    public static void PrintHighlight(string s1, string s2, string s3 = "")
    {
        Console.Write(s1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(s2);
        Console.ResetColor();
        Console.WriteLine(s3);
    }
    public enum Job
    {
        단골학생,
        게임폐인,
        스트리머
    }
}
