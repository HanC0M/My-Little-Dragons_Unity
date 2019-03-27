using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodManager : MonoBehaviour
{
    public Text itemName;
    public Text description;

    void Update()
    {
        
        switch (DataController.GetInstance().GetItemCode())
        {
            case 0:
                //gameObject.GetComponent<Image>().sprite = salty[1];
                itemName.text = "짭짤한 맛 구미";
                description.text = "간장 맛이 나는 구미이다.";
                break;

            case 1:
               // gameObject.GetComponent<Image>().sprite = goso[1];
                itemName.text = "고소한 맛 구미";
                description.text = "고소한 감칠 맛이 나는 구미이다.";
                break;

            case 2:
               // gameObject.GetComponent<Image>().sprite = spicy[1];
                itemName.text = "매운 맛 구미";
                description.text = "청양고추 맛이 나는 구미이다.";
                break;

            case 3:
                //gameObject.GetComponent<Image>().sprite = sinmat[1];
                itemName.text = "신 맛 구미";
                description.text = "레몬 맛이 나는 구미이다.";
                break;

            case 4:
                //gameObject.GetComponent<Image>().sprite = sseunmat[1];
                itemName.text = "쓴 맛 구미";
                description.text = "한약 맛이 나는 구미이다.";
                break;
            case 5:
                //gameObject.GetComponent<Image>().sprite = sweet[1];
                itemName.text = "단 맛 구미";
                description.text = "딸기 맛이 나는 구미이다.";
                break;
        }

    }
}
