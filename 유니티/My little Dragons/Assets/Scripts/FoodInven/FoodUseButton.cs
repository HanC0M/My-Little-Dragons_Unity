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
                if (DataController.GetInstance().GetItemCount(0) >= 1)
                {
                    DataController.GetInstance().UseFoodItem(0);
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
                }

                break;

            case 1:
                if (DataController.GetInstance().GetItemCount(1) >= 1)
                {
                    DataController.GetInstance().UseFoodItem(1);
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
                }
                break;

            case 2:
                if (DataController.GetInstance().GetItemCount(2) >= 1)
                {
                    DataController.GetInstance().UseFoodItem(2);
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
                }
                break;

            case 3:
                if (DataController.GetInstance().GetItemCount(3) >= 1)
                {
                    DataController.GetInstance().UseFoodItem(3);
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
                }
                break;

            case 4:
                if (DataController.GetInstance().GetItemCount(4) >= 1)
                {
                    DataController.GetInstance().UseFoodItem(4);
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
                }
                break;
            case 5:
                if (DataController.GetInstance().GetItemCount(5) >= 1)
                {
                    DataController.GetInstance().UseFoodItem(5);
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
                }
                break;
        }
        DataController.GetInstance().SetFoodCheckFALSE();
    }
}
