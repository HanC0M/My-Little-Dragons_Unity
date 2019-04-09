using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPurchase : MonoBehaviour
{
    public void OnClick()
    {
        if (Mathf.Round(DataController.GetInstance().GetGold()) >= DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode())) { 
        DataController.GetInstance().AddItemCount(DataController.GetInstance().GetShopCode());
            }
    }
}
