using System;
using System.Security.Cryptography.X509Certificates;

public class ConsoleUtility
{
	public int InputCheck(string userInput, int max)
	{
		int number;
		bool isValidInput = int.TryParse(userInput, out number);
		if (!isValidInput)
		{
			Console.WriteLine("잘못된 입력입니다.");
			Thread.Sleep(1000);
			return -1;
		}
		else if (number < 0 || number > max)
		{
            Console.WriteLine("잘못된 입력입니다.");
            Thread.Sleep(1000);
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
		Console.WriteLine("<<5로나민 PC방>>");
		Console.WriteLine("Menu");
		Console.WriteLine();
		Console.WriteLine("1. 보글보글 끓인 국물라면(스테이터스)");
		Console.WriteLine("2. 아이 찹다 아이스커피(던전 입장)");
		Console.WriteLine("3. 더워서 그런데 에어컨 좀...(인벤토리)");
		Console.WriteLine();
		Console.WriteLine("0. 옆에 잼민이 더럽게 시끄럽네(나가기)");
		Console.WriteLine();
		Console.WriteLine("원하시는 메뉴 번호를 알바생에게 말해주세요.");
        Console.Write(">> ");
		string userInput = Console.ReadLine();
		int number = InputCheck(userInput, 3);
		if (number == -1)
		{
			Menu();
		}
		return number;
    }

	public void Title()
	{
		Console.WriteLine("5로나민 PC방에 오신 것을 환영합니다.");
		Console.WriteLine("원하시는 닉네임을 입력해주세요.");
		Console.Write(">> ");
		string name = Console.ReadLine();
		// 플레이어 클래스 생성자 입력

	}
	public ConsoleUtility()
	{
		
	}
}
