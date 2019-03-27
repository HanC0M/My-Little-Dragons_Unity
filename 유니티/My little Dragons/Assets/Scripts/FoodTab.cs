using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTab : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetTabCheckFood();
    }
}
