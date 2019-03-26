using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonSprite : MonoBehaviour
{
    public Sprite[] img;
    void Update()
    {
        if (DataController.GetInstance().GetFavor() >= 70)
        {
            if (DataController.GetInstance().GetDragCheck() == true)
            {
                gameObject.GetComponent<Image>().sprite = img[3];

            }
            else
            {
                gameObject.GetComponent<Image>().sprite = img[1];
            }
        }
        else if (DataController.GetInstance().GetFavor() <= 30)
        {
            if (DataController.GetInstance().GetDragCheck() == true)
            {
                gameObject.GetComponent<Image>().sprite = img[3];
             
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = img[2];
            }
        }

        else
        {
            if (DataController.GetInstance().GetDragCheck() == true)
            {
                gameObject.GetComponent<Image>().sprite = img[3];
              
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = img[0];
            }

        }
    }
}
