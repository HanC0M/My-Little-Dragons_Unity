using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyPopUp : MonoBehaviour
{
    public GameObject ToyInvenPop;
    // Start is called before the first frame update
    void Start()
    {
        ToyInvenPop.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DataController.GetInstance().GetToyCheck() == true)
        {
            ToyInvenPop.gameObject.SetActive(true);
        }
        else if (DataController.GetInstance().GetToyCheck() == false)
        {
            ToyInvenPop.gameObject.SetActive(false);
        }
    }
}
