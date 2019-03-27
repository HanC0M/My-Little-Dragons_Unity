using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCancelButton : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetInventoryCheckFALSE();
    }
}
