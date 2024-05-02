﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;

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

        public void Save(Player player, int dungeonLevel, Shop shop)
        {
            string Invenjson = JsonConvert.SerializeObject(player.inven);
            string shopJson = JsonConvert.SerializeObject(shop.item);

            JObject Save = new JObject();
            JArray playerInven = JArray.Parse(Invenjson);
            JArray shopItem = JArray.Parse(shopJson);

            Save.Add("playerName", player.name);
            Save.Add("playerJob", player.job);
            Save.Add("playerLevel", player.level);
            Save.Add("playerAttack", player.attack);
            Save.Add("playerDefense", player.defense);
            Save.Add("playerHealth", player.health);
            Save.Add("playerGold", player.gold);
            Save.Add("dungeonLevel", dungeonLevel);
            Save.Add("playerInven", playerInven);
            Save.Add("shopItem", shopItem);

            File.WriteAllText(filePath, Save.ToString());//Save 폴더 안에 json 파일 만들기


        }
        static public JObject Read()
        {
            string readJson = File.ReadAllText(filePath);//json 파일 불러오기
            JObject jobject = JObject.Parse(readJson);

            return jobject;


        }
        public void Load(Player player, JObject jobject, Dungeon dungeon, Shop shop)
        {
            JToken invenJToken = jobject["playerInven"]; //인벤토리에서
            JToken shopJToken = jobject["shopItem"]; //인벤토리에서
                                                     // JToken jToken = jobject["playerInven"];
            foreach (JToken data in invenJToken)
            {
                Item item = JsonConvert.DeserializeObject<Item>(data.ToString());
                player.inven.Add(item);
                Console.WriteLine(player.inven.Count());
            }

            foreach (JToken data in shopJToken)
            {
                Item item = JsonConvert.DeserializeObject<Item>(data.ToString());
                shop.item.Add(item);
                Console.WriteLine(player.inven.Count());
            }

            player.level = (int)jobject["playerLevel"];
            player.attack = (int)jobject["playerAttack"];
            player.defense = (int)jobject["playerDefense"];
            player.health = (int)jobject["playerHealth"];
            player.gold = (int)jobject["playerGold"];
            dungeon.dungeonLevel = (int)jobject["dungeonLevel"];
        }

    }

}


