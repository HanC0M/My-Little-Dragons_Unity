using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{
    public GameObject panel;
    public void ChangeInventory()
    {
        panel.SetActive(!panel.active);
    }
}
