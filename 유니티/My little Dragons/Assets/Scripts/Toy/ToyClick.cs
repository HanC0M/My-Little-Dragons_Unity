using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyClick : MonoBehaviour
{
    public void Tennis()
    {
        DataController.GetInstance().SetToyCode(0);
        DataController.GetInstance().SetShopCode(6);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
    public void Wonban()
    {
        DataController.GetInstance().SetToyCode(1);
        DataController.GetInstance().SetShopCode(7);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
    public void Doll()
    {
        DataController.GetInstance().SetToyCode(2);
        DataController.GetInstance().SetShopCode(8);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
    public void Evo_Fire()
    {
        DataController.GetInstance().SetToyCode(3);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
    public void Evo_Ice()
    {
        DataController.GetInstance().SetToyCode(4);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
}
