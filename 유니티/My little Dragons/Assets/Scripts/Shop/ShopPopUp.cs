using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPopUp : MonoBehaviour
{
    public GameObject ShopPop;
    // Start is called before the first frame update
    void Start()
    {
        ShopPop.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DataController.GetInstance().GetShopCheck() == true)
        {
            ShopPop.gameObject.SetActive(true);
        }
        else if (DataController.GetInstance().GetShopCheck() == false)
        {
            ShopPop.gameObject.SetActive(false);
        }
    }
}
