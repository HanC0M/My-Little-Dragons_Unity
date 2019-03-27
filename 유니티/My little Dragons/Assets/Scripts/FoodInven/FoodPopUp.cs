using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPopUp : MonoBehaviour
{
    public GameObject FoodInvenPop;
    // Start is called before the first frame update
    void Start()
    {
        FoodInvenPop.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DataController.GetInstance().GetFoodCheck() == true)
        {
            FoodInvenPop.gameObject.SetActive(true);
        }
        else if(DataController.GetInstance().GetFoodCheck() == false)
        {
            FoodInvenPop.gameObject.SetActive(false);
        }
    }
}
