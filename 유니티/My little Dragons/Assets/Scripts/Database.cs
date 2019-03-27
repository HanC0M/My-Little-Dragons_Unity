using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    static public Database instance;

    private void Awake()
    {
        if (instance != null){
            Destroy(this.gameObject);
        }
        else{
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }
    public List<Item> itemList = new List<Item>();


    void Start()
    {
        // 먹이(Food)
        itemList.Add(new Item(1001, "짭짤한 맛 구미", "간장 맛이 나는 구미이다.", Item.ItemType.Food));
        itemList.Add(new Item(1002, "고소한 맛 구미", "고소한 감칠 맛이 나는 구미이다.", Item.ItemType.Food));
        itemList.Add(new Item(1003, "달콤한 맛 구미", "딸기 맛이 나는 구미이다.", Item.ItemType.Food));
        itemList.Add(new Item(1004, "매운 맛 구미", "화끈한 맛이 나는 구미이다. 인간은 먹을 수 없다고 써져 있다.", Item.ItemType.Food));
        itemList.Add(new Item(1005, "신 맛 구미", "레몬 향이 강한 구미이다.", Item.ItemType.Food));
        itemList.Add(new Item(1006, "쓴 맛 구미", "엄청 쓴 맛이 나는 구미이다.", Item.ItemType.Food));

        // 장난감(Toy)
        itemList.Add(new Item(1007, "테니스공", "굴리면서 놀기 좋은 공이다.", Item.ItemType.Toy));
        itemList.Add(new Item(1008, "원반", "던지면 돌아올 것 같은 원반이다.", Item.ItemType.Toy));
        itemList.Add(new Item(1009, "용 인형", "새끼용 형태의 귀여운 인형이다.", Item.ItemType.Toy));
    }
}
