using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyUseButton : MonoBehaviour
{
    public void OnClick()
    {
        switch (DataController.GetInstance().GetToyCode())
        {
            case 0:
                if (DataController.GetInstance().GetItemCount(6) >= 1)
                {
                    DataController.GetInstance().UseToyItem(0);
                    DataController.GetInstance().SubBoredom(8f);
                    if (DataController.GetInstance().GetBoredom() <= 0)
                    {
                        DataController.GetInstance().SetBoredom(0);
                    }
                    DataController.GetInstance().AddFavor(8f);
                    if (DataController.GetInstance().GetFavor() >= 100)
                    {
                        DataController.GetInstance().SetFavor(100);
                    }
                    DataController.GetInstance().AddExp(7f);
                }
                break;

            case 1:
                DataController.GetInstance().UseToyItem(1);
                if (DataController.GetInstance().GetItemCount(7) >= 1)
                {
                    DataController.GetInstance().SubBoredom(14f);
                    if (DataController.GetInstance().GetBoredom() <= 0)
                    {
                        DataController.GetInstance().SetBoredom(0);
                    }
                    DataController.GetInstance().AddFavor(10f);
                    if (DataController.GetInstance().GetFavor() >= 100)
                    {
                        DataController.GetInstance().SetFavor(100);
                    }
                    DataController.GetInstance().AddExp(9f);
                }
                break;

            case 2:
                if (DataController.GetInstance().GetItemCount(8) >= 1)
                {
                    DataController.GetInstance().UseToyItem(2);
                    DataController.GetInstance().SubBoredom(20f);
                    if (DataController.GetInstance().GetBoredom() <= 0)
                    {
                        DataController.GetInstance().SetBoredom(0);
                    }
                    DataController.GetInstance().AddFavor(10f);
                    if (DataController.GetInstance().GetFavor() >= 100)
                    {
                        DataController.GetInstance().SetFavor(100);
                    }
                    DataController.GetInstance().AddExp(9f);
                }
                break;

            
          
        }
        DataController.GetInstance().SetToyCheckFALSE();
    }
}
