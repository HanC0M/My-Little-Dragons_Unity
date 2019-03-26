using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public DataController dataController;
    public void OnClick()
    {
        DataController.GetInstance().SubBoredom(10);
        if (DataController.GetInstance().GetBoredom() <= 0)
        {
            DataController.GetInstance().SetBoredom(0);
        }
        if (DataController.GetInstance().GetLevel() < 10)
        {
            DataController.GetInstance().AddExp(10);
        }
        DataController.GetInstance().AddFavor(1.5f);
        if (DataController.GetInstance().GetFavor() >= 100)
        {
            DataController.GetInstance().SetFavor(100);
        }
    }
}
