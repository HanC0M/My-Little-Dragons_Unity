using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyTab : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetTabCheckToy();
    }
}
