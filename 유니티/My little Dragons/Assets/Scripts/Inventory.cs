using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private InventorySlot[] slots; // 인벤토리 슬롯

    private List<Item> inventoryItemList; // 플레이어가 소지한 아이템 리스트
    private List<Item> inventoryTabList; // 선택한 탭에 따라 다르게 보여질 아이템 리스트

    public Text description_Text; // 부연 설명

    public Transform tf; // 슬롯의 부모 객체

    public GameObject go; // 인벤토리 활성화 비활성화
    public GameObject[] selectedTabImages;

    private int selectedItem; // 선택된 아이템
    private int selectedTab;    // 선택된 탭

    private bool activated; // 인벤토리 활성화시 true
    private bool tabActivated; // 탭 활성화시 true
    private bool itemActivated; // 아이템 활성화시 true

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);

 
    void Start()
    {
        inventoryItemList = new List<Item>(); 
        inventoryTabList = new List<Item>();
        slots = tf.GetComponentsInChildren<InventorySlot>();

        // 먹이(Food)
        inventoryItemList.Add(new Item(1001, "짭짤한 맛 구미", "간장 맛이 나는 구미이다.", Item.ItemType.Food));
        inventoryItemList.Add(new Item(1002, "고소한 맛 구미", "고소한 감칠 맛이 나는 구미이다.", Item.ItemType.Food));
        inventoryItemList.Add(new Item(1003, "달콤한 맛 구미", "딸기 맛이 나는 구미이다.", Item.ItemType.Food));
        inventoryItemList.Add(new Item(1004, "매운 맛 구미", "화끈한 맛이 나는 구미이다. 인간은 먹을 수 없다고 써져 있다.", Item.ItemType.Food));
        inventoryItemList.Add(new Item(1005, "신 맛 구미", "레몬 향이 강한 구미이다.", Item.ItemType.Food));
        inventoryItemList.Add(new Item(1006, "쓴 맛 구미", "엄청 쓴 맛이 나는 구미이다.", Item.ItemType.Food));

        // 장난감(Toy)
        inventoryItemList.Add(new Item(1007, "테니스공", "굴리면서 놀기 좋은 공이다.", Item.ItemType.Toy));
        inventoryItemList.Add(new Item(1008, "원반", "던지면 돌아올 것 같은 원반이다.", Item.ItemType.Toy));
        inventoryItemList.Add(new Item(1009, "용 인형", "새끼용 형태의 귀여운 인형이다.", Item.ItemType.Toy));
    }

    public void ShowTab()
    {
        RemoveSlots();
        SelectedTab();
    }   // 탭 활성화
    public void RemoveSlots()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            slots[i].RemoveItem();
            slots[i].gameObject.SetActive(false);
        }
    }   // 인벤토리 슬롯 초기화
    public void SelectedTab()
    {
        StopAllCoroutines();
        
        Color color = selectedTabImages[selectedTab].GetComponent<Image>().color;
        color.a = 0f;
        for(int i = 0; i < selectedTabImages.Length; i++)
        {
            selectedTabImages[i].GetComponent<Image>().color = color;
        }
        StartCoroutine(SelectedTabEffectCoroutine());
    }   // 선택된 탭을 제외하고 다른 모든 탭의 컬러 알파값 0으로

    IEnumerator SelectedTabEffectCoroutine()
    {
        while (tabActivated)
        {
            Color color = selectedTabImages[selectedTab].GetComponent<Image>().color;
            while (color.a < 0.5f)
            {
                color.a += 0.03f;
                selectedTabImages[0].GetComponent<Image>().color = color;
                yield return waitTime;
            }
            while (color.a > 0.5f)
            {
                color.a -= 0.03f;
                selectedTabImages[0].GetComponent<Image>().color = color;
                yield return waitTime;
            }
            yield return new WaitForSeconds(0.3f);
        }
    }   //선택된 탭 반짝임 효과
    public void ShowItem()
    {
        inventoryTabList.Clear();
        RemoveSlots();
        selectedItem = 0;

        switch (selectedTab)
        {
            case 0:
                for(int i = 0; i < inventoryItemList.Count; i++)
                {
                    if (Item.ItemType.Food == inventoryItemList[i].itemType)
                    {
                        inventoryTabList.Add(inventoryItemList[i]);
                    }
                }
                break;
            case 1:
                for (int i = 0; i < inventoryItemList.Count; i++)
                {
                    if (Item.ItemType.Toy == inventoryItemList[i].itemType)
                    {
                        inventoryTabList.Add(inventoryItemList[i]);
                    }
                }
                break;
        } // 탭에 따른 아이템 분류를 인벤토리 탭 리스트에 추가

        for(int i = 0; i < inventoryItemList.Count; i++)
        {
            slots[i].gameObject.SetActive(true);
            slots[i].AddItem(inventoryItemList[i]);
        }

        SelectedItem();
    }       // 아이템 활성화

    public void SelectedItem()
    {
        StopAllCoroutines();
        if (inventoryTabList.Count > 0)
        {
            StopAllCoroutines();

            Color color = slots[0].selected_Item.GetComponent<Image>().color;
            color.a = 0f;
            for(int i = 0; i < inventoryTabList.Count; i++)
            {
                slots[i].selected_Item.GetComponent<Image>().color = color;
            }
            description_Text.text = inventoryTabList[selectedItem].itemDescription;
            StartCoroutine(SelectedItemEffectCoroutine());
        }
    }   // 선택된 아이템을 제외하고, 다른 모든 탭의 컬러 알파값을 0으로 조정

    IEnumerator SelectedItemEffectCoroutine()
    {
        while (itemActivated)
        {
            Color color = slots[selectedItem].GetComponent<Image>().color;
            while (color.a < 0.5f)
            {
                color.a += 0.03f;
                slots[selectedItem].selected_Item.GetComponent<Image>().color = color;
                yield return waitTime;
            }
            while (color.a > 0.5f)
            {
                color.a -= 0.03f;
                slots[selectedItem].selected_Item.GetComponent<Image>().color = color;
                yield return waitTime;
            }
            yield return new WaitForSeconds(0.3f);
        }
    }   // 선택된 아이템 반짝임 효과

    void Update()
    {
        selectedTab = DataController.GetInstance().GetTabCheck();

        if (DataController.GetInstance().GetInventoryCheck() == true)
        {
                go.SetActive(true);
                tabActivated = true;
                itemActivated = false;
                ShowTab();
            if (DataController.GetInstance().GetTabCheck() == 0)
            {
                Color color = selectedTabImages[selectedTab].GetComponent<Image>().color;
                color.a = 0.25f;
                selectedTabImages[selectedTab].GetComponent<Image>().color = color;
                itemActivated = true;
                tabActivated = false;

                ShowItem();
            }
            if (DataController.GetInstance().GetTabCheck() == 1)
            {
                Color color = selectedTabImages[selectedTab].GetComponent<Image>().color;
                color.a = 0.25f;
                selectedTabImages[selectedTab].GetComponent<Image>().color = color;
                itemActivated = true;
                tabActivated = false;

                ShowItem();
            }
        }
        else if (DataController.GetInstance().GetInventoryCheck() == false)
        {
            StopAllCoroutines();
            go.SetActive(false);
            tabActivated = false;
            itemActivated = false;
        }

        
        
    }
}
