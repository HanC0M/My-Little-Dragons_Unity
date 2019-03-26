using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{
 

    public Sprite[] img;

    float dragDis;
    public float dragMaxDis = 60.0f;
    Vector2 preTouchPos;
    Vector2 curTouPos;

    bool pointerIn;
    public void TouchCheck()
    {
        preTouchPos = Input.mousePosition;
        curTouPos = Input.mousePosition;
        dragDis = 0;
    }
    public void DragCheck()
    {
        DataController.GetInstance().DragCheckTRUE();
        if (pointerIn)
        {
            curTouPos = Input.mousePosition;
            dragDis += Mathf.Abs((preTouchPos - curTouPos).magnitude);
            if (dragDis > dragMaxDis)
            {
                if (DataController.GetInstance().GetWashCheck() == false) {
                    
                    float exp = DataController.GetInstance().GetExp();

                dragDis = 0;
                 
                DataController.GetInstance().AddFavor(0.025f);
                if (DataController.GetInstance().GetFavor() >= 100)
                {
                    DataController.GetInstance().SetFavor(100);
                }
                    if (DataController.GetInstance().GetLevel() < 10)
                    {
                        DataController.GetInstance().AddExp(0.05f);
                    }
                DataController.GetInstance().AddGold(0.1f);
            }
                else if (DataController.GetInstance().GetWashCheck() == true)
                {
                    dragDis = 0;
                    if (DataController.GetInstance().GetClean() >= 100)
                    {
                        DataController.GetInstance().SetClean(100);
                    }
                    DataController.GetInstance().AddClean(0.08f);
                }
            }
            preTouchPos = curTouPos;
        }
    }
    public void PointerIn()
    {
        pointerIn = true;
        
    }

    public void PointerQuit()
    {
        pointerIn = false;
        DataController.GetInstance().DragCheckFALSE();
    }
}
