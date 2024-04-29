namespace OronaminPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtility cu = new ConsoleUtility();
            string[] str = cu.Title();
            Player player = new Player(str[0], str[1]);
            while(true)
            {
                int menu = cu.Menu();
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("안녕히가세요~");
                        Thread.Sleep(1000);
                        return;
                    case 1:
                        player.Status();
                        break;
                    case 2:
                        Console.WriteLine("아이스커피 나왔습니다~");
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        Console.WriteLine("에어컨 틀어드렸습니다~");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("손님~ 주문은 똑바로 하셔야죠~");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}





