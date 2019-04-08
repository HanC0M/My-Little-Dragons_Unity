using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopExit : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetShopCheckFALSE();
    }
}
