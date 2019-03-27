using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyClick : MonoBehaviour
{
    public void Tennis()
    {
        DataController.GetInstance().SetToyCode(0);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
    public void Wonban()
    {
        DataController.GetInstance().SetToyCode(1);
        Debug.Log(DataController.GetInstance().GetToyCode());
    }
    public void Doll()
    {
        DataController.GetInstance().SetToyCode(2);
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
