using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WashCheck : MonoBehaviour
{
    public Sprite[] img;
    public DataController dataController;
    
 
    public void OnClick()
    {
        if (!DataController.GetInstance().GetWashCheck())
        {
            gameObject.GetComponent<Image>().sprite = img[1];
            DataController.GetInstance().SetWashCheckTRUE();
            Debug.Log(DataController.GetInstance().GetWashCheck());
          
        }

       else if (DataController.GetInstance().GetWashCheck())
        {
            gameObject.GetComponent<Image>().sprite = img[0];
            DataController.GetInstance().SetWashCheckFALSE();
            Debug.Log(DataController.GetInstance().GetWashCheck());
           
        }
    }
}
