using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodButtton : MonoBehaviour
{
    
    public void OnClick()
    {
        DataController.GetInstance().SetFoodCheckTRUE();
    } 
}
