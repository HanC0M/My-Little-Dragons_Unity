﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetShopCheckTRUE();
    }
}
