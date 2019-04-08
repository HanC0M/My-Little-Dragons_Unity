using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPurchase : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().AddItemCount(DataController.GetInstance().GetShopCode());
    }
}
