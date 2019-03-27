using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodUseButton : MonoBehaviour
{
    
    public void OnClick()
    {
        switch (DataController.GetInstance().GetItemCode())
        {
            case 0:
                DataController.GetInstance().AddFood(10f);
                if (DataController.GetInstance().GetFood() >= 100)
                {
                    DataController.GetInstance().SetFood(100);
                }
                DataController.GetInstance().AddFavor(10f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                DataController.GetInstance().AddExp(5f);
                break;

            case 1:
                DataController.GetInstance().AddFood(10f);
                if (DataController.GetInstance().GetFood() >= 100)
                {
                    DataController.GetInstance().SetFood(100);
                }
                DataController.GetInstance().AddFavor(10f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                DataController.GetInstance().AddExp(5f);
                break;

            case 2:
                DataController.GetInstance().AddFood(10f);
                if (DataController.GetInstance().GetFood() >= 100)
                {
                    DataController.GetInstance().SetFood(100);
                }
                DataController.GetInstance().AddFavor(10f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                DataController.GetInstance().AddExp(5f);
                break;

            case 3:
                DataController.GetInstance().AddFood(10f);
                if (DataController.GetInstance().GetFood() >= 100)
                {
                    DataController.GetInstance().SetFood(100);
                }
                DataController.GetInstance().AddFavor(10f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                DataController.GetInstance().AddExp(5f);
                break;

            case 4:
                DataController.GetInstance().AddFood(10f);
                if (DataController.GetInstance().GetFood() >= 100)
                {
                    DataController.GetInstance().SetFood(100);
                }
                DataController.GetInstance().AddFavor(10f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                DataController.GetInstance().AddExp(5f);
                break;
            case 5:
                DataController.GetInstance().AddFood(10f);
                if (DataController.GetInstance().GetFood() >= 100)
                {
                    DataController.GetInstance().SetFood(100);
                }
                DataController.GetInstance().AddFavor(10f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                DataController.GetInstance().AddExp(5f);
                break;
        }
        
    }
}
