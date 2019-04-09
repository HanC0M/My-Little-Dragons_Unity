using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Text itemName;
    public Text description;
    public Text itemCount;
    public Text itemPrice;
    int i_itemCount;
    int i_itemPrice;

   
    

    void Update()
    {
        i_itemCount = DataController.GetInstance().GetItemCount(DataController.GetInstance().GetShopCode());
        i_itemPrice= DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode());
        switch (DataController.GetInstance().GetShopCode())
        {
            case 0:

                itemName.text = "짭짤한 맛 구미";
                description.text = "간장 맛이 나는 구미이다.";
                break;

            case 1:

                itemName.text = "고소한 맛 구미";
                description.text = "고소한 감칠 맛이 나는 구미이다.";
                break;

            case 2:

                itemName.text = "매운 맛 구미";
                description.text = "청양고추 맛이 나는 구미이다.";
                break;

            case 3:

                itemName.text = "신 맛 구미";
                description.text = "레몬 맛이 나는 구미이다.";
                break;

            case 4:

                itemName.text = "쓴 맛 구미";
                description.text = "한약 맛이 나는 구미이다.";
                break;
            case 5:

                itemName.text = "단 맛 구미";
                description.text = "딸기 맛이 나는 구미이다.";
                break;
            case 6:
                //gameObject.GetComponent<Image>().sprite = salty[1];
                itemName.text = "테니스공";
                description.text = "던지고 놀기 좋은 테니스공.";
                break;

            case 7:
                // gameObject.GetComponent<Image>().sprite = goso[1];
                itemName.text = "원반";
                description.text = "날리면 돌아오는 재밌는 장난감.";
                break;

            case 8:
                // gameObject.GetComponent<Image>().sprite = spicy[1];
                itemName.text = "새끼용 돌";
                description.text = "새끼용과 똑닮은 인형이다.";
                break;
        }
        itemCount.text = " "+i_itemCount;
        itemPrice.text = " " + i_itemPrice;
    }

    
}
