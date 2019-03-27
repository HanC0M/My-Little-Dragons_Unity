using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotButton : MonoBehaviour
{
    public void OnClick1()
    {
        DataController.GetInstance().SetItem(0);
        Debug.Log("ㅇㅇ");
    }
    public void OnClick2()
    {
        DataController.GetInstance().SetItem(1);
        Debug.Log("ㅇㅇ1");
    }
    public void OnClick3()
    {
        DataController.GetInstance().SetItem(2);
        Debug.Log("ㅇㅇ2");
    }
    public void OnClick4()
    {
        DataController.GetInstance().SetItem(3);
        Debug.Log("ㅇㅇ3");
    }
    public void OnClick5()
    {
        DataController.GetInstance().SetItem(4);
        Debug.Log("ㅇㅇ4");
    }
    public void OnClick6()
    {
        DataController.GetInstance().SetItem(5);
        Debug.Log("ㅇㅇ5");
    }
}
