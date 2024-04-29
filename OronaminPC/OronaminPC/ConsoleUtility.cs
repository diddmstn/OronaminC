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
        // 메인 메뉴
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("　　　　　　　　　　<<5로나민 PC방>>　　　　　　　　　　");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("　　　　　　　　　　　[ 메  뉴 ]　　　　　　　　　　　　");
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
        string userInput = Console.ReadLine();
		int number = InputCheck(userInput, 3);
		return number;
    }

	public string[] Title()
	{
		// 타이틀
		string[] strings = new string[2];
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        Console.WriteLine("　　　ⓞⓞⓞⓞ　　　　ⓞⓞⓞⓞⓞⓞ　　ⓞⓞ　　　　ⓞⓞ　　ⓞⓞⓞⓞⓞⓞ　ⓞⓞ　");
        Console.WriteLine("　　ⓞⓞ　　ⓞⓞ　　　　　　　　ⓞ　　ⓞⓞ　　　　ⓞⓞ　　ⓞⓞ　　ⓞⓞ　ⓞⓞ　");
        Console.WriteLine("　　ⓞⓞ　　ⓞⓞ　　　ⓞⓞⓞⓞⓞⓞ　　ⓞⓞ　　　　ⓞⓞ　　ⓞⓞ　　ⓞⓞ　ⓞⓞ　");
        Console.WriteLine("　　　ⓞⓞⓞⓞ　　　　ⓞ　　　　　　　ⓞⓞⓞⓞⓞ　ⓞⓞⓞ　ⓞⓞⓞⓞⓞⓞ　ⓞⓞ　");
        Console.WriteLine("　　　　　　　　　　　ⓞⓞⓞⓞⓞⓞ　　ⓞⓞⓞⓞⓞ　ⓞⓞⓞ　　　　　　　　ⓞⓞ　");
        Console.WriteLine("　　　　ⓞⓞ　　　　　　　ⓞⓞ　　　　　　　　　　ⓞⓞ　　ⓞⓞ　　　　　　　　");
        Console.WriteLine("　ⓞⓞⓞⓞⓞⓞⓞⓞ　ⓞⓞⓞⓞⓞⓞⓞⓞ　　　　　　　ⓞⓞ　　ⓞⓞⓞⓞⓞⓞⓞⓞ　　");
        Console.WriteLine("　ⓞⓞⓞⓞⓞⓞⓞⓞ　ⓞⓞⓞⓞⓞⓞⓞⓞ　　　　　　　ⓞⓞ　　ⓞⓞⓞⓞⓞⓞⓞⓞ　　");
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞⓞⓞⓞ　　　　　ⓞⓞⓞⓞ　　　　ⓞⓞ　ⓞⓞ　ⓞⓞ　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞ　　ⓞⓞ　　　ⓞⓞⓞⓞⓞⓞ　　　ⓞⓞⓞⓞⓞ　ⓞⓞ　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞ　　ⓞⓞ　　ⓞⓞ　　　　ⓞⓞ　　ⓞⓞ　ⓞⓞ　ⓞⓞⓞ　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞ　　ⓞⓞ　　ⓞⓞ　　　　　　　　ⓞⓞⓞⓞⓞ　ⓞⓞ　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞⓞⓞⓞⓞ　　ⓞⓞ　　　　　　　　　　　　　　ⓞⓞ　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞ　　　　　　ⓞⓞ　　　　ⓞⓞ　　　　ⓞⓞⓞⓞ　　　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞ　　　　　　　ⓞⓞⓞⓞⓞⓞ　　　　ⓞⓞ　　ⓞⓞ　　　　　　　");
        Console.WriteLine("　　　　　　　ⓞⓞ　　　　　　　　ⓞⓞⓞⓞ　　　　　　ⓞⓞⓞⓞ　　　　　　　　");
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        Console.Write("　　　　　　　　　　　");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("오로나민 PC방");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("은 회원제로 운영됩니다.　　　　　　　　　　");
        Console.Write("　　　　　　　　　　　　　회원님의 ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("성함");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("을 입력해주세요　　　　　　　　　　　　");
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        string name = Console.ReadLine();
		strings[0] = name;
		strings[1] = "전사"; // 직업 선택하기
		return strings;

	}
	public ConsoleUtility()
	{
		
	}
}
