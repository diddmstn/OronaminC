using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OronaminPC
{
    public class Shop
    {
        List<Item> item = new List<Item>();
        public Shop()
        {
            item.Add(new Item("볼 마우스", Item.Type.마우스, "샷건치면 볼 사라짐", 700, 7, 0, 0, 0));
            item.Add(new Item("레이저 마우스", Item.Type.마우스, "고양이 소환 가능", 1600, 14, 0, 0, 0));
            item.Add(new Item("게이밍 마우스", Item.Type.마우스, "게임은 역시 장비빨", 4300, 28, 0, 0, 0));
            item.Add(new Item("다이소 키보드", Item.Type.키보드, "쒸프트 키까 안빠쪄요", 500, 0, 10, 0, 0));
            item.Add(new Item("사무용 키보드", Item.Type.키보드, "일하기 싫을 때 흉기로", 1500, 0, 20, 0, 0));
            item.Add(new Item("게이밍 키보드", Item.Type.키보드, "역시 돈도 재능이다", 4000, 0, 40, 0, 0));
            item.Add(new Item("고장난 헤드셋", Item.Type.헤드셋, "한 쪽이 안들린다", 1000, 0, 0, 10, 0));
            item.Add(new Item("저급한 헤드셋", Item.Type.헤드셋, "지지직은 BGM이겠지..", 2500, 0, 0, 20, 5));
            item.Add(new Item("게이밍 헤드셋", Item.Type.헤드셋, "적의 숨소리가 들린다", 6000, 0, 0, 35, 15));
            item.Add(new Item("콜  라", Item.Type.음료수, "PC방 콜라 국룰이지", 300, 0, 0, 30, 0));
            item.Add(new Item("핫식스", Item.Type.음료수, "하루종일 게임 쌉가능", 500, 0, 0, 30, 10));
            item.Add(new Item("레드불", Item.Type.음료수, "이거슨 합법적 각성제", 1500, 3, 5, 50, 15));
            item.Add(new Item("박카스", Item.Type.음료수, "심장이 도킹도킹!!", 2500, 5, 10, 70, 20));
            item.Add(new Item("얼박사", Item.Type.음료수, "맛있는데 힘까지 넘쳐", 4000, 10, 20, 100, 30));
        }
    }
       
}
