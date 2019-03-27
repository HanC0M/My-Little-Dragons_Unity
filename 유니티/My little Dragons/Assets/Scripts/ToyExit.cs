using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyExit : MonoBehaviour
{
    public void OnClick()
    {
        DataController.GetInstance().SetToyCheckFALSE();
    }
}
