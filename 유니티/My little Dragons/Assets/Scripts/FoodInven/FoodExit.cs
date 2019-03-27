using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodExit : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetFoodCheckFALSE();
    }
}
