using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetInventoryCheckTRUE();
    }

}
