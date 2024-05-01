using Newtonsoft.Json.Linq;

namespace OronaminPC
{
    public class SaveLoad
    {
        static string filePath = "./Save/SaveFile.json";

        //저장해야할 요소, 이름, 직업,레벨 등등, 던전 층, 아이템
        public SaveLoad()
        {
            string folderPath = "./Save"; // ./ 실행한 폴더 경로
            DirectoryInfo SaveFolder = new DirectoryInfo(folderPath);

            if (SaveFolder.Exists == false)//경로에 Save 폴더가 없다면 생성
            {
                SaveFolder.Create();
            }
        }

        static public void Save(Player player)//현재는 플레이어 스텟만 저장
        {
            JObject Save = new JObject(
               new JProperty("playerName", player.name),
               new JProperty("playerJob", player.job),
               new JProperty("playerLevel", player.level),
               new JProperty("playerAttack", player.attack),
               new JProperty("playerDefense", player.defense),
               new JProperty("playerHealth", player.health),
               new JProperty("playerGold", player.gold)
               );

            File.WriteAllText(filePath, Save.ToString());//Save 폴더 안에 json 파일 만들기

        }
        static public JObject Load()
        {
            string readJson = File.ReadAllText(filePath);//json 파일 불러오기
            JObject jobject = JObject.Parse(readJson);

            // Console.WriteLine(jobject["playerName"]);//저장한 값 잘 나옴

            return jobject;


        }

    }
}

