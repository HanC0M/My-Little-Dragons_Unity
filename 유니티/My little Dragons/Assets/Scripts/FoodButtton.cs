using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodButtton : MonoBehaviour
{
    public DataController dataController;
    public void OnClick()
    {
        DataController.GetInstance().AddFood(10);
        if (DataController.GetInstance().GetFood() >= 100)
        {
            DataController.GetInstance().SetFood(100);
        }
        if (DataController.GetInstance().GetLevel() < 10)
        {
            DataController.GetInstance().AddExp(30);
        }
        DataController.GetInstance().AddFavor(0.5f);
        if (DataController.GetInstance().GetFavor() >= 100)
        {
            DataController.GetInstance().SetFavor(100);
        }
    }
}
