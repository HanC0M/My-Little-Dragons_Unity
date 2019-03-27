using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPopUp : MonoBehaviour
{
    public GameObject inventoryPopUp;

    void Awake()
    {
        inventoryPopUp.SetActive(false);
    }

    void Update()
    {
        if (DataController.GetInstance().GetInventoryCheck() == true)
        {
            inventoryPopUp.SetActive(true);
        }
        else
        {
            inventoryPopUp.SetActive(false);
        }
    }
}
