using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FoodClick : MonoBehaviour
{
   /* public Sprite[] salty;
    public Sprite[] goso;
    public Sprite[] sweet;
    public Sprite[] spicy;
    public Sprite[] sinmat;
    public Sprite[] sseunmat;*/
    public void Salty()
    {
      //  gameObject.GetComponent<Image>().sprite = salty[1];
      
        DataController.GetInstance().SetItemCode(0);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Goso()
    {
        
       // gameObject.GetComponent<Image>().sprite = goso[1];
        
        DataController.GetInstance().SetItemCode(1);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Spicy()
    {
        
     //   gameObject.GetComponent<Image>().sprite = spicy[1];
        
        DataController.GetInstance().SetItemCode(2);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Sinmat()
    {
        
      //  gameObject.GetComponent<Image>().sprite = sinmat[1];
        
        DataController.GetInstance().SetItemCode(3);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Sseunmat()
    {
        
        //gameObject.GetComponent<Image>().sprite = sseunmat[1];
        
        DataController.GetInstance().SetItemCode(4);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Sweet()
    {
       
        //gameObject.GetComponent<Image>().sprite = sweet[1];
        DataController.GetInstance().SetItemCode(5);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
}
